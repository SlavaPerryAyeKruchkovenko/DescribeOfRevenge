using Godot;

public class Character : KinematicBody2D
{
    public CharacterSystem CharSystem { get; private set; }
    public Sprite PlayerImage { get; private set; }
    private const float jumpForce = 400;
    private const float gravity = 9.8f;

    public override void _Ready()
    {
        PlayerImage = (Sprite)GetNode("Person");
        CharSystem = (CharacterSystem)GetNode(nameof(CharacterSystem));
    }

    public override void _PhysicsProcess(float delta)
    {

        Vector2 direction = Vector2.Zero;
        if (Input.IsActionPressed("move_left"))
        {
            direction.x = -CharSystem.Speed;
            PlayerImage.FlipH = true;
        }

        if (Input.IsActionPressed("move_right"))
        {
            direction.x = CharSystem.Speed;
            PlayerImage.FlipH = false;
        }

        if (Input.IsActionPressed("move_up") && IsOnFloor())
        {
            direction.y -= gravity * CharSystem.Speed;
        }

        if (Input.IsActionPressed("move_down") && IsOnFloor())
        {
            direction.y += gravity * CharSystem.Speed;
        }
        direction.y += Mathf.Pow(gravity, 2) * 2;
        GD.Print(direction);
        MoveAndSlide(direction, Vector2.Up);
    }

}
