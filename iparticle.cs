using System.ComponentModel;
using System.Numerics;


public interface IParticle
{
    
    double energy { get; set; }
    Vector3 momentum { get; set; }
    Vector3 position { get; set; }
    public bool Tick();
}