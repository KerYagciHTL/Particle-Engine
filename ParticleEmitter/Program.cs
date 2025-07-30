using ParticleEmitter.Core;

namespace ParticleEmitter;

public static class Program
{
    private static readonly ParticleEngine Engine = new();
    
    private static void Main()
    {
        Engine.DoSomething();
    }
}