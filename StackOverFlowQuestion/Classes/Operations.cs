using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StackOverFlowQuestion.Classes
{
    public class Operations
    {
        /// <summary>
        /// In a real app this is read in from a file
        /// </summary>
        public static List<Item> MockedItems => new List<Item>()
        {
            new Item() { Symbol = "asd", Size = 25, Direction = "UP", Action = "Add to watch" },
            new Item() { Symbol = "dsa", Size = 35, Direction = "UP", Action = "Add to watch" },
            new Item() { Symbol = "tewer", Size = 35, Direction = "UP", Action = "Add to watch" },
            new Item() { Symbol = "few", Size = 35, Direction = "UP", Action = "Add to watch" },
            new Item() { Symbol = "qwe", Size = 35, Direction = "UP", Action = "Add to watch" }

        };

        public static void Export(List<Item> sender, string fileName)
        {
            var lines = sender.Select(x => x.Row).ToArray();
            File.WriteAllLines(fileName, lines);

        }
    }
}