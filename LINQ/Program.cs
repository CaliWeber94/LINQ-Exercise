namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Videogames = new List<string>() { "Mario", "Zelda", "COD", "Halo", "The Sims", "Elder Scrolls", "World of Warcraft", "Candy Crush", "Fortnite", "Among Us" };
            var gamesByNameLength = Videogames.OrderBy(x => x.Length).ToList();
            foreach (var game in gamesByNameLength)
            {
                Console.WriteLine(game);
            }



        }
    }
}
