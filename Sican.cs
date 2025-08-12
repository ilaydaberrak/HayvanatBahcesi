namespace HayvanatBahcesiApp
{
    public class Sican : Hayvan
    {
        public Sican(string turAdi, double agirlik, int yas) 
            : base(turAdi, agirlik, yas) { }

        public override double GetDosage() => Agirlik * 0.05;
        public override string GetFeedSchedule() => "Günde 4 kez küçük porsiyon verilir.";
    }
}
