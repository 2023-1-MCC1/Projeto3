using Godot;
using System;

public partial class Transicao : Node2D
{
	int j = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Global.transition>=11 && j==1)
		{
			GetTree().ChangeSceneToFile("res://Transicao2.tscn");
		}
	}
	private void _on_animation_player_animation_finished(StringName anim_name)
{
	j++;
}
}



