using System.Text;
using ParticleEmitter.Core;

namespace ParticleEmitter;

public static class Program
{
    private static readonly ParticleEngine Engine = new();
    
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Engine.Init();
        
        while (true)
        {
            Console.Clear();
            Engine.Update();
            Engine.Draw();
            
            Thread.Sleep(50);
        }
    }
}