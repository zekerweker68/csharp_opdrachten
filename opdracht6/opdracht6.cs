using System.Runtime.InteropServices.JavaScript;

namespace opdracht6
{
    internal class opdracht6
    {
        static void Main(string[] args)
        {
            string geboortejaar;

            Console.WriteLine("typ je geboortejaar in:"); geboortejaar = Console.ReadLine();

            int geboortejaarnummer = int.Parse(geboortejaar);

            int leeftijd = DateTime.Now.Year - geboortejaarnummer;

            Console.WriteLine("leeftijd = " + leeftijd);

            Console.ReadLine();
        }
    }
}
