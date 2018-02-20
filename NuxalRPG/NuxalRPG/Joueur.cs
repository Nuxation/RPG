using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxalRPG
{
    public class Joueur
    {
        public string NomDuJoueur { get; set; }
        public int Score { get; set; }
        private int hp;
        public int HP { get { if (hp >= 0) return hp; else return 0; } } //c'est cracra 
        public int Atk { get; set; }
        public bool Alive
        {
            get
            {
                if (HP <= 0)
                    return false;
                else
                    return true;

            }
        }
        public Joueur()
        {
            NomDuJoueur = "Link";
            Score = 0;
            hp = 80;
            Atk = 10;
        }
        public void Attaque(MonstreFacile monstre)
        {
            Console.Write(NomDuJoueur + " prépare son coup d'épée, s'avance vers l'ennemi et");
            int jetJoueur = De.De20();
            int jetMonstre = De.De20();
            if (jetJoueur >= jetMonstre)
            {
                TuerMonster(monstre);
                monstre.SubitDegats(Atk);
                Console.WriteLine(" porte une puissante taillade et tranche le " + monstre.NomDuMonstre);
            }
            else
                Console.WriteLine(" Frape dans le mur, c'est ballot!");

        }
        public void Defense (string NomDuMonstre)
        {
            if (De.De6() < 3)// Le joueur essaye de se proteger avec son bouclier
                Console.WriteLine(NomDuJoueur + " lève heroiquement sont bouclier et se protege completement des dégâts du " + NomDuMonstre);
            else
            {
                int degats = 10;// Les degats subit par le joueurs
                SubitDegats(degats);
                Console.WriteLine(NomDuMonstre + " reussie son attaque et inflige " + degats + " points de degat");
                Console.WriteLine("Il reste " + HP + " HP a " + NomDuJoueur);

            }

        }
        public void SubitDegats(int degats)
        {
            hp = HP - degats;
        }

        public void TuerMonster(MonstreFacile monstre)
        {

            this.Score = this.Score + monstre.Value;


        }


    }
}
