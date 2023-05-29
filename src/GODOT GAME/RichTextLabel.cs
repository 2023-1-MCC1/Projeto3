using Godot;
using System;

public partial class RichTextLabel : Godot.RichTextLabel
{
	string[] Texto = new string[7]; 
	int i = 0;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	Texto[0] = "E SE O MUNDO INTEIRO ESTIVESSE DIVIDINDO O MESMO PRÉDIO.";
	Texto[1] = "E SE CADA ANDAR DESSE PRÉDIO REPRESENTASSE UMA CLASSE SOCIAL DIFERENTE.";
	Texto[2] = "ONDE A MAIORIA FICA NO SUBSOLO E ELA TUDO PRODUZ, MAS A ELA NADA PERTENCE.";
	Texto[3] = "A ASCENSÃO SOCIAL FICARIA RESTRITA PARA UMA PEQUENÍSSIMA PARTE DESSA SOCIEDADE";
	Texto[4] = "E TODO O RESTO VIVERIA SUA VIDA INTEIRA OBCECADOS E EXTREMAMENTE HIPNOTIZADOS";
	Texto[5] = "POR UM SER QUE SE DIZ LÍDER DESSE GRANDE BLOCO DE CONCRETO";
	Texto[6] = "E PARA VOCÊ, SE PARECE COM ALGO UTÓPICO ?";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && i<7)
		{
			i++;
			Global.i=i;
		}
		this.Text= Texto[i];
	}
}
