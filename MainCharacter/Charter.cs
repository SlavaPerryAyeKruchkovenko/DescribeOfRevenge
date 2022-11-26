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
        base._PhysicsProcess(delta);
        if (Input.IsActionPressed("move_left"))
        {

        }
        else if (Input.IsActionPressed("move_right"))
        {

        }
        else if (Input.IsActionPressed("move_up"))
        {

        }
        else if (Input.IsActionPressed("move_down"))
        {

        }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
