namespace opdracht8
{
    internal class opdracht8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("raad het gelukswoord");

            string luckywoord = "LUCKY";
            string invoer = Console.ReadLine()?.ToUpper();


            if (invoer == luckywoord)
            {
                Console.WriteLine("Je typte LUCKY en dat is... Correct!");
            }
            else
            {
                Console.WriteLine(" Je typte " + invoer + " en dat is... Fout! ");
            }

            Console.ReadLine();

        }
    }
}
