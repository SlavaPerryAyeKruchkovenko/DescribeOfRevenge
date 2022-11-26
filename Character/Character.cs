using Godot;

public class Character : KinematicBody2D
{
    public CharacterSystem CharSystem { get; private set; }
    public Sprite PlayerImage { get; private set; }
    float jumpForce = 400;
    float gravity = 9.8f;

    public override void _Ready()
    {
        PlayerImage = (Sprite)GetNode("Icon");
        CharSystem = (CharacterSystem)GetNode(nameof(CharacterSystem));
    }
    public override void _PhysicsProcess(float delta)
    {

        Vector2 direction = Vector2.Zero;
        if (Input.IsActionPressed("move_left"))
        {
            direction.x = -1;
            PlayerImage.FlipH = true;
        }
        else if (Input.IsActionPressed("move_right"))
        {
            direction.x = 1;
            PlayerImage.FlipH = false;
        }
        else if (Input.IsActionPressed("move_up") && IsOnFloor())
        {
            direction.y -= gravity * 1.5f;
        }
        else if (Input.IsActionPressed("move_down") && IsOnFloor())
        {
            direction.y += gravity * 1.5f;
        }
        direction.y += Mathf.Pow(gravity, 2) * delta;

        MoveAndSlide(direction * CharSystem.Speed, Vector2.Up);
    }

}
