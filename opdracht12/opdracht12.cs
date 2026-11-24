namespace opdracht12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] naam = new string[5];
            naam[0] = "Mehmet";
            naam[1] = "Hakan";
            naam[2] = "Johnny";
            naam[3] = "Jeffrey";
            naam[4] = "Geert";

            Console.WriteLine(string.Join(", ", naam));
        }
    }
}
