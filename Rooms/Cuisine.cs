using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Cuisine : Room
    {
        internal override string CreateDescription() =>
            "La cuisine est blanche et étincellante. Le [frigo] fait un ronflement presque\n" +
            "imperceptible... Tu peux retourner dans le [salon].";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "frigo":
                    if (Salon.faim == false)
                    {
                        Console.WriteLine("Tu te prépare de quoi manger. Miam!");
                        Salon.faim = true;
                    }
                    if (Salon.faim == true)
                    {
                        Console.WriteLine("Tu es complètement repu!");
                    }
                    break;
                case "salon":
                    Console.WriteLine("Tu retourne dans le salon...");
                    Game.Transition<Salon>();
                    break;
            }
        }
    }
}

