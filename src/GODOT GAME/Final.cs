using Godot;
using System;

public partial class Final : Node2D
{
	AudioStreamPlayer x;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_button_pressed()
{
	GetTree().ChangeSceneToFile("res://credit.tscn");
}
private void _on_audio_stream_player_finished()
{
	x = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	x.Play();
}


}




