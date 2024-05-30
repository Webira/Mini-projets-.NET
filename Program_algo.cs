using System;

// Choisir un nombre magique

// Creer un generateur de nombre aleatoire
Random randomGenerator = new Random();

// Generer un nombre aleatoire entre 1 et 100
int magicNumber = randomGenerator.Next(1, 101);

int number = 0;

// Repeter la question jusqu'à ce que l'utilisateur trouve le nombre magique
do
{
    // demander a l'utilisateur de choisir un nombre entre 1 et 100
    Console.WriteLine("Choisissez un nombre entre 1 et 100");
    string input = Console.ReadLine();

    // convertir la chaine de caractère en nombre
    if (int.TryParse(input, out number) == false)
    {
        Console.WriteLine("Veuillez entrer un nombre valide au format numérique.");
        continue;
    }

    // si le nombre est plus petit que le nombre magique, afficher "plus grand"
    if (number < magicNumber)
    {
        Console.WriteLine("plus grand");
    }
    // si le nombre est plus grand que le nombre magique, afficher "plus petit"
    else if (number > magicNumber)
    {
        Console.WriteLine("plus petit");
    }
    // si le nombre est égal au nombre magique, afficher "Bravo, vous avez trouvé le nombre magique"
    else if (number == magicNumber)
    {
        Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
    }
} while (number != magicNumber);
