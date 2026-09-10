namespace Konyv
{
    public class Konyv
    {
        public string Cim;
        public int Ar;

        public Konyv(string _cim, int _ar)
        {
            this.Cim = _cim;
            this.Ar = _ar;
        }

        public void Kiiras()
        {
            Console.WriteLine($"A {Cim} című könvy ára {Ar} Forint.");
        }
    }
}
