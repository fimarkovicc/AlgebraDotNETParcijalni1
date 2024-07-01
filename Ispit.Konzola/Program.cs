using Ispit.Model;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> ucenici = new List<Ucenik>();

            while (true)
            {
                Ucenik ucenik = new Ucenik();

                Console.WriteLine("Enter ucenik name");
                ucenik.Ime = Console.ReadLine();

                Console.WriteLine("Enter ucenik prezime");
                ucenik.Prezime = Console.ReadLine();

                Console.WriteLine("Enter ucenik datum rodjenja");
                ucenik.DatumRodjenja = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter ucenik prosjek");
                ucenik.Prosjek = Double.Parse(Console.ReadLine());

                ucenici.Add(ucenik);

                Console.WriteLine("Insert new? (yes/no)");
                if(Console.ReadLine() != "yes")
                {
                    break;
                }
            }

            foreach (var ucenik in ucenici)
            {
                Console.WriteLine("\nIme: " + ucenik.Ime);
                Console.WriteLine("Prezime: " + ucenik.Prezime);
                Console.WriteLine("Starost: " + ucenik.Starost());
                Console.WriteLine("Prosjek: " + ucenik.Prosjek);
                Console.WriteLine("Ocjena: " + ucenik.IspisProsjeka());
            }
        }
    }
}
