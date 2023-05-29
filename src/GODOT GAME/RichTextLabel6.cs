using Godot;
using System;

public partial class RichTextLabel6 : RichTextLabel
{
	string[] Texto = new string[2];
	int CorredorCut = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Texto[0]= "Guardas: Vá até o final do corredor, você irá parar no tribunal.";
		Texto[1]= "Guardas: Não olhe para trás, não volte, não fuja.";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && CorredorCut<2)
		{
			CorredorCut++;
			Global.CorredorCut=CorredorCut;
		}
		this.Text = Texto[CorredorCut];
	}
}
