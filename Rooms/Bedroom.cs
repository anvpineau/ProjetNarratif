﻿namespace ProjetNarratif.Rooms
{
    internal class Bedroom : Room
    {
        internal static bool sacVide;
        internal override string CreateDescription() =>
        @"Tu es dans ta chambre à dormir.
        La [porte] qui mène au salon est devant toi.
        Ta [toilette] privée est à ta gauche.
        Dans ton armoire, tu aperçois le [grenier]
        Ton [sac] est sur ton lit.";

        internal override void  ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "toilette":
                    Console.WriteLine("Tu entres dans la toilette.");
                    Game.Transition<Bathroom>();
                    break;
                case "porte":
                    if (!AtticRoom.isKeyCollected)
                    {
                        Console.WriteLine("La porte est verrouillée.");
                    }
                    else
                    {
                        Console.WriteLine("Tu ouvres la porte avec ta clé et tu sors de ta chambre.");
                        Game.Transition<Salon>();
                    }
                    break;
                case "grenier":
                    Console.WriteLine("Tu montes dans le grenier.");
                    Game.Transition<AtticRoom>();
                    break;
                case "sac":
                    Console.WriteLine("Tu prends ton sac. Il est vide...");
                    sacVide = true;
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
