namespace opdracht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo toets = Console.ReadKey();
            string getal = toets.KeyChar.ToString();

            // converteer string getal naar een integer 
            // dan maak je if (waar je geconverteerde string vergelijkt met getal 5)
            // dan doe je een writeline met 
            //• Bij invoer 5: "Correct! Mijn geluksgetal is 5!"
            //• Bij een ander cijfer: "<invoer> is niet juist."
            //• Bij iets anders dan een cijfer: "<invoer> is niet juist. Voer een cijfer in."


            Console.WriteLine();
            int nummer = int.Parse(toets.KeyChar.ToString());

            if (nummer == 5)
            {
                Console.WriteLine("je hebt het geraden, nummer 5");
            }

            else
            {
                Console.WriteLine("fout geraden");
            }
            Console.ReadLine();

        }
    }
}
