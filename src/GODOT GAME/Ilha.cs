using Godot;
using System;
public partial class Ilha : Sprite2D

{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		float pos = this.Position.Y;
		pos = pos + (0.07f);
		float stopY = 1470.0f;
		if (pos >= stopY )
		{
			pos = stopY;
			if(Global.i>=7)
			{
				GetTree().ChangeSceneToFile("res://FrankCUT.tscn");
			}
		}
		this.Position =  new Vector2 (1118,pos);
		
	}
	private void _on_button_pressed()
{
	GetTree().ChangeSceneToFile("res://Game.tscn");
}
}



