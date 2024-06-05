public interface IUniverse
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public void AddParticle(Particle particle);
    public void AddPhoton();
    public double GetTotalEnergy();    
    public Task Run(ulong duration = ulong.MaxValue);
    
}