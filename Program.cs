namespace Generics1ReusoTypeSafetyPerformance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            Console.Write("How many values? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}