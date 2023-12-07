using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Bedroom());
game.Add(new Bathroom());
game.Add(new AtticRoom());
game.Add(new Salon());
game.Add(new Cuisine());
game.Add(new Bureau());

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();