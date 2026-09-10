using Bankszamla;

Bankszamla.Bankszamla bankszamla = new Bankszamla.Bankszamla();

Console.WriteLine("Befizetéshez: b 'osszeg'. Kifizetéshez: k 'osszeg'. Összeg lekérés: ö. Jegyzés beállítása: j i/n. Kilépéshez: ki");

while (true)
{
    string input = Console.ReadLine();

    if (input == null) continue;

    if (input == "ki") break;

    string[] bontottInput = input.Split(' ');

    if (bontottInput.Length < 1) continue;

    string parancsString = bontottInput[0];

    if (parancsString == null) continue;

    if (parancsString == "b")
    {
        try
        {
            int osszeg = int.Parse(bontottInput[1]);
            bankszamla.Befizetés(osszeg);
        } 
        catch
        {
            Console.WriteLine($"A {bontottInput[1]} nem megfelelő egész szám bemenet!");
            continue;
        }
    }
    else if (parancsString == "k")
    {
        try
        {
            int osszeg = int.Parse(bontottInput[1]);
            bankszamla.Kivet(osszeg);
        }
        catch
        {
            Console.WriteLine($"A {bontottInput[1]} nem megfelelő egész szám bemenet!");
            continue;
        }
    }
    else if (parancsString == "ö")
    {
        bankszamla.EgyenlegKiiras();
    }

    else if (parancsString == "j")
    {
        try
        {
            char jegyzesChar = char.Parse(bontottInput[1]);
            if (jegyzesChar == 'i')
            {
                bankszamla.log = true;
            }
            else if (jegyzesChar == 'n')
            {
                bankszamla.log = false;
            }
        }
        catch
        {
            Console.WriteLine($"A {bontottInput[1]} nem megfelelő karakter bemenet!");
            continue;
        }
    }
}