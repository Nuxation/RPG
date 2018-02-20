using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxalRPG
{
    public class MonstreDifficile : MonstreFacile
    {
        public string SpellName { get; set; }
        public MonstreDifficile()
        {
            SpellName = "une grosse boule de feu";
            Value = 2;
        }
        public override void Attaque(Joueur Link)
        {
            int jetJoueur = De.De20();
            int jetMonstre = De.De20();
            if (jetJoueur < jetMonstre)
            {
                Console.WriteLine("Le " + NomDuMonstre + " tente une attaque");
                Link.Defense(NomDuMonstre);
                Console.WriteLine("Le " + NomDuMonstre + " tente egalement une attaque magique");
                spell(Link);
            }
            else
                Console.WriteLine(NomDuMonstre + " ne fait rien a ce tour");
        }
        protected void spell(Joueur link)
        {
            int incantation = De.De6();
            int puissance = 5;
            if (incantation != 6)
            {
                int dmg = incantation * puissance;
                link.SubitDegats((dmg));
                Console.WriteLine(NomDuMonstre + " lance " + SpellName + " qui inflige " + dmg + " degat !");
                Console.WriteLine("Il reste " + link.HP + " HP a " + link.NomDuJoueur);
            }
        }
    }
}






