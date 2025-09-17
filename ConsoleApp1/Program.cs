using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        ecran_d_acceuil();
        chapitre1();
    }
   public static void ecran_d_acceuil() {
        Console.Clear();
        String choix;
        String texte;
        texte = File.ReadAllText(@"../../../../Ressources\Ecran_d_acceuil\intro.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"../../../../Ressources\Ecran_d_acceuil\1.txt");
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
            Console.WriteLine(texte);
            texte = File.ReadAllText(@"../../../../Ressources\Ecran_d_acceuil\archer.txt");
            Console.WriteLine("Tu as choisi l'archer ! " + texte);

        }
        else if (choix == "2")
        {
            Console.WriteLine("Tu as choisi le guerrier !");
        }
        else if (choix == "3")
        {
            Console.WriteLine(texte);
            texte = File.ReadAllText(@"../../../../Ressources\Ecran_d_acceuil\mage.txt");
            Console.WriteLine("Tu as choisi le mage !"+texte);
        }
        else
        {
            Console.WriteLine("Choix invalide, choisis entre 1, 2 et 3.");



        }
    }
    public static void chapitre1()
    {
        String texte;
        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\INTROp1.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\INTROp2.txt" );
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\INTROp3.txt" );
        Console.WriteLine(texte);
        Console.ReadLine();
    }
}
