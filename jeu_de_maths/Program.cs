using System;

namespace jeu_de_maths
{
    class Program
    {
        static int VerifInt(string reponseString)
        {
            int stringAVerif = 0;
            bool correct = false;
            while (!correct)
            {
                try
                {
                    stringAVerif = int.Parse(reponseString);
                    correct = true;
                    break;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                    Console.Write("Quelle est votre réponse ?");
                    reponseString = Console.ReadLine();

                }
            }

            return stringAVerif;
        }
        static int PoserQuestion(int a, int b, int signe, int compteur )

        {
            string reponseUtilisateur = "";
            int reponseInt = 0;
            int resultat = 0;

 
            switch (signe)
            {
                case 1:
                    {
                        Console.WriteLine("C'est parti pour une addition !");
                        Console.Write("Quel est le résultat de : " + a + " + " + b + " ? ");
                        reponseUtilisateur = Console.ReadLine();
                        reponseInt = VerifInt(reponseUtilisateur);
                        resultat = a + b;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("C'est parti pour une soustraction !");
                        Console.Write("Quel est le résultat de : " + a + " - " + b + " ? ");
                        reponseUtilisateur = Console.ReadLine();
                        reponseInt = VerifInt(reponseUtilisateur);
                        resultat = a - b;
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("C'est partie pour une multiplication");
                        Console.Write("Quel est le résultat de : " + a + " x " + b + " ? ");
                        reponseUtilisateur = Console.ReadLine();
                        reponseInt = VerifInt(reponseUtilisateur);
                        resultat = a * b;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Vous ne devriez pas être ici !");
                        break;
                    }
            }
            if (reponseInt == resultat)
            {
                compteur++;
                Console.WriteLine("Bonne réponse !");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse");
            }
            return compteur;
           


        }

        static void Main(string[] args)
        {
            // Jeux de maths avec une séquence de 5 questions à la suite


            // 1 - Définir MIN et MAX
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;

            // 2 Nombres aléatoires pour a et b
            int a, b;
            int compteur = 0;
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                a = rnd.Next(NOMBRE_MIN, NOMBRE_MAX + 1);
                b = rnd.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

                Console.WriteLine("Valeur de A : " + a);
                Console.WriteLine("Valeur de B : " + b);

                // Déf opérateur :

                int operateurChiffre = rnd.Next(1, 4);
                //Console.WriteLine("Valeur de chiffre opération : " + operateurChiffre);


                compteur = PoserQuestion(a, b, operateurChiffre, compteur);
            }

            Console.WriteLine("Vous avez "+compteur+" bonnes réponses !" );

        }
    }
}
