namespace HayvanatBahcesiApp
{
    public class At : Hayvan
    {
        public At(string turAdi, double agirlik, int yas) 
            : base(turAdi, agirlik, yas) { }

        public override double GetDosage() => Agirlik * 0.10;
        public override string GetFeedSchedule() => "Günde 3 kez yem verilir.";
    }
}
