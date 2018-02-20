using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxalRPG
{
    public class MonstreFacile
    {
        public string NomDuMonstre { get; set; }
        public int Value { get; set; }
        private int hp;
        public int HP { get { return hp; } }
        public bool Alive
        {
            get
            {
                if (HP <= 0)
                {
                    return false;
                }
                else
                    return true;

            }
        }

        public MonstreFacile()
        {
            Value = 1;
            hp = 10;
        }

        public virtual void Attaque(Joueur joueur)
        {
            int jetJoueur = De.De20();
            int jetMonstre = De.De20();
            if (jetJoueur < jetMonstre)
            {
                Console.WriteLine(NomDuMonstre + " tente une attaque");
                joueur.Defense(NomDuMonstre);
            }
            else
                Console.WriteLine(NomDuMonstre + " ne fait rien a ce tour");
        }

        public void SubitDegats(int degats)
        {
            hp = HP - degats;
        }

    }
}
