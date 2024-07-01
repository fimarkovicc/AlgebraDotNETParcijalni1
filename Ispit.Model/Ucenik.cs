namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public int Starost() { 
            DateTime today = DateTime.Today;
            int age = today.Year - DatumRodjenja.Year;
            if (DatumRodjenja.Date > today.AddYears(-age)) age--;
            return age;
        }
        public string IspisProsjeka() {
            return Prosjek switch
            {
                < 1.5 => "nedovoljan",
                < 2.5 => "dovoljan",
                < 3.5 => "dobar",
                < 4.5 => "vrlo dobar",
                _ => "odličan",
            };
        }
    }
}
