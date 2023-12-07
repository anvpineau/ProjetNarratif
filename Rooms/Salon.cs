using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Salon : Room
    {
        internal static bool sac, first, faim;
        internal override string CreateDescription() =>
        "Tu est dans ton salon. Tu dois partir pour l'école. N'oublie pas ton sac!\n" +
        "Tu peux aller dans ta [cuisine], ton [bureau] ou ta [chambre]. Quand tu es prêt,\n" +
        "tu peux [sortir] dehors.";
        
        internal override void ReceiveChoice(string choice)
        {
            if (first == false) { first = true; }
            switch (choice)
            {
                case "cuisine":
                    Game.Transition<Cuisine>();
                    break;
                case "bureau":
                    Game.Transition<Bureau>();
                    break;
                case "placard":
                    break;
                case "chambre":
                    Console.WriteLine("Tu retourne dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                case "sortir":
                    if (sac == true && faim == true)
                    {
                        Console.WriteLine("Tu sors juste à temps pour prendre ton bus! Bonne journée!");
                        Game.Finish();
                    }
                    if (sac == false && faim == false)
                    {
                        Console.WriteLine("Tu dois te préparer avant de sortir...");
                    }
                    if (sac == false && faim == true)
                    {
                        Console.WriteLine("Tu as besoin de ton sac...");
                    }
                    if (faim == false && sac == true)
                    {
                        Console.WriteLine("Le petit déjeuner est le repas le plus important de la journée!");
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
