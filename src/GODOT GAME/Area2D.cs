using Godot;
using System;

public partial class Area2D : Godot.Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var x = this.GetNode<CollisionShape2D>("CollisionShape2D");
		if (Global.g>=1)
		{
			x.Disabled = true;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
