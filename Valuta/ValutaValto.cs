namespace Valuta
{
    public class ValutaValto
    {
        public double Arfolyam;
        public static readonly double FIX_ARFOLYAM = 400;

        public ValutaValto(double _arfolyam)
        {
            this.Arfolyam = _arfolyam;
        }

        public double EurorolHuf(double euro)
        {
            return euro * Arfolyam;
        }

        public static double FixEurorolHuf(double euro)
        {
            return euro * FIX_ARFOLYAM;
        }

        public void Kiiratas(double euro)
        {
            Console.WriteLine($"{euro} Euró Forintban, amikor 1 Euró értéke {Arfolyam} Forint: {EurorolHuf(8)}");
        }

        public static void FixKiiras(double euro)
        {
            Console.WriteLine($"{euro} Euró Forintban, amikor 1 Euró értéke {FIX_ARFOLYAM} Forint: {FixEurorolHuf(euro)}");
        }
    }
}
