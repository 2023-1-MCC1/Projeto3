using Godot;
using System;

public partial class Area2DEntrega : Area2D
{
	CollisionShape2D x;
	Sprite2D y;
	Sprite2D z;
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
		z = this.GetNode<Sprite2D>("6TylerSankara");
		if (Global.EntregaUm == 1)
		{
			z.Visible = true;
		}
		if (Global.EntregaUm==2)
			{
				x.Disabled = true;
				y.Visible = false;
				z.Visible = false;
				
			}
		
	}
}
