using Godot;
using System;

public partial class RichTextLabel5 : RichTextLabel
{
	string[] Texto = new string[11];
	int transition = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Texto[0] = "Guardas: Você é o FRANK?";
		Texto[1] = "Frank: Esse é meu nome.";
		Texto[2] = "Guardas: O senhor está sendo chamado pelo GRANDE IRMÃO...";
		Texto[3] = "Guardas: Ele vê tudo e todos..";
		Texto[4] = "Guardas: Você não faz ideia da merda que acabou de fazer";
		Texto[5] = "Frank: ...";
		Texto[6] = "Guardas: Vamos logo, não temos o dia todo.";
		Texto[7] = "Pensamento de FRANK: Put* que pariu, não devia ter lido a papelada";
		Texto[8] = "Pensamento de FRANK: ELES VÃO ME MATAR!";
		Texto[9] = "Guardas: Vai colaborar ou teremos que algemá-lo?";
		Texto[10] = "Frank: Está tudo bem, vamos resolver isso...";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && transition<11)
		{
			transition++;
			Global.transition=transition;
		}
		this.Text = Texto[transition];
	}
}
