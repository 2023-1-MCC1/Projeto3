using Godot;
using System;

public partial class Transicao2 : Node2D
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
	Global.Transition2++;
	GetTree().ChangeSceneToFile("res://CorredorCut.tscn");
}

}


