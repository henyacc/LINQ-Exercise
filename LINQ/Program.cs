namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Dogers",
                "Bluejays",
                "Mets",
                "Yankees"
            };
            
            var longerNames = names.Where(x => x.Length > 5);
                
            foreach (var name in longerNames) 
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

        }
        
        
    }
}
