using System.Text;
using System.Text.Json;

namespace DictionaryTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                { 1, "Sonthing" },
                { 2, "Chto-to" },
                { 3, "Labyda" },
                { 4, "Bababyi" },
                { 5, "Ihihih" }
            };
            foreach (var i in dict)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            var maxKey = dict.Keys.Max();
            var maxValue = dict[maxKey];
            dict.Remove(maxKey);

            var minKey = dict.Keys.Min();
            dict[minKey] = maxValue;

            string s = JsonSerializer.Serialize(dict);
            Console.WriteLine(s);
        }
    }
}