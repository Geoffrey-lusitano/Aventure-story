using System;

namespace MonPremierProjetCsharp
{
    class Program
    {
        // un com
        static void Main(string[] args)
        {
            ShowTitle();
            ShowRules();

            Console.WriteLine("Link se réveille dans une fôret obscure, deux choix s'offre a lui, prendre le chemin de droite ou de gauche ?");
            string dir = Console.ReadLine();

            ChoiceOne(dir);
            dir = Console.ReadLine();

            ChoiceTwo(dir);
            dir = Console.ReadLine();

            ChoiceThree(dir);



        }

        static void ShowTitle()
        {
            Console.WriteLine("AVENTURE STORY");
        }

        static void ShowRules()
        {
            Console.WriteLine("Faire le bon choix pour faire avancer son personnage");
        }

        static void ChoiceOne(string dir)
        {
            while (dir != "droite" || dir != "gauche")
            {
                if (dir == "droite")
                {
                    Console.WriteLine("Link prend le chemin de droite, il decouvre un bosquet avec un dragon en plein milieu. Celui ci se réveille et carbonise Link. END !");
                    Environment.Exit(0);
                }
                else if (dir == "gauche")
                {
                    Console.WriteLine("Link prend le chemin de gauche, il decouvre une stele avec une épee. Souhaitez vous prendre ou laisser l'épee ?");
                    break;
                }
                else
                {
                    Console.WriteLine("Direction non disponible");
                    dir = Console.ReadLine();
                }
            }
        }

        static void ChoiceTwo(string dir)
        {
            while (dir != "prendre" || dir != "laisser")
            {
                if (dir == "laisser")
                {
                    Console.WriteLine("Link laisse l'épee, puis rencontre un orc. N'ayant aucun moyen de se defendre, Link meurt. END !");
                    Environment.Exit(0);
                }
                else if (dir == "prendre")
                {
                    Console.WriteLine("Link prend l'épee, puis rencontre un orc. Il se sert de l'épee magique pour terraser l'orc. Apres avoir marcher un long moment, Link rencontre une fée enprisonner dans une toile d'araigner, Link doit la sauver ou la laisser ?");
                    break;
                }
                else
                {
                    Console.WriteLine("Direction non disponible");
                    dir = Console.ReadLine();
                }
            }
        }

        static void ChoiceThree(string dir)
        {
            while (dir != "laisser" || dir != "sauver")
            {
                if (dir == "laisser")
                {
                    Console.WriteLine("Link laisse la fée, puis retombe sur le dragon qui est en pleine chase. N'ayant qu'une épee pour se défendre, Link meurt. END !");
                    Environment.Exit(0);
                }
                else if (dir == "sauver")
                {
                    Console.WriteLine("Link sauve la fée, puis retombe sur le dragon qui est en pleine chase. La fée etant une amis du dragon, Link reste en vie et sort enfin de cette forêt. FIN de l'acte 1");
                    break;
                }
                else
                {
                    Console.WriteLine("Direction non disponible");
                    dir = Console.ReadLine();
                }
            }
        }
    }
}
