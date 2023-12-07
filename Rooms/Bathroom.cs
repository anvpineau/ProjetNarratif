namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal static bool vapor;
        internal override string CreateDescription() =>
        @"Dans la toilette, le [bain] est rempli d'eau chaude.
        Le [miroir] devant toi affiche ton visage.
        Tu peux revenir dans ta [chambre].
        ";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu te laisses relaxer dans le bain. La vapeur monte.");
                    vapor = true;
                    break;
                case "miroir":
                    if (vapor == true)
                    {
                        Console.WriteLine("Tu aperçois les chiffres 2314 écrits sur la brume sur le miroir.");
                    }
                    else
                    {
                        Console.WriteLine("Ton reflet te regarde...");
                    }
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
