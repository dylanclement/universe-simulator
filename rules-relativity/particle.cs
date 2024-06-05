using System.ComponentModel;
using System.Numerics;

namespace universe_simulator.relativity;

public class Particle: IParticle
{
    public double energy { get; set; }
    public Vector3 momentum { get; set; }
    public double mass  { get; set; }
    public Vector3 position { get ; set ; }
    public Particle(double energy, Vector3 position, double mass, Vector3 momentum)
    {
        this.energy = energy;
        this.position = position;
        this.mass = mass;
        this.momentum = momentum;
    }
}
