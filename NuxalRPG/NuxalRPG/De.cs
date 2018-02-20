using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxalRPG
{
    public class De // Contient tout les jets de dés et les choix aléatoire dans les listes.
    {
        static private Random random = new Random();// si je ne l'instancie pas dans la classe, j'obtient toujours le meme nombre par la methode random ou 2 nombre different (cad si j'intancie random a chaque jet de de)
        static private int LanceLeDe()// uniquement pour respecté la consigne
        {
            return De6();
        }
        static public int Piece() // pile ou face ?
        {
            return random.Next(1, 3);
        }

        static public int De3() // jet d'un dé à 3 face
        {
            return random.Next(1, 3);
        }

        static public int De6() // jet d'un dé à 6 face
        {

            return random.Next(1, 7);
        }

        static public int De20() // jet d'un dé à 20 face
        {

            return random.Next(1, 21);

        }
    }
}