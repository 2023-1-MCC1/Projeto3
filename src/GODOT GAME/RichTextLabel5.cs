using Godot;
using System;

public partial class RichTextLabel5 : RichTextLabel
{
	string[] Texto = new string[11];
	int transition = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		Texto[0] = "Frank: Esse é meu nome.";
		Texto[1] = "Guardas: O senhor está sendo chamado pelo GRANDE IRMÃO...";
		Texto[2] = "Guardas: Ele vê tudo e todos..";
		Texto[3] = "Guardas: Você não faz ideia da merda que acabou de fazer";
		Texto[4] = "Frank: ...";
		Texto[5] = "Guardas: Vamos logo, não temos o dia todo.";
		Texto[6] = "Pensamento de FRANK: Put* que pariu, não devia ter lido a papelada";
		Texto[7] = "Pensamento de FRANK: ELES VÃO ME MATAR!";
		Texto[8] = "Guardas: Vai colaborar ou teremos que algemá-lo?";
		Texto[9] = "Frank: Está tudo bem, vamos resolver isso...";
		Texto[10] = "";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && transition<11)
		{
			this.Text = Texto[transition];
			transition++;
			Global.transition=transition;
		}
		
	}
}
