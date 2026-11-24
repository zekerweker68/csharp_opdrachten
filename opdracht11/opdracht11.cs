namespace opdracht11
{
    internal class opdracht11
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo toets;
            Char menu_1 = '1';
            Char menu_2 = '2';
            Char menu_3 = '3';

            do
            {
                Console.WriteLine();
                Console.WriteLine("Druk op 1 voor Menu 1, 2 voor Menu 2 of 3 om af te sluiten:");

                toets = Console.ReadKey();
                Console.WriteLine();


                if (toets.KeyChar == menu_1)
                {
                    Console.WriteLine("Menu 1");
                }

                else if (toets.KeyChar == menu_2)
                {
                    Console.WriteLine("Menu 2");
                }

                else if (toets.KeyChar == menu_3)
                {
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                }
            } while (toets.KeyChar != menu_3);
        }
    }
}
