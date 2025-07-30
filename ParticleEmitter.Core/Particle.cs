namespace ParticleEmitter.Core;

public class Particle
{
    public const char SIGN = '?';

    public readonly ConsoleColor COLOR;

    public int X;
    public int Y;

    public HorizontalDirection HorizontalDirection;
    public VerticalDirection VerticalDirection;
    public Particle()
    {
        COLOR = (ConsoleColor)Random.Shared.Next(1, 14);
        X = Random.Shared.Next(1, Console.WindowWidth - 1);
        Y = Random.Shared.Next(1, Console.WindowHeight - 1);
        
        HorizontalDirection = (HorizontalDirection)Random.Shared.Next(1, 3);
        VerticalDirection = (VerticalDirection)Random.Shared.Next(1, 3);
    }
    public void Update()
    {
        switch (HorizontalDirection)
        {
            case HorizontalDirection.Up:
                Y--;
                break;
            case HorizontalDirection.Down:
                Y++;
                break;
        }

        switch (VerticalDirection)
        {
            case VerticalDirection.Left:
                X--;
                break;
            case VerticalDirection.Right:
                X++;
                break;
        }

        if (Y <= 0)
        {
            Y = 0;
            HorizontalDirection = HorizontalDirection.Down;
        }
        else if (Y >= Console.WindowHeight - 1)
        {
            Y = Console.WindowHeight - 1;
            HorizontalDirection = HorizontalDirection.Up;
        }

        if (X <= 0)
        {
            X = 0;
            VerticalDirection = VerticalDirection.Right;
        }
        else if (X >= Console.WindowWidth - 1)
        {
            X = Console.WindowWidth - 1;
            VerticalDirection = VerticalDirection.Left;
        }
    }


    public void Draw()
    {
        Console.SetCursorPosition(X, Y);
        
        Console.ForegroundColor = COLOR;
        Console.Write(SIGN);
        Console.ResetColor();
    }

}