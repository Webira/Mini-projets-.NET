/*using System;

namespace fonctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}*/

using System;
using System.Linq;

namespace fonction
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int borne_min = 0;
        int borne_max = 100;
        string input = "";
        int nbproposer = -1;
        }

        void AfficherRegle()
            {
                System.Console.WriteLine("Pensez a un nombre entre 0 et 100");
                System.Console.WriteLine("Repondez : P (plus grand) M (plus petit) E (egal)");
            }

            bool CheckInput(string input, string expected)
            {
                return input == expected;
            }

            bool isPlusGrand(string input)
            {
                return CheckInput(input, "P");
            }

            bool isPlusPetit(string input)
            {
                return CheckInput(input, "M");
            }

            bool isEgal(string input)
            {
                return CheckInput(input, "E");
            }

            bool isNotEgal(string input)
            {
                return !isEgal(input);
            }

            int calculerNbProposer(int borne_min, int borne_max)
            {
                return (borne_min + borne_max) / 2;
            }

            void proposerNombre(int nbproposer)
            {
                Console.WriteLine("Est-ce que votre nombre est " + nbproposer + " ? (P/M/E)");
            }

            bool isValidInput(string input)
            {
                string[] validInputs = new string[] { "P", "M", "E" };
                return validInputs.Contains(input);
            }

            string GetInput()
            {
                string input = "";
                while (!isValidInput(input))
                {
                    input = Console.ReadLine();
                }
                return input;
            }

            void UpdateBorne(ref int borne, int nbproposer)
            {
                borne = nbproposer;
            }

            void UpdateBornes(string input, int nbproposer, ref int borne_min, ref int borne_max)
            {
                // Si nbproposer est inf au nbmagic
                // Changer Bmin
                if (isPlusGrand(input))
                {
                    UpdateBorne(ref borne_min, nbproposer);
                }

                //Si nbproposer est sup au nbmagic
                // Changer Bmax
                if (isPlusPetit(input))
                {
                    UpdateBorne(ref borne_max, nbproposer);
                }
            }

            void GameLoop(int borne_min, int borne_max)
            {
                string input = "";
                int nbproposer = -1;

                // Tant que l'input n'est pas "E"
                while (isNotEgal(input))
                {
                    // Determiner le nbproposer
                    nbproposer = calculerNbProposer(borne_min, borne_max);

                    // Demander a l'utilisateur P (plus) M (moins) ou E (egal)
                    proposerNombre(nbproposer);

                    // feature

                    input = GetInput();

                    UpdateBornes(input, nbproposer, ref borne_min, ref borne_max);
                }
            }
     }
}

