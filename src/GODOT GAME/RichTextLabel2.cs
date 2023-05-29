using Godot;
using System;

public partial class RichTextLabel2 : RichTextLabel
{
	string[] Texto = new string[6];
	int x = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Texto[0] = "FRANK É UM HOMEM DE MEIA IDADE QUE VIVE NO SEGUNDO ANDAR DESSE PRÉDIO - O ESCRITÓRIO";
		Texto[1] = "LÁ ELE CUIDA DE TODAS AS PAPELADAS DESSE EDIFÍCIO.";
		Texto[2] = "MESMO ELE SENDO APENAS MAIS UM NO MEIO DE TANTOS OUTROS";
		Texto[3] = "FRANK PERTENCE A CLASSE DOS PRODÍGIOS";
		Texto[4] = "ONDE A ASCENSÃO SOCIAL É PERMITIDA PELO GRANDE IRMÃO";
		Texto[5] = "MISSÃO - VÁ NA SALA DO CHEFE DO SEU SETOR, ELE QUER FALAR COM VOCÊ...";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && x<6)
		{
			x++;
			Global.x=x;
		}
		this.Text= Texto[x];
	}
}
