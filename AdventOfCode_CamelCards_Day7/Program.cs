using System.Reflection;

namespace AdventOfCode_CamelCards_Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay7.txt");

            var strengthOfCards = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
            var data = FileManager.ReadData(FILE_PATH);

          var sorted = Calculator.RateCards(data, strengthOfCards);


            long sum = 0;
            

            Console.WriteLine($"Sum is: {sum}");

        }
    }
}