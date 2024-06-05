using System.Numerics;

public interface IUniverse
{
    // Create a new universe with the given dimensions
    public bool Create(ulong width, ulong height, ulong depth);
    
    // Should not add energy/particles/matter to universe once running
    public void AddParticle(IParticle particle);
    public void AddPhoton(ulong frequency, Vector3 pos, Vector3 dir);
    public void AddPhoton(ulong frequency, IParticle source, Vector3 dir);
    public void AddAtom(Vector3 pos, uint numProtons);

    // Run the universe for a duration
    public Task Run(ulong duration = ulong.MaxValue);

    // Get the total energy of the universe, all particles and matter combined (useful for testing)
    public double GetTotalEnergy();
    
}