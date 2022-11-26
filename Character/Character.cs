using Godot;

public class Character : KinematicBody2D
{
    Sprite PlayerImage;
    float jumpForce = 30;
    float gravity = 9.8f;
    public override void _Ready()
    {
        PlayerImage = (Sprite)GetNode("Icon");
    }
    public override void _PhysicsProcess(float delta)
    {
        var direction = Vector2.Zero;
        var system = (CharacterSystem)GetNode(nameof(CharacterSystem));
        base._PhysicsProcess(delta);
        if (Input.IsActionPressed("move_left"))
        {
            direction.x -= system.Speed;
            PlayerImage.FlipH = true;
        }
        else if (Input.IsActionPressed("move_right"))
        {
            direction.x += system.Speed;
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

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
