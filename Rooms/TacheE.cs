using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class TacheE : Room
    {
        int life = 0;
        internal override string CreateDescription() =>
        "La porte se referme derrière toi et tu te retrouve dans une pièce sombre et froide. Une étrange silhouette apparaît\n" +
        "et grogne d'une voix rauque: «Ton quatrième souffle sera ton dernier... Je vous vois vieillir sans jamais rien vous\n" +
        "dire. Qui suis-je?» Un silence inquiétant règne dans la pièce. La créature te regarde de façon menaçante. Mieux vaut\n" +
        "dire quelque chose...";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "Miroir":
                    
                    Console.WriteLine("L'être caché dans la pénombre lâche un long sifflement indigné. Lentement, il se font dans\n" +
                        "la noirceur et disparaît.Avec un grincement strident, la porte s'ouvre lentement, laissant entrer un fin\n" +
                        "rayon de lumière dans la pièce. Le coeur battant, tu te précipites dans l'autre pièce et claque la porte\n" +
                        "derrière toi.");
                    life = 0;
                    Game.Transition<Bedroom>();
                    break;
                case "miroir":
                    
                    Console.WriteLine("L'être caché dans la pénombre lâche un long sifflement indigné. Lentement, il se font dans\n" +
                        "la noirceur et disparaît.Avec un grincement strident, la porte s'ouvre lentement, laissant entrer un fin\n" +
                        "rayon de lumière dans la pièce. Le coeur battant, tu te précipites dans l'autre pièce et claque la porte\n" +
                        "derrière toi.");
                    life = 0;
                    Game.Transition<Bedroom>();
                    break;
                case "Un miroir":
                    
                    Console.WriteLine("L'être caché dans la pénombre lâche un long sifflement indigné. Lentement, il se font dans\n" +
                        "la noirceur et disparaît.Avec un grincement strident, la porte s'ouvre lentement, laissant entrer un fin\n" +
                        "rayon de lumière dans la pièce. Le coeur battant, tu te précipites dans l'autre pièce et claque la porte\n" +
                        "derrière toi.");
                    life = 0;
                    Game.Transition<Bedroom>();
                    break;
                case "un miroir":
                    Console.WriteLine("L'être caché dans la pénombre lâche un long sifflement indigné. Lentement, il se font dans\n" +
                        "la noirceur et disparaît.Avec un grincement strident, la porte s'ouvre lentement, laissant entrer un fin\n" +
                        "rayon de lumière dans la pièce. Le coeur battant, tu te précipites dans l'autre pièce et claque la porte\n" +
                        "derrière toi.");
                    life = 0;
                    Game.Transition<Bedroom>();
                    break;  
                default:
                    if (life == 0)
                    {
                        Console.WriteLine("Un...Je ne suis d'aucunes et de toutes les couleurs.....");
                        life = 1;
                        break;
                    }
                    if (life == 1)
                    {
                        Console.WriteLine("Deux......Je te ressemble parfois et d'autres pas.....");
                        life = 2;
                        break;
                    }
                    if (life == 2)
                    {
                        Console.WriteLine("Trois..............Je réfléchis sans penser...");
                        life = 3;
                        break;
                    }
                    if(life == 3)
                    {
                        Console.WriteLine("Quatre...................................Ehehehehehehe.......");
                        Game.Finish();
                    }
                    break;
            }
        }
    }
}
