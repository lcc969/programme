<Query Kind="Statements" />

new Arme[]{
	new("hache", 7), new(),
	new(9), new(10),
	new("masse"), new("dague"),
}.Dump("Nzotem alex");
class Arme
{
	public string Nom;
	public int Dommage;

	public Arme(string Nom, int Dommage)
	{
		this.Nom = Nom;
		this.Dommage = Dommage;
	}
	public Arme()
	{
		this.Nom = Nom;
		this.Dommage = Dommage;
	}
	public Arme(string Nom)
	{
		this.Nom = Nom;
		this.Dommage = Dommage;
	}
	public Arme( int Dommage)
	:this(Nom,8){}


}