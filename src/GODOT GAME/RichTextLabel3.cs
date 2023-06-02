using Godot;
using System;

public partial class RichTextLabel3 : RichTextLabel
{
	string[] Texto = new string[14];
	int y = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		Texto[0] = "Frank: Salve o Grande irmão.";
		Texto[1] = "Chefe do Setor: Ja sabe o que fará no dia de hoje, Frank?";
		Texto[2] = "Frank: Fiquei sabendo que tem algumas papeladas...";
		Texto[3] = "Frank: sobre casos que foram passados pelo Ministério da verdade.";
		Texto[4] = "Chefe do setor: Correto, o mesmo de sempre.";
		Texto[5] = "Chefe do setor: Entregue as papelas sem questionar NADA, não deve ler, apenas entregar.";
		Texto[6] = "Frank: Como sempre, ao seu dispor.";
		Texto[7] = "Chefe do setor: Ja sabe da novidade em relação ao seu futuro ?";
		Texto[8] = "Chefe do setor: Ser uma pessoa prodígio tem seus benefícios mesmo.";
		Texto[9] = "Frank: Não, em relação ao que ?";
		Texto[10] = "Chefe do setor: Se não sabe, logo saberá.";
		Texto[11] = "Chefe do setor: Saia da minha sala e vá começar suas atividades.";
		Texto[12] = "MISSÃO - ENTREGUE AS PAPELADAS NAS MESAS DE SEUS COLEGAS";
		Texto[13] = "";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && y<14)
		{
			this.Text= Texto[y];
			y++;
			Global.y=y;
		}
		
	}

}



