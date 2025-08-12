namespace HayvanatBahcesiApp
{
    public class Kaplan : Hayvan
    {
        public Kaplan(string turAdi, double agirlik, int yas) 
            : base(turAdi, agirlik, yas) { }

        public override double GetDosage() => Agirlik * 0.20;
        public override string GetFeedSchedule() => "Günde 2 kez et verilir.";
    }
}
