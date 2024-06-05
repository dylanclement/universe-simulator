using System.ComponentModel;
using System.Numerics;

namespace universe_simulator.standard_model;
public class Particle: IParticle
{
    public double energy { get; set; }
    public Vector3 momentum { get; set; }
    public double mass  { get; set; }
    public Vector3 position { get ; set ; }
    public Particle(double energy, Vector3 momentum, double mass)
    {
        this.energy = energy;
        this.momentum = momentum;
        this.mass = mass;
    }
}