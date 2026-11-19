namespace opdracht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo toets = Console.ReadKey();
            Char getal = '5';
            
            Console.WriteLine();


            if (toets.KeyChar == getal)
            {
                Console.WriteLine("Correct! Mijn geluksgetal is 5!");
            }

            else
            {
                Console.WriteLine("Fout geraden!");
            }

            

        }
    }
}
