using Godot;
using System;

public class Item : Node
{
    public const string SpriteName = "Sprite";

    public override void _Ready()
    {

    }

    public override void _Process(float delta)
    {
        var sprite = (Sprite)GetNode(SpriteName);
    }
}
