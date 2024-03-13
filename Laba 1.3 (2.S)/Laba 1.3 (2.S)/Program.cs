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


            var cennicDO = from x in tovary
                         where x.Key < 300
                         select x;
            var cennicBOLSHE = from c in tovary
                           where c.Key > 300
                           select c;
            Console.WriteLine("Цінники менше ніж:  ");
            foreach ( var v in cennicDO )
            {
                Console.WriteLine( v.Value + " - " + v.Key);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Цінники більше ніж:  ");
            foreach ( var c in cennicBOLSHE ) 
            {
                Console.WriteLine( c.Value +" - "+ c.Key);
            }
        }
    }
}