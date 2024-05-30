using System;

namespace exoFonctionTabCorrect
{
//--------------1-----------------------------
    /*- Generer un tableau entier
    - ordonner
    - Pas tous consecutif

    - Problematique :
        - Creer un tableau d'entier
            - int tab[10];
        - Remplir le tableau avec des entiers aleatoires
            - Pas de doublon
            - Ordonner le tableau
            - Maniere de proceder :
                - choisi nombre aleatoire
                    Random aleatoire = new Random();
                    aleatoire.Next(MIN, MAX);
                - plus grand que le precedent
                    - Besoin d'une borne minimal
                        - nombre generer precedement + 1
                            - Garder en memoire le nombre precedement generer
                                - Regarder index - 1 (faire attention a l'index 0)
                                - Garder en memoire le nombre precedement generer dans un variable

                - pas trop d'ecart
                    - Besoin d'une borne maximal
                        - Borne minimal + 20
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
           
        // param : taille du tableau
        // return : tableau d'entier
        int[] GenererTableau(int taille)
        {
            int[] tab = new int[taille];
            Random aleatoire = new Random();

            int borne_min = 0;
            int borne_max = borne_min + 20;

            // Pour chaque element du tableau generer un nombre aleatoire compris entre les bornes
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = aleatoire.Next(borne_min, borne_max);
                borne_min = tab[i] + 1;
                borne_max = borne_min + 20;
            }
            return tab;
        }

        //--------------2-------------------
        //- Regarder au milieu du tableau
//    - Calculer l'index du milieu
//        - milieu = (borne minimal + borne maximal) / 2
//- Reduire la borne minimal et maximal
//    - si l'element est plus grand que le milieu
//        - Borne minimal = milieu

//    - si l'element est plus petit que le milieu
//        - Borne maximal = milieu

//- On ne le trouve pas si les deux bornes sont egales et que l'element n'est pas sur cette borne
//if (borne minimal == borne maximal && tab[borne minimal] != element)
//    return -1;

// param : tableau d'entier int[], entier a chercher int
// return : index de l'element dans le tableau int ou -1 si l'element n'est pas dans le tableau
        int RechercheDichotomique(int[] tab, int element)
        {
            int borne_min = 0;
            int borne_max = tab.Length - 1;

            while (borne_min <= borne_max)
            {
                int milieu = (borne_min + borne_max) / 2;

                if (tab[milieu] == element)
                {
                    return milieu;
                }
                else if (tab[milieu] < element)
                {
                    borne_min = milieu + 1;
                }
                else if (tab[milieu] > element)
                {
                    borne_max = milieu - 1;
                }
            }
            return -1;
        }

        int[] tab = GenererTableau(20);

             int a_chercher = 102332453;

             int index = RechercheDichotomique(tab, a_chercher);

                System.Console.WriteLine("Element a chercher : " + a_chercher);
                System.Console.WriteLine("Index de l'element : " + index);

     }
}
