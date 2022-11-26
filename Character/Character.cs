using Godot;

public class Character : KinematicBody2D
{
    public CharacterSystem CharSystem { get; private set; }
    public Sprite PlayerImage { get; private set; }
    float jumpForce = 30;
    float gravity = 9.8f;
    public override void _Ready()
    {
        PlayerImage = (Sprite)GetNode("Icon");
        CharSystem = (CharacterSystem)GetNode(nameof(CharacterSystem));
    }
    public override void _PhysicsProcess(float delta)
    {
        var direction = Vector2.Zero;
        base._PhysicsProcess(delta);
        if (Input.IsActionPressed("move_left"))
        {
            direction.x -= CharSystem.Speed;
            PlayerImage.FlipH = true;
        }
        else if (Input.IsActionPressed("move_right"))
        {
            GD.Print(CharSystem);
            direction.x += CharSystem.Speed;
            PlayerImage.FlipH = false;
        }
        else if (Input.IsActionPressed("move_up") && IsOnFloor())
        {
            direction.y += jumpForce;
        }
        else if (Input.IsActionPressed("move_down") && IsOnFloor())
        {
            direction.y -= gravity;
        }
        MoveAndSlide(direction, Vector2.Up);
    }

}
