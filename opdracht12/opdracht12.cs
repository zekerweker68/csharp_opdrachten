namespace opdracht12
{
    internal class Program
    {
        static void Main(string[] args)
        {
          char a;
            do
            {
                Console.WriteLine("Which one would you like to buy? A B C or D");
                a = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (!"ABCD".Contains(a));

        }
    }
}
