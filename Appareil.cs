abstract class Appareil
{
    private string Marque;
    private string Modele;
    private DateTime DateFabrication;
   
    // Constructeur par défaut
    public Appareil() { }
    // Constructeur pour initialiser les propriétés de l'appareil
    public Appareil(string marque, string modele, DateTime dateFabrication)
    {
        this.Marque = marque;
        this.Modele = modele;
        this.DateFabrication = dateFabrication;
    }
    public string GetMarque()
    {
        Marque = Marque;
        return Marque;
    }
    public void SetMarque(string marque)
    {
        this.Marque = marque;
    }
    public string GetModele()
    {
        Modele = Modele;
        return Modele;
    }
    public void SetModele(string modele)
    {
        this.Modele = modele;
    }
    public DateTime GetDateTime ()
    {
        DateFabrication = DateFabrication;
        return DateFabrication;
    }
    public void SetDateFabrication(DateTime dateFabrication)
    {
        this.DateFabrication = dateFabrication;
    }
 
    // Méthode classique pour allumer l'appareil
    public void Allumer()
    {
        Console.WriteLine("L'appareil est allumé.");
    }
    // Méthode virtuelle pour afficher le type de l'appareil, peut être redéfinie par les classes filles
    public virtual void AfficherType()
    {
        Console.WriteLine("Je suis un appareil.");
    }
    // Méthode virtuelle pour afficher la garantie, peut être redéfinie par les classes filles
    public virtual void AfficherGarantie()
    {
        Console.WriteLine("Garantie standard de l'appareil.");
    }
    // Méthode abstraite pour afficher les informations de l'appareil, doit être Instancié par les classes filles
    public abstract void AfficherInfos();
    // Méthode abstraite pour calculer l'ancienneté de l'appareil, doit être Instancié par les classes filles
    public abstract void CalculerAnciennete();

 
}