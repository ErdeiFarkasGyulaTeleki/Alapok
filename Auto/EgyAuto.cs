namespace Auto
{
    public class EgyAuto
    {
        public string Marka;
        public int Eletkor;

        public EgyAuto(string Marka, int Eletkor)
        {
            this.Marka = Marka;
            this.Eletkor = Eletkor;
        }

        public void Kiiras()
        {
            Console.WriteLine($"Egy {Marka} márkájú autó {Eletkor} éves!");
        }
    }
}
