using Godot;
using System;

public partial class Area2DEntrega6 : Area2D
{
	CollisionShape2D x;
	Sprite2D y;
	Sprite2D z;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		x = this.GetNode<CollisionShape2D>("CollisionShape2D");
		if (Global.g>=1)
		{
			x.Disabled = false;
		}
		y = this.GetNode<Sprite2D>("Seta");
		if (Global.g>=1)
		{
			y.Visible = true;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		z = this.GetNode<Sprite2D>("3FranciscoPaz");
		if (Global.EntregaSeis==1)
		{
			z.Visible = true;
		}
		if (Global.EntregaSeis==2)
			{
				x.Disabled = true;
				y.Visible = false;
				z.Visible = false;
			}
	}
}
