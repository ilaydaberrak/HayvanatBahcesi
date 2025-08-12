namespace HayvanatBahcesiApp
{
    public abstract class Hayvan
    {
        public string TurAdi { get; set; }
        public double Agirlik { get; set; }
        public int Yas { get; set; }

        public Hayvan(string turAdi, double agirlik, int yas)
        {
            TurAdi = turAdi;
            Agirlik = agirlik;
            Yas = yas;
        }

        public abstract double GetDosage();
        public abstract string GetFeedSchedule();
    }
}
