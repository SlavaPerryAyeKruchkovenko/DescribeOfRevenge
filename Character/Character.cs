using Godot;

public class Charter : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public override void _PhysicsProcess(float delta)
    {
        var direction = Vector2.Zero;
        var system = (CharacterSystem)GetNode(nameof(CharacterSystem));
        base._PhysicsProcess(delta);
        if (Input.IsActionPressed("move_left"))
        {
            vector.x -= 1;
        }
        else if (Input.IsActionPressed("move_right"))
        {
            vector.x += 2;
        }
        else if (Input.IsActionPressed("move_up"))
        {

        }
        else if (Input.IsActionPressed("move_down"))
        {

        }
        MoveAndSlide(direction)
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
