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
                        szemelyKezelese(személyekKezelő, ügyekKezelő);
                        break;
                    case 3:
                        bizonyitekKezelese(ügyekKezelő, bizkez);
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
                Console.WriteLine("2. Meglévő ügyek listázása");
                Console.WriteLine("3. Kilépés\n");
                Console.Write("Szám: ");

                szamInput = Convert.ToInt32(Console.ReadLine());

                switch (szamInput)
                {
                    case 1:
                        ugyLetrehozas(ugyKezelo, szemelyKezelo, bizonyitekKezelo);
                        break;
                    case 2:
                        ugyKezelo.kiirat();
                        break;
                    case 3:
                        szamInput = 4;
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
                    Console.Write($"{e}. személy életkora: ");
                    int eletkor = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{e}. személy megjegyzése: ");
                    string megjegyzes = Console.ReadLine();
                    Személy ujSzemely = new Személy(szemelyNev,eletkor,megjegyzes);

                    ujUgy.SzemelyekListaja.Add(ujSzemely);
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
                    Console.Write($"{e2}. bizonyíték azonosítója: ");
                    string azonosito = Console.ReadLine();
                    Console.Write($"{e2}. bizonyíték típusa: ");
                    string tipus = Console.ReadLine();
                    Console.Write($"{e2}. leírás azonosítója: ");
                    string leirass = Console.ReadLine();
                    Console.Write($"{e2}. bizonyíték megbízhatósága: ");
                    int megbizhatosag = Convert.ToInt32(Console.ReadLine());

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
        /*public static void ugyModositasa(ÜgyekKezelő ügyekKezelő, Ügy uggy)
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

            int inp = Convert.ToInt32(Console.ReadLine());

            switch (inp)
            {
                case 1:
                    adattagAtnevezes(ügyekKezelő,ugyID, uggy);
                    break;
                case 2:
                    break;
            }*/

        public static void szemelyKezelese(SzemélyekKezelő kezelo, ÜgyekKezelő ugyKezelo)
        {
            int szamInput;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Személyek kezelését választotta!\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine("1. Személy létrehozása, és hozzáadása egy ügyhöz");
                Console.WriteLine("2. Kilépés\n");
                Console.Write("Szám: ");

                szamInput = Convert.ToInt32(Console.ReadLine());

                switch (szamInput)
                {
                    case 1:
                        szemelyLetrehozasa(kezelo,ugyKezelo);
                        break;
                    case 2:
                        szamInput = 2;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rossz értéket adtál meg!\n");
                        Console.ResetColor();
                        break;
                }
            }
            while (szamInput != 2);
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
            szem.hozzaad(ujSzemely);

            Console.WriteLine($"Jelenlévő ügyek: {ugy.kiirat}");
            Console.Write($"\n Ügy Azonosítója: ");
            string azonosito = Console.ReadLine();

            ugy.ugySzemelyHozzaad(azonosito,ujSzemely);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nNyomj meg egy gombot a visszatéréshez...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /*public static void adattagAtnevezes(ÜgyekKezelő ugykez, string ugyID, Ügy ugy)
        {
            Console.Clear();
            ugykez.kiiratSorszammal(ugyID,ugykez);
        }*/

        public static void bizonyitekKezelese(ÜgyekKezelő ügykez, BizonyítékokKezelő bizkezel)
        {
            int szamInput;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bizonítékok kezelését választotta!\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine("\n1. Bizonyíték létrehozása, és hozzáadása egy ügyhöz");
                Console.WriteLine("2. Kilépés");
                Console.WriteLine("\n Szám: ");

                szamInput = Convert.ToInt32(Console.ReadLine());

                switch (szamInput)
                {
                    case 1:
                        bizonyitekLetrehozas(ügykez,bizkezel);
                        break;
                    case 2:
                        szamInput = 2;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rossz értéket adtál meg!\n");
                        Console.ResetColor();
                        break;  
                }
            }
            while (szamInput != 2);
        }

        public static void bizonyitekLetrehozas(ÜgyekKezelő ügykezelo, BizonyítékokKezelő bizkezelo)
        {
            Console.Clear();
            Console.Write("Azonosító: ");
            string azonosito = Console.ReadLine();
            Console.WriteLine("Típus: ");
            string tipus = Console.ReadLine();
            Console.WriteLine("Leírás: ");
            string leiras = Console.ReadLine();
            Console.WriteLine("Megbízhatóság: ");
            int megbizhatosag = Convert.ToInt32(Console.ReadLine());

            Bizonyíték ujbizonyitek = new Bizonyíték(azonosito,tipus,leiras,megbizhatosag);
            bizkezelo.hozzaad(ujbizonyitek);

            Console.WriteLine($"Jelenlévő ügyek: {ügykezelo.kiirat}");
            Console.Write($"\n Ügy Azonosítója: ");
            string azon = Console.ReadLine();

            ügykezelo.ugyBizonyitekHozzaad(azon,ujbizonyitek);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nNyomj meg egy gombot a visszatéréshez...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();


        }
    }
}
