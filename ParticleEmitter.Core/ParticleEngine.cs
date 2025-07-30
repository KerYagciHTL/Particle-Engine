namespace ParticleEmitter.Core;

public class ParticleEngine
{
    public const int ELEMENTS = 10;
    
    private readonly Particle[] _particles = new  Particle[ELEMENTS];

    public void Init()
    {
        for (var i = 0; i < ELEMENTS; i++)
        {
            _particles[i] = new Particle();
        }
    }
    public void Update()
    {
        foreach (var particle in _particles)
        {
            particle.Update();
        }
    }
    public void Draw()
    {
        foreach (var particle in _particles)
        {
            particle.Draw();
        }
    }
}