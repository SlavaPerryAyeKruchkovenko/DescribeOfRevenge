using Godot;
using System;

public class ItemSprite : Sprite
{
    [Export] public float MaxYPosition { get; set; } = 70;
    [Export] public int AnimationSpeed { get; set; } = 50;

    private bool IsUp { get; set; }
    public float StartYPosition { get; set; }

    public override void _Ready()
    {
        IsUp = true;
        StartYPosition = Position[1];
    }

    public override void _Process(float delta)
    {
        var velocity = (IsUp ? 1 : -1) * AnimationSpeed * delta;

        Position += Vector2.Up * velocity;

        if (Position.y < StartYPosition - MaxYPosition)
        {
            Position = new Vector2(Position.x, StartYPosition - MaxYPosition);
            IsUp = false;
        }
        else if (Position.y > StartYPosition)
        {
            Position = new Vector2(Position.x, StartYPosition);
            IsUp = true;
        }
    }
}
