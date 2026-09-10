namespace Jatekos
{
    public class Jatekos
    {
        public string Nev { get; set; }
        public int Elet
        {
            get;
            set
            {
                field = Math.Clamp(value, 0, 100);
                if (log) Kiiras();
            }
        }

        public bool log = false;

        public Jatekos(string _nev)
        {
            this.Nev = _nev;
        }

        public Jatekos(string _nev, bool _log)
        {
            this.Nev = _nev;
            this.log = _log;
        }

        public void Kiiras()
        {
            Console.WriteLine($"A {Nev} nevű játékos életereje: {Elet}.");
        }
    }
}
