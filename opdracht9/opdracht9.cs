namespace opdracht9
{
    internal class opdracht9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies drankmaat 1 (small), 2 (medium) of 3 (large):");
            int keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("2,00 euro");
                    break;
                case 2:
                    Console.WriteLine("2,50 euro");
                    break;
                case 3:
                    Console.WriteLine("3,00 euro");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
            Console.ReadLine();
        }
    }
}
