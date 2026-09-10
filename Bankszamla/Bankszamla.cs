namespace Bankszamla
{
    public class Bankszamla
    {
        private double egyenleg;
        private bool log;

        public Bankszamla()
        {
            this.log = false;
        }

        public Bankszamla(bool log)
        {
            this.log = log;
        }

        public void Befizetés(double osszeg)
        {
            if (osszeg <= 0)
            {
                Console.WriteLine($"Nem lehet a nempozitív {osszeg} összeget befizetni!");
                return;
            }

            egyenleg += osszeg;

            if (log)
            {
                Console.WriteLine($"{osszeg} befizetve a számlára. Így azon {egyenleg} Forint van.");
            }
        }

        public void Kivet(double osszeg)
        {
            if (osszeg > egyenleg)
            {
                Console.WriteLine($"Nincs annyi egyenlege, hogy {osszeg} Forint kivegyen!");
                return;
            }

            egyenleg -= osszeg;

            if (log)
            {
                Console.WriteLine($"{osszeg} kivéve a számláról. Így azon {egyenleg} Forint van.");
            }
        }

        public void EgyenlegKiiras()
        {
            Console.WriteLine($"A számlán {egyenleg} Forint van.");
        }
    }
}
