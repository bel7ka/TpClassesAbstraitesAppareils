namespace tp2_classe_abstrait;

public class Smartphone : Appareil
{
    private int nbCapteursPhoto;

    public Smartphone(string marque, string modele, DateTime dateFabrication, int nbCapteursPhoto) 
        : base(marque, modele, dateFabrication)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }

    public int GetNbCapteursPhoto() => nbCapteursPhoto;
    public void SetNbCapteursPhoto(int value) => nbCapteursPhoto = value;

    public override void AfficherInfos()
    {
        Console.WriteLine($"Smartphone - Marque: {GetMarque()}, Modèle: {GetModele()}, " +
                          $"Date: {GetDateFabrication().ToShortDateString()}, " +
                          $"Capteurs: {nbCapteursPhoto}, Ancienneté: {CalculerAnciennete()} ans");
    }

    public override float CalculerAnciennete()
    {
        return DateTime.Now.Year - GetDateFabrication().Year;
    }
}