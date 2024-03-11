using System.Text;


namespace DictionaryTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, string> tovary = new Dictionary<int, string>()
            {
                { 250, "Milk" },
                { 350, "Chokolate" },
                { 299, "Coffee" },
                { 100, "water" },
                { 50, "Mivina" }
            };


            var cennicDO = from x in tovary.Keys
                         where x < 300
                         select x;
            var cennicBOLSHE = from c in tovary.Keys
                           where c > 300
                           select c;
            foreach ( var v in cennicDO )
            {
                Console.WriteLine("Цінники менше ніж:  " + v );
            }
            Console.WriteLine("\n");
            foreach ( var c in cennicBOLSHE ) 
            {
                Console.WriteLine("Цінники більше ніж:  " + c );
            }
        }
    }
}