using Godot;
using System;

public partial class RichTextLabel7 : RichTextLabel
{
	string[] Texto = new string [19];
	int tribunal = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Texto[0]= "Juiz: Nome, idade e piso a qual pertence.";
		Texto[1]= "Frank: Frank Cobain, Piso do escritório. Idade, ééééééé. Eu na verdade não me lembro.";
		Texto[2]= "Frank: Não costumo me questionar sobre essas coisas, na real não costumo me questionar sobre nada";
		Texto[3]= "Juiz: Certo. Não era algo que espereva que soubesse.";
		Texto[4]= "Juiz: Bom parece que você andou se metendo em lugares que não podia.";
		Texto[5]= "Juiz: Colocando seus olhos onde não deveria.";
		Texto[6]= "Frank: Eu juro que não vi nada demais.";
		Texto[7]= "Juiz: Ninguem nunca ve nada demais, afinal o que tem demais para se ver ?";
		Texto[8]= "Juiz: São apenas documentos sobre pessoas, não são Frank ? ";
		Texto[9]= "Frank: SIM, são apenas documentos senhor. Um amontuado de documentos sobre pessoas que não conheço. ";
		Texto[10]= "Juiz: Então por que tanta curiosidade Frank ? Não é algo que deixarei passar impune.";
		Texto[11]= "Frank: Eu só queria entender um pouco mais.";
		Texto[12]= "Juiz: Você não precisava querer entender nada. Não precisava se questionar de nada.";
		Texto[13]= "Juiz: Não precisava ao menos pensar. Você precisava apenas trabalhar.";
		Texto[14]= "Frank: Eu prometo que eu serei um otimo trabalhador agora, não irei me questionar mais sobre nada. ";
		Texto[15]= "Juiz: VOCÊ NÃO IRÁ MAIS SER NADA. PORQUE VOCE NÃO VOLTARÁ A SER NADA.";
		Texto[16]= "Juiz: Sua sentença está finalizada. Será executado daqui a 72 horas.";
		Texto[17]= "Frank: Mas você n me dará uma segunda chance, VOCE NÃO PODE SIMPLESMENTE EXECUTAR ALGUEM.";
		Texto[18]= "Juiz: E quem disse que eu irei executar alguem ? Você apenas desaparecer como todos os outros. Podem tirá-lo daqui. ";
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && tribunal<19)
		{
			tribunal++;
			Global.tribunal = tribunal;
		}
		this.Text = Texto[tribunal];
	}
}
