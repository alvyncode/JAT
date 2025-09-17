using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        String choix;
        String texte;
        texte = File.ReadAllText(@"C:\Users\Elève\Documents\INFETProjet\JAT\Ressources\intro.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"C:\Users\Elève\Documents\INFETProjet\JAT\Ressources\1.txt");
        Console.WriteLine(texte);
        Console.WriteLine("Choisis un pseudo pour ton combattant:");
        string pseudo = Console.ReadLine();
        Console.WriteLine("OK " + pseudo + ", quel est ton style de combat ?");
        Console.WriteLine("1. Archer (Mauvais en combat rapproché mais bon à distance)");

        Console.WriteLine("2. Guerrier (Bon en combat rapproché mais mauvais à distance)");

        Console.WriteLine("3. Mage (Moyen en combat rapproché et à distance mais avec des sorts)");
        
        choix = Console.ReadLine();
        if (choix == "1")
        {
            Console.WriteLine("Tu as choisi l'archer !");
        }
        else if (choix == "2")
        {
            Console.WriteLine("Tu as choisi le guerrier !");
        }
        else if (choix == "3")
        {
            Console.WriteLine("Tu as choisi le mage !");
        }
        else
        {
            Console.WriteLine("Choix invalide, choisis entre 1, 2 et 3.");
        

        
        }
    }
}
