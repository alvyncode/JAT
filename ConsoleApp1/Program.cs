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
        String texte;
        texte = File.ReadAllText(@"../../../../Ressources\Ecran_d_acceuil\intro.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"../../../../Ressources\Ecran_d_acceuil\1.txt");
        Console.WriteLine(texte);
        
    }
    public static void chapitre1()
    {
        String texte;

        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\INTROp1.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\INTROp2.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\INTROp3.txt");
        Console.WriteLine(texte);
        Console.ReadLine();

        Console.WriteLine("Choisis un pseudo pour ton combattant:");
        string pseudo = Console.ReadLine();
        Console.WriteLine("OK " + pseudo + ", Tu commencera ton avanture avec la factions des Archers");
        Console.ReadLine();
        Console.WriteLine("Caractéristiques: Les Archers sont Mauvais en combat rapproché mais bon à distance");
        Console.ReadLine();

        String choix;

        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\intro1er combat1.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"../../../../Ressources\Chapter1\intro1er combat2.txt");
        Console.WriteLine(texte);
        Console.ReadLine();

        choix = Console.ReadLine();

        if (choix == "1")
        {
            Console.WriteLine("Pour compenser un vent latéral constant, il suffit d'augmenter toujours la puissance de tir . vrai ou faux");
            
        }
        else if (choix == "2")
        {
            Console.WriteLine("vrai ou faux : Sur un arc à poulies, un nock point mal réglé n'affecte pas la précision");
        }
        else if (choix == "3")
        {
            Console.WriteLine("vrai ou faux : Le tir en cloche (parabole) est utile pour atteindre une cible cachée derrière un obstacle.");
        }
        else
        {
            Console.WriteLine("Retourne au combat. La desertion n'est pas un choix");
        }


    }
}
