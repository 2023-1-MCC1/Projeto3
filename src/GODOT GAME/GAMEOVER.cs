using Godot;
using System;

public partial class GAMEOVER : Node2D
{
	
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
	Global.time = 0;
	GetTree().ChangeSceneToFile("res://Maze.tscn");
}
private void _on_button_2_pressed()
{
	Global.i=0;
	Global.x=0;
	Global.y=0;
	Global.g=0;
	Global.EntregaUm = 0;
	Global.EntregaDois = 0;
	Global.EntregaTres = 0;
	Global.EntregaQuatro = 0;
	Global.EntregaCinco = 0;
	Global.EntregaSeis = 0;
	Global.Contagem = 0;
	Global.prisao =0;
	Global.PrisionCutFinished = 0;
	Global.transition = 0;
	Global.Papel1 = 0;
	Global.Papel2 = 0;
	Global.Papel3 = 0;
	Global.Papel4 = 0;
	Global.Papel5 = 0;
	Global.Papel6 = 0;
	Global.Transition2 = 0;
	Global.CorredorCut = 0;
	Global.AreaCorredor1 = 0;
	Global.tribunal = 0;
	Global.time = 0;
	GetTree().ChangeSceneToFile("res://TrackSuit.tscn");
}
}






