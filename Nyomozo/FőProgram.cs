namespace Nyomozo
{
    internal class FőProgram
    {
        static void Main(string[] args)
        {
			int intSzamInput;

            do
			{
                UI();
                Console.Write("Szám: ");
				intSzamInput = Convert.ToInt32(Console.ReadLine());

				switch (intSzamInput)
				{
					case 1:
						Ügy.ügyKezelese();
                        break;
					case 2:
						Személy.szemelyKezelese();
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

        static private void UI()
        {
			Console.WriteLine("1. Ügyek kezelése");
			Console.WriteLine("2. Személyek kezelése");
			Console.WriteLine("3. Bizonyítékok kezelése");
			Console.WriteLine("4. Idővonal megtekintése");
			Console.WriteLine("5. Elemzés / Döntések");
			Console.WriteLine("6. Kilépés\n");
        }

    }
}
