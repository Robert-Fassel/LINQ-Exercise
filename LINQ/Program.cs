using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Goldeneye", "Zelda", "Super Mario Brothers", "Skyrim"
            };
            IEnumerable<string> gamesByLength =
                videoGames.OrderBy(game => game.Length);

            foreach(var item in gamesByLength)
            {
                Console.WriteLine(item);
            }
        }
    }
}
