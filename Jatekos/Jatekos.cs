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
            }
        }

        public Jatekos(string _nev)
        {
            this.Nev = _nev;
        }

        public void Kiiras()
        {
            Console.WriteLine($"A {Nev} nevű játékos életereje: {Elet}.");
        }
    }
}
