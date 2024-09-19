namespace list_conway_david
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string> 
            { 
               "Cs:GO",
               "Halo 4",
               "ARK",
               "minecraft",
               "endenring"

            };

            string[] othergames = new string[]
            {
              "farcry primal",
              "Overwatch 2",
            };

            foreach(string game in games)
            { 
             Console.WriteLine(game);
            }


            Console.WriteLine($"Games in list: {games.Count}");

            games.AddRange(othergames);

            Console.WriteLine($"Games in list: {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("masterchief is in the house!");
            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6;

            if (myInt < games.Count) 
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("game not found");
            }

            Console.WriteLine("all games in list:");
            foreach(string game in games)
            { 
                Console.WriteLine(game); 
            }
            games.Sort();

            Console.WriteLine("sorted games list:");
            foreach(string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("new list:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}