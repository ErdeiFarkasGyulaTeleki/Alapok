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

        public void Kiiras()
        {
            Console.WriteLine($"A {Nev} nevű játékos életereje: {Elet}.");
        }
    }
}
