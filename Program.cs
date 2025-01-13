namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"tong 2 so la: {sum(4, 5)}");
            Console.WriteLine($"hieu 2 so la: {tru(4, 5)}");
        }

        static int sum(int a, int b) => a + b;
        static int tru(int a, int b) => a - b;

    }
}