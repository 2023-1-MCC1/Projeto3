using Godot;
using System;

public partial class RichTextLabel4 : RichTextLabel
{
	string[] Texto = new string[5]; 
	int prisao = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Texto[0] = "Guardas: Estamos procurando o cidadão FRANK";
		Texto[1] = "Guardas: Ele tem assuntos a resolver com o GRANDE IRMÃO";
		Texto[2] = "Guardas: Apareça IMEDIATAMENTE";
		Texto[3] = "Guardas: Ou as consequências serão devastadoras.";
		Texto[4] = "VÁ DE ENCONTRO COM OS GUARDAS.";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && prisao<4)
		{
			prisao++;
			Global.prisao=prisao;
		}
		this.Text= Texto[prisao];
	}
}
