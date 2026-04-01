namespace tp2_classe_abstrait;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 2
        DateTime dateo1 = new DateTime(2026, 3, 25);
        Appareil o1 = new Ordinateur ($"Marque : Lenovo", "Modèle : ThinkPad", dateo1, 15.6f);
        o1.Allumer();
        o1.AfficherType();
        o1.AfficherGarantie();
        o1.AfficherInfos();
        Console.WriteLine(o1.ToString());
        //Exercice 3
        Smartphone s1 = new Smartphone("Apple", "iPhone 13", new DateTime(2021, 9, 1), 3);
        s1.Allumer();
        s1.AfficherType(); // héritée !
        s1.AfficherGarantie();
        s1.AfficherInfos();
        // Exercice 4
        // Exercice 4
        // Ordinateurs
        // Exercice 4

        // Ordinateurs
        Ordinateur o2 = new Ordinateur("HP", "Pavilion", new DateTime(2018, 5, 10), 14);
        Ordinateur o3 = new Ordinateur("Dell", "XPS", new DateTime(2020, 11, 20), 13.3f);

        // Smartphones
        Smartphone s2 = new Smartphone("Samsung", "Galaxy S20", new DateTime(2020, 3, 15), 4);
        Smartphone s3 = new Smartphone("Xiaomi", "Mi 11", new DateTime(2021, 2, 8), 3);

        // Test ancienneté
        Console.WriteLine("Ancienneté o2 :");
        o2.CalculerAnciennete();

        Console.WriteLine("Ancienneté o3 :");
        o3.CalculerAnciennete();

        Console.WriteLine("Ancienneté s2 :");
        s2.CalculerAnciennete();

        Console.WriteLine("Ancienneté s3 :");
        s3.CalculerAnciennete();
        // Exercice 5
        // Exercice 5

        List<Appareil> appareils = new List<Appareil>();

        appareils.Add(o1);
        appareils.Add(o2);
        appareils.Add(o3);
        appareils.Add(s1);
        appareils.Add(s2);
        appareils.Add(s3);

        foreach (Appareil app in appareils)
        {
            Console.WriteLine("------------");
            app.Allumer();
            app.AfficherType();
            app.AfficherGarantie();
            app.AfficherInfos();
        }
    }
}
