namespace opdracht5
{
    internal class opdracht5
    {
        static void Main(string[] args)
        {
            string breedte;
            string hoogte;

            Console.WriteLine("breedte = "); breedte = Console.ReadLine();
            Console.WriteLine("hoogte = "); hoogte = Console.ReadLine();

            double breedtenummer = double.Parse(breedte);
            double hoogtenummer = double.Parse(hoogte);

            double oppervlakte = hoogtenummer * breedtenummer;

            Console.WriteLine("de oppervlakte is" + string.Format("{0:F2}", oppervlakte));

            Console.ReadLine();
        }
    }
}
