namespace Opdracht3
{
    internal class opdracht3
    {
        static void Main(string[] args)
        {
            string invoer = "42";// dit geeft variable invoer de waarde 42 in een string
            int getal = int.Parse(invoer); // dit veranderd de string variable invoer met de waarde 42 naar een int variable dus een nummer 
            int resultaat = getal * 2; // dit verdubbelt de int waarde 42 dus het wordt 84

            Console.WriteLine("Het dubbele is: " + resultaat);
            Console.ReadLine();
        }
    }
}
