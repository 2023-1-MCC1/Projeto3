using Godot;
using System;

public partial class TribunalFuga : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_animation_player_animation_finished(StringName anim_name)
{
	GetTree().ChangeSceneToFile("res://Fuga.tscn");
}

}


