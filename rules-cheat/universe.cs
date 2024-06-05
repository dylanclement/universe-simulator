using System.Numerics;

namespace universe_simulator.cheat;
public class Universe: IUniverse
{
    public double width { get; set; }
    public double height { get; set; }
    public double depth { get; set; }
    private List<IParticle> particles;

    public Universe()
    {
        particles = new List<IParticle>();
    }

    public double GetTotalEnergy()
    { 
        double totalEnergy = 0;
        foreach (var particle in particles)
        {
            totalEnergy += particle.energy;
        }
        return totalEnergy;
    }

    public bool Create(ulong width, ulong height, ulong depth)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
        return true;
    }

    public void AddParticle(IParticle particle)
    {
        particles.Add(particle);
    }

    public void AddPhoton(ulong frequency, Vector3 pos, Vector3 dir)
    {
        // Hack, no source particle, create a null poarticle at the start location
        var source = new Particle(frequency * CONSTANTS.PLANCK_CONSTANT, pos, Vector3.Zero);

        var photon = new Photon(frequency, source, dir);
        particles.Add(photon);
    }

    public void AddPhoton(ulong frequency, IParticle source, Vector3 dir)
    {
        var photon = new Photon(frequency, source, dir);
        particles.Add(photon);
    }

    public Task Run(ulong duration = ulong.MaxValue)
    {
        return new Task(() => 
        {
            for (ulong i = 0; i < duration; i++)
            {
                foreach (var particle in particles)
                {
                    particle.Tick();
                }
            }
        });
    }

    double IUniverse.GetTotalEnergy()
    {
        return particles.Sum(p => p.energy);
    }

    public void AddAtom(Vector3 pos, Vector3 dir, uint numProtons = 1, uint numNeutrons = 0, uint numElectrons = 1)
    {
        var matter = new Matter(pos, dir, numProtons, numNeutrons, numElectrons);
        particles.Add(matter);
    }
}