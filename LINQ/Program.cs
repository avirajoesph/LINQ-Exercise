namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            List<string> stringList = new List<string>();
            stringList.Add("GTA5");
            stringList.Add("Uncharted 4");
            stringList.Add("Fortnite");
            stringList.Add("Call Of Duty");

            stringList.OrderBy(s => s.Length).ToList().ForEach(x =>Console.WriteLine(x) );
            
            
                
            
        }

    }
}
