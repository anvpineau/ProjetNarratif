using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Bureau : Room
    {
        internal override string CreateDescription() =>
        "Dans le bureau, un grand [cabinet] en vitre est remplie de livre.\n" +
        "Tu peux retourner dans le [salon]";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cabinet":
                    if (Bedroom.sacVide == true && Salon.sac == false)
                    {
                        Console.WriteLine("Tu mets tes livres d'école dans ton sac...");
                        Salon.sac = true;
                    }
                    if (Bedroom.sacVide == false) 
                    {
                        Console.WriteLine("Il te faut quelque chose pour transporter tes livres...");
                    }
                    if (Bedroom.sacVide == true && Salon.sac == true)
                    {
                        Console.WriteLine("Tu n'as plus besoin de rien ici...");
                    }
                    break;
                case "salon":
                    Console.WriteLine("Tu retourne dans le salon...");
                    Game.Transition<Salon>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
