namespace Nyomozo
{
    internal class FőProgram
    {
        static void Main(string[] args)
        {
            SzemélyekKezelő személyekKezelő = new SzemélyekKezelő();
            ÜgyekKezelő ügyekKezelő = new ÜgyekKezelő();
            BizonyítékokKezelő bizkez = new BizonyítékokKezelő();

            int intSzamInput;

            do
            {
                UI();
                Console.Write("Szám: ");
                intSzamInput = Convert.ToInt32(Console.ReadLine());

                switch (intSzamInput)
                {
                    case 1:
                        ugyekKezelese(ügyekKezelő, személyekKezelő, bizkez);
                        break;
                    case 2:
                        szemelyKezelese(személyekKezelő,ügyekKezelő);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Kilépés...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rossz értéket adtál meg!\n");
                        Console.ResetColor();
                        break;
                }
            }
            while (intSzamInput != 6);


        }

        public static void UI()
        {
            Console.WriteLine("1. Ügyek kezelése");
            Console.WriteLine("2. Személyek kezelése");
            Console.WriteLine("3. Bizonyítékok kezelése");
            Console.WriteLine("4. Idővonal megtekintése");
            Console.WriteLine("5. Elemzés / Döntések");
            Console.WriteLine("6. Kilépés\n");
        }
        public static void ugyekKezelese(ÜgyekKezelő ugyKezelo, SzemélyekKezelő szemelyKezelo, BizonyítékokKezelő bizonyitekKezelo)
        {
            int szamInput;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ügyek kezelését választotta!\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine("1. Ügy létrehozása");
                Console.WriteLine("2. Ügy módosítása");
                Console.WriteLine("3. Meglévő ügyek listázása");
                Console.WriteLine("4. Kilépés\n");
                Console.Write("Szám: ");

                szamInput = Convert.ToInt32(Console.ReadLine());

                switch (szamInput)
                {
                    case 1:
                        ugyLetrehozas(ugyKezelo, szemelyKezelo, bizonyitekKezelo);
                        break;
                    case 2:
                        ugyModositasa(ugyKezelo);
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rossz értéket adtál meg!\n");
                        Console.ResetColor();
                        break;
                }
            }
            while (szamInput != 4);

        }
        public static void ugyLetrehozas(ÜgyekKezelő ügyekKezelő, SzemélyekKezelő szemelyekKezelo, BizonyítékokKezelő bizonyitekokKezelo)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ügy létrehozását választotta!\n");
            Console.ResetColor();
            Console.Write("Ügy azonosítója: ");
            string ugyAzonosito = Console.ReadLine();
            Console.Write("Cím: ");
            string cim = Console.ReadLine();
            Console.Write("Leírás: ");
            string leiras = Console.ReadLine();
            Console.Write("Állapot: ");
            string allapot = Console.ReadLine();

            Ügy ujUgy = new Ügy(ugyAzonosito, cim, leiras, allapot);
            ügyekKezelő.hozzaad(ujUgy);
            
            Console.Write($"Jelenlévő személyek: ");
            szemelyekKezelo.kiir();

            Console.WriteLine("\n1. Jelenlegi ügyhöz személy hozzáadása");
            Console.WriteLine("2. Személy hozzáadása kihagyása");
            Console.Write("Szám: ");
            int hozzaadInput = Convert.ToInt32(Console.ReadLine());

            if (hozzaadInput == 1)
            {
                Console.Write("Személyek száma: ");
                int mennyi = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < mennyi; i++)
                {
                    int e = 1;
                    Console.Write($"{e}. személy neve: ");
                    string szemelyNev = Console.ReadLine();
                    ujUgy.SzemelyekListaja.Add(szemelyNev);
                }

            }
            else if (hozzaadInput == 2)
            {
                Console.WriteLine("Személy hozzáadása kihagyva.");
            }

            Console.Write($"Jelenlévő bizonyítékok kiírása: ");
            bizonyitekokKezelo.kiir();

            Console.WriteLine("\n1. Jelenlegi ügyhöz bizonyíték hozzáadása");
            Console.WriteLine("2. Bizonyítéks hozzáadása kihagyása");
            Console.Write("Szám: ");
            int hozzaadInput2 = Convert.ToInt32(Console.ReadLine());

            if (hozzaadInput2 == 1)
            {
                Console.Write("Bizonyítékok száma: ");
                int mennyi2 = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < mennyi2; i++)
                {
                    int e2 = 1;
                    Console.Write($"{e2}. bizonyíték neve: ");
                    string bizNev = Console.ReadLine();
                    ujUgy.BizonyitekokListaja.Add(bizNev);
                }

            }
            else if (hozzaadInput == 2)
            {
                Console.WriteLine("Bizonyíték hozzáadása kihagyva.");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nNyomj meg egy gombot a visszatéréshez...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        public static void ugyModositasa(ÜgyekKezelő ügyekKezelő)
        {
            Console.Clear();
            Console.WriteLine("Jelenlegi ügyek: ");
            ügyekKezelő.kiirat();
            Console.Write("Módosítandó ügy ID-je: ");
            string ugyID = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1. Adattag átnevezése");
            Console.WriteLine("2. Adattag törlése");
            Console.WriteLine("3. Adattag hozzáadása");
            Console.Write("\nSzám: ");


                // idáig
            int modositInput = Convert.ToInt32(Console.ReadLine());

                if (modositInput == 1)
                {
                    Console.Write("Melyik adattagot szeretnéd átnevezni? (Cím, Leírás, Állapot): ");
                    string adattag = Console.ReadLine();
                    Console.Write("Új érték: ");
                    string ujErtek = Console.ReadLine();
    
                    foreach (var ugy in ügyekKezelő.UgyekListaja)
                    {
                        if (ugy.UgyAzonosito == ugyID)
                        {
                            switch (adattag.ToLower())
                            {
                                case "cím":
                                    ugy.Cim = ujErtek;
                                    break;
                                case "leírás":
                                    ugy.Leiras = ujErtek;
                                    break;
                                case "állapot":
                                    ugy.Allapot = ujErtek;
                                    break;
                                default:
                                    Console.WriteLine("Nincs ilyen adattag!");
                                    break;
                            }
                        }
                    }
                }
                else if (modositInput == 2)
                {
                    Console.Write("Melyik adattagot szeretnéd törölni? (Cím, Leírás, Állapot): ");
                    string adattag = Console.ReadLine();
    
                    foreach (var ugy in ügyekKezelő.UgyekListaja)
                    {
                        if (ugy.UgyAzonosito == ugyID)
                        {
                            switch (adattag.ToLower())
                            {
                                case "cím":
                                    ugy.Cim = null;
                                    break;
                                case "leírás":
                                    ugy.Leiras = null;
                                    break;
                                case "állapot":
                                    ugy.Allapot = null;
                                    break;
                                default:
                                    Console.WriteLine("Nincs ilyen adattag!");
                                    break;
                            }
                        }
                    }
                }
                else if (modositInput == 3)
                {
                    Console.Write("Melyik adattagot szeretnéd hozzáadni? (Cím, Leírás, Állapot): ");
                    string adattag = Console.ReadLine();
                    Console.Write("Érték: ");
                    string ertek = Console.ReadLine();
    
                    foreach (var ugy in ügyekKezelő.UgyekListaja)
                    {
                        if (ugy.UgyAzonosito == ugyID)
                        {
                            switch (adattag.ToLower())
                            {
                                case "cím":
                                    ugy.Cim = ertek;
                                    break;
                        }

        public static void szemelyKezelese(SzemélyekKezelő kezelo, ÜgyekKezelő ugyKezelo)
        {
            int szamInput;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Személyek kezelését választotta!\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine("1. Személy létrehozása");
                Console.WriteLine("2. Személy hozzáadása egy ügyhöz");
                Console.WriteLine("3. Kilépés\n");
                Console.Write("Szám: ");

                szamInput = Convert.ToInt32(Console.ReadLine());

                switch (szamInput)
                {
                    case 1:
                        szemelyLetrehozasa(kezelo,ugyKezelo);
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rossz értéket adtál meg!\n");
                        Console.ResetColor();
                        break;
                }
            }
            while (szamInput != 3);
        }
        public static void szemelyLetrehozasa(SzemélyekKezelő szem,ÜgyekKezelő ugy)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Személy létrehozását választotta!\n");
            Console.ResetColor();
            Console.Write("Név: ");
            string nev = Console.ReadLine();
            Console.Write("Életkor: ");
            int eletkor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Megjegyzés: ");
            string megjegyzes = Console.ReadLine();

            Személy ujSzemely = new Személy(nev, eletkor, megjegyzes);
            szem.Hozzaad(ujSzemely);

            Console.WriteLine($"Jelenleg található ügyek: {ugy.kiirat}");
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nNyomj meg egy gombot a visszatéréshez...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

    }
}
