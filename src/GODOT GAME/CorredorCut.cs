using Godot;
using System;

public partial class CorredorCut : Node2D
{
	int c = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Global.CorredorCut>=2 && c==1)
		{
			GetTree().ChangeSceneToFile("res://Corredor.tscn");
		}
	}
	private void _on_animation_player_animation_finished(StringName anim_name)
{
	c++;
	Global.CorredorPosition++;
}
}



