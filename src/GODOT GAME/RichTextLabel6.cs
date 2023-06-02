using Godot;
using System;

public partial class RichTextLabel6 : RichTextLabel
{
	string[] Texto = new string[2];
	int CorredorCut = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		Texto[0]= "Guardas: Não olhe para trás, não volte, não fuja.";
		Texto[1]= "";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && CorredorCut<2)
		{
			this.Text = Texto[CorredorCut];
			CorredorCut++;
			Global.CorredorCut=CorredorCut;
		}
		
	}
}
