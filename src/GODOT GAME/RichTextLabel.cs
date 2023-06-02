using Godot;
using System;

public partial class RichTextLabel : Godot.RichTextLabel
{
	string[] Texto = new string[7]; 
	int i = 0;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	
	Texto[0] = "E SE CADA ANDAR DESSE PRÉDIO REPRESENTASSE UMA CLASSE SOCIAL DIFERENTE.";
	Texto[1] = "ONDE A MAIORIA FICA NO SUBSOLO E ELA TUDO PRODUZ, MAS A ELA NADA PERTENCE.";
	Texto[2] = "A ASCENSÃO SOCIAL FICARIA RESTRITA PARA UMA PEQUENÍSSIMA PARTE DESSA SOCIEDADE";
	Texto[3] = "E TODO O RESTO VIVERIA SUA VIDA INTEIRA OBCECADOS E EXTREMAMENTE HIPNOTIZADOS";
	Texto[4] = "POR UM SER QUE SE DIZ LÍDER DESSE GRANDE BLOCO DE CONCRETO";
	Texto[5] = "E PARA VOCÊ, SE PARECE COM ALGO UTÓPICO ?";
	Texto[6] = "E PARA VOCÊ, SE PARECE COM ALGO UTÓPICO ?";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && i<7)
		{
			this.Text = Texto[i];
			i++;
			Global.i=i;
		}
		
	}
}
