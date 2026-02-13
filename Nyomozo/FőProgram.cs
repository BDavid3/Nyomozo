namespace Nyomozo
{
    internal class FőProgram
    {
        static void Main(string[] args)
        {
            UI();
			int intSzamInput;

			do
			{
				Console.Write("Szám: ");
				intSzamInput = Convert.ToInt32(Console.ReadLine());

				switch (intSzamInput)
				{
					case 1:
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Rossz értéket adtál meg!");
						break;
				}
			}
			while (intSzamInput < 1 || intSzamInput > 6);
			
            
		}

        static void UI()
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
