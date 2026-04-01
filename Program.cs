namespace tp2_classe_abstrait;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateo1 = new DateTime(2026, 3, 25);
        Appareil o1 = new Ordinateur ($"Marque : Lenovo", "Modèle : ThinkPad", dateo1, 15.6f);
        o1.Allumer();
        o1.AfficherType();
        o1.AfficherGarantie();
        o1.AfficherInfos();
        Console.WriteLine(o1.ToString());
        Smartphone s1 = new Smartphone("Apple", "iPhone 13", new DateTime(2021, 9, 1), 3);
        s1.Allumer();
        s1.AfficherType(); // héritée !
        s1.AfficherGarantie();
        s1.AfficherInfos();
    }
}
