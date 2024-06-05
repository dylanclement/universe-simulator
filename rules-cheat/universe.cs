public class Universe: IUniverse
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    private List<IParticle> particles = new List<IParticle>();

    public void AddParticle(Particle particle)
    {
        particles.Add(particle);
    }

    public double GetTotalEnergy()
    { 
        double totalEnergy = 0;
        foreach (var particle in particles)
        {
            totalEnergy += particle.;
        }
        return totalEnergy;
    }
}