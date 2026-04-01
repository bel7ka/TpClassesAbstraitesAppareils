namespace tp2_classe_abstrait;
public class Ordinateur : Appareil
{
    private float TailleEcran;
    // Constructeur par défaut
    public Ordinateur() { }

    // Constructeur pour initialiser les propriétés de l'ordinateur
    public Ordinateur(string marque, string modele, DateTime dateFabrication, float tailleEcran) : base(marque, modele, dateFabrication)
    {
        this.TailleEcran = tailleEcran;
    }
    public float GetTailleEcran()
    {
        TailleEcran = TailleEcran;
        return TailleEcran;
    }
    public void SetTailleEcran(float tailleEcran)
    {
        this.TailleEcran = tailleEcran;
    }
    public override void AfficherType()
    {
        Console.WriteLine("Je suis un ordinateur");
    }
    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {GetMarque()}");
        Console.WriteLine($"Modèle: {GetModele()}");
        Console.WriteLine($"Date de Fabrication: {GetDateFabrication()}");
        Console.WriteLine($"Taille de l'écran: {GetTailleEcran()} pouces");
        Console.WriteLine($"Ancienneté: ");

    }
    public override float CalculerAnciennete()
    {
        TimeSpan anciennete = DateTime.Now - GetDateFabrication();
        int anneesAnciennete = (int)(anciennete.TotalDays / 365);
        Console.WriteLine($"{anneesAnciennete} ans");
        return anneesAnciennete;
    }
    public override string ToString()
    {
        return $"{GetMarque()}, {GetModele()}, Date de Fabrication: {GetDateFabrication()}, Taille de l'écran: {GetTailleEcran()} pouces, Ancienneté: {CalculerAnciennete()} ans";
    }
}