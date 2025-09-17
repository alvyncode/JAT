using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        String choix;
        String texte;
        texte = File.ReadAllText(@"C:\Users\Elève\Documents\INFETProjet\JAT\Ressources\intro.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        texte = File.ReadAllText(@"C:\Users\Elève\Documents\INFETProjet\JAT\Ressources\1.txt");
        Console.WriteLine(texte);
    }
}
