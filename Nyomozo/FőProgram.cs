namespace Nyomozo
{
    internal class FőProgram
    {
        static void Main(string[] args)
        {
            SzemélyekKezelő személyekKezelő = new SzemélyekKezelő();
            ÜgyekKezelő ügyekKezelő = new ÜgyekKezelő();

            int intSzamInput;

            do
            {
                UI();
                Console.Write("Szám: ");
                intSzamInput = Convert.ToInt32(Console.ReadLine());

                switch (intSzamInput)
                {
                    case 1:
                        ugyekKezelese(ügyekKezelő);
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
        public static void ugyekKezelese(ÜgyekKezelő ugyKezelo)
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
                        ugyLetrehozas(ugyKezelo);
                        break;
                    case 2:
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
        public static void ugyLetrehozas(ÜgyekKezelő ügyekKezelő)
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

            Console.Write($"Jelenlévő személyek: ");


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nNyomj meg egy gombot a visszatéréshez...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
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
