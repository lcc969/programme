<Query Kind="Statements" />

{
	private string _nom;
	private string _prenom;
	private int _Id;
	private DateOnly _dateEmbauche;
	
	public Employé(string Nom,string prenom, int Id, DateOnly dateEmbauche)
	{
		SetNom(Nom);
		SetPrénom(prenom);
		SetId(Id);
		SetdateEmbauche(dateEmbauche);
	}
	public string GetNom() => _nom;
	public string GetPrénom() => _prenom;
	
	public void SetNom(string Nom)
	{
		if (string.IsNullOrWhiteSpace(Nom)) 
			throw new ArgumentException();
		_nom = Nom;
	}
	public void SetPrénom(string prenom)
	{
		if (prenom == null)
			throw new ArgumentException();
		_prenom = prenom;
	}
	public void SetId(int Id)
	{
		if (Id <= 0)
			throw new ArgumentException();
		_Id = Id;
	}

	public void SetdateEmbauche(DateOnly dateEmbauche)
	{
		if (dateEmbauche == null)
			throw new ArgumentException();
		_dateEmbauche = dateEmbauche;
	}


}