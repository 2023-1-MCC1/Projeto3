using Godot;
using System;

public partial class Frank : Godot.CharacterBody2D
{
	public const float Speed = 160.0f;
	public const float JumpVelocity = -310.0f;
	public AnimationPlayer animacao;
	public float gravity = 0f;
	int area1;
	int area2;
	
	public override void _Ready(){
		animacao = this.GetNode<AnimationPlayer>("AnimationPlayer");
		if (Global.g>=1){this.Position = new Vector2(183,225);}
		if (Global.PrisionCutFinished>=1){this.Position = new Vector2(1524,157);}
		if (Global.Transition2==1){this.Position = new Vector2(278,629);}
		if (Global.maze==1){this.Position = new Vector2(959,429);}
	}
		

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

			// Handle Jump.
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
			velocity.Y = JumpVelocity;

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = new Vector2(
			Input.GetActionStrength("wR") - Input.GetActionStrength("wL"),
			Input.GetActionStrength("down") - Input.GetActionStrength("up")
		);

		// Limit the movement to either horizontal or vertical only
		if (Mathf.Abs(direction.X) > Mathf.Abs(direction.Y))
		{
			// Move horizontally
			velocity.X = direction.X * Speed;
			velocity.Y = 0;
			if (direction.X < 0 )
			{
				animacao.Play("wL");
			}
			else if (direction.X > 0 )
			{
				animacao.Play("wR");
			}
		}
		else if (Mathf.Abs(direction.Y) > Mathf.Abs(direction.X))
		{
			// Move vertically
			velocity.X = 0;
			velocity.Y = direction.Y * Speed;
			if (direction.Y > 0)
			{
				animacao.Play("down");
			}
			else if (direction.Y < 0)
			{
				animacao.Play("up");
			}
		}
		else
		{
			// No movement
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
		if (Global.time == 45)
		{
			GetTree().ChangeSceneToFile("res://GAMEOVER.tscn");
		}
		
	}
	private void _on_area_2d_body_shape_entered(Rid body_rid, Node2D body, long body_shape_index, long local_shape_index)
{
	GetTree().ChangeSceneToFile("res://BossCUT.tscn");
	
}
private void _on_area_2d_entrega_1_body_entered(Node2D body)
{
	Global.EntregaUm++;
	
	
}
private void _on_area_2d_entrega_1_body_exited(Node2D body)
{
	Global.EntregaUm++;
	Global.Contagem++;
	if (Global.Contagem==6){GetTree().ChangeSceneToFile("res://Prision.tscn");}
}

private void _on_area_2d_entrega_2_body_entered(Node2D body)
{
	Global.EntregaDois++;
	
	
}
private void _on_area_2d_entrega_2_body_exited(Node2D body)
{
	Global.EntregaDois++;
	Global.Contagem++;
	if (Global.Contagem==6){GetTree().ChangeSceneToFile("res://Prision.tscn");}
	
}
private void _on_area_2d_entrega_3_body_entered(Node2D body)
{
	Global.EntregaTres++;
	
}
private void _on_area_2d_entrega_3_body_exited(Node2D body)
{
	Global.EntregaTres++;
	Global.Contagem++;
	if (Global.Contagem==6){GetTree().ChangeSceneToFile("res://Prision.tscn");}
}
private void _on_area_2d_entrega_4_body_entered(Node2D body)
{
	Global.EntregaQuatro++;
	
}
private void _on_area_2d_entrega_4_body_exited(Node2D body)
{
	Global.EntregaQuatro++;
	Global.Contagem++;
	if (Global.Contagem==6){GetTree().ChangeSceneToFile("res://Prision.tscn");}
}
private void _on_area_2d_entrega_5_body_entered(Node2D body)
{
	Global.EntregaCinco++;
}
private void _on_area_2d_entrega_5_body_exited(Node2D body)
{
	Global.EntregaCinco++;
	Global.Contagem++;
	if (Global.Contagem==6){GetTree().ChangeSceneToFile("res://Prision.tscn");}
}
private void _on_area_2d_entrega_6_body_entered(Node2D body)
{
	Global.EntregaSeis++;
}
private void _on_area_2d_entrega_6_body_exited(Node2D body)
{
	Global.EntregaSeis++;
	Global.Contagem++;
	if (Global.Contagem==6){GetTree().ChangeSceneToFile("res://Prision.tscn");}
}
private void _on_area_2d_cut_final_body_shape_entered(Rid body_rid, Node2D body, long body_shape_index, long local_shape_index)
{
	GetTree().ChangeSceneToFile("res://Transicao.tscn");
}
private void _on_area_2d_corredor_body_entered(Node2D body)
{
	GetTree().ChangeSceneToFile("res://Tribunal.tscn");
}

private void _on_timer_timeout()
{
	Global.time++;
}
private void _on_area_2dfinal_body_entered(Node2D body)
{
	GetTree().ChangeSceneToFile("res://Final.tscn");
}

}



