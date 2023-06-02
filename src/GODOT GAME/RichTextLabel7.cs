using Godot;
using System;

public partial class RichTextLabel7 : RichTextLabel
{
	string[] Texto = new string [22];
	int tribunal = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		Texto[0]= "Frank: Frank Cobain, Piso do escritório. Idade, ééééééé. Eu na verdade não me lembro.";
		Texto[1]= "Frank: Não costumo me questionar sobre essas coisas, na real não costumo me questionar sobre nada";
		Texto[2]= "Juiza: Certo. Não era algo que espereva que soubesse.";
		Texto[3]= "Juiza: Bom parece que você andou se metendo em lugares que não podia.";
		Texto[4]= "Juiza: Colocando seus olhos onde não deveria.";
		Texto[5]= "Frank: Eu juro que não vi nada demais.";
		Texto[6]= "Juiza: Ninguem nunca ve nada demais, afinal o que tem demais para se ver ?";
		Texto[7]= "Juiza: São apenas documentos sobre pessoas, não são Frank ? ";
		Texto[8]= "Frank: SIM, são apenas documentos Vossa Excelência. ";
		Texto[9]= "Frank: Um amontuado de documentos sobre pessoas que não conheço.";
		Texto[10]= "Juiza: Então por que tanta curiosidade Frank ? Não é algo que deixarei passar impune.";
		Texto[11]= "Frank: Eu só queria entender um pouco mais.";
		Texto[12]= "Juiza: Você não precisava querer entender nada. Não precisava se questionar de nada.";
		Texto[13]= "Juiza: Não precisava ao menos pensar. Você precisava apenas trabalhar.";
		Texto[14]= "Frank: Eu prometo que eu serei um otimo trabalhador agora, não irei me questionar mais sobre nada. ";
		Texto[15]= "Juiza: VOCÊ NÃO IRÁ MAIS SER NADA. PORQUE VOCE NÃO VOLTARÁ A SER NADA.";
		Texto[16]= "Juiza: Sua sentença está finalizada. Será executado daqui a 72 horas.";
		Texto[17]= "Frank: Mas você não me dará uma segunda chance, VOCE NÃO PODE SIMPLESMENTE EXECUTAR ALGUEM.";
		Texto[18]= "Juiza: E quem disse que eu irei executar alguem ? ";
		Texto[19]= "Juiza: Você vai apenas desaparecer como todos os outros.";
		Texto[20]= "Juiza: Podem tirá-lo daqui. SEGURANÇAS!";
		Texto[21]= "";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && tribunal<22)
		{
			this.Text = Texto[tribunal];
			tribunal++;
			Global.tribunal = tribunal;
		}
		
	}
}
