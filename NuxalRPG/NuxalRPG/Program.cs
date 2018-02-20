using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxalRPG
{
    class Program
    {
        static void Main(string[] args)
        {

             Joueur link = new Joueur { };
             int easy = 0;
             int hard = 0;
             Console.WriteLine("Vous etes un jeune hero du nom de " + link.NomDuJoueur); ;
             Console.WriteLine(link.NomDuJoueur + " entre dans le donjon et marche vers la premiere piece. (appuyer sur la touche entré pour faire continuer les action de " + link.NomDuJoueur + ", ici avancer dans le donjon)");
             Console.ReadKey();

             while (link.Alive)
             {
                 if (De.Piece() == 1)
                 {
                     MonstreDifficile monstre = new MonstreDifficile() { NomDuMonstre = "sorcier" };

                     Console.WriteLine("Et y rencontre un " + monstre.NomDuMonstre);

                     while (monstre.Alive && link.Alive)
                     {
                         Console.WriteLine("|-----------------------------|");
                         link.Attaque(monstre);
                         if (monstre.Alive)
                             monstre.Attaque(link);
                         else
                             Console.WriteLine("Le " + monstre.NomDuMonstre + " tombe mort sur le sol");

                         Console.ReadKey();
                     }
                     if (link.Alive)
                         hard++;
                 }
                 else
                 {
                     MonstreFacile monstre = new MonstreFacile() { NomDuMonstre = "gobelin" };

                     Console.WriteLine("Et y rencontre un " + monstre.NomDuMonstre);

                     while (monstre.Alive && link.Alive)
                     {
                         Console.WriteLine("|-----------------------------|");
                         link.Attaque(monstre);
                         if (monstre.Alive)
                             monstre.Attaque(link);
                         else
                             Console.WriteLine("Le " + monstre.NomDuMonstre + " tombe mort sur le sol");
                         Console.ReadKey();
                     }
                     if (link.Alive)
                         easy++;
                 }
                 Console.WriteLine();

                 if (link.Alive)
                 {
                     Console.WriteLine("|-----------------------------|");
                     //creation du future chemin du hero
                     int rngDirection = De.De3();
                     string nomDirection;
                     if (rngDirection == 1)
                         nomDirection = "de gauche";
                     else if (rngDirection == 2)
                         nomDirection = "de droite";
                     else
                         nomDirection = "d'en face";

                     Console.WriteLine(link.NomDuJoueur + " continue vers la piece " + nomDirection+ ".");
                     Console.ReadKey();
                 }

             }
             //texte de fin de partie
             Console.WriteLine("|-----------------------------|");
             Console.WriteLine("Le score de " + link.NomDuJoueur + " = " + link.Score);
             Console.WriteLine("Vous avez tuer " + easy + " monstre et " + hard + " Boss");
             Console.ReadKey();
        }
    }
}
