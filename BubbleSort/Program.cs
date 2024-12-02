namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liste = { 4, 33, 7, 1, 23, 12 };  // ohne sort.methode

                    // i = elementIndex, j = sortierSchleife

            for (int i = 0; i < liste.Length - 1; i++)     //Schleife bis alle Zahlen sortiert sind
            { 
                for (int j = 0;j < liste.Length - i - 1; j++)  // SChleife 2 innerhalb Schleife 1
                {
                    if (liste[j] > liste[j + 1])
                    {
                        int platzhalter = liste[j];    //Tauscht Platzhalter mit Listenplatz
                        liste[j] = liste[j + 1];
                        liste[j + 1] = platzhalter;

                        
                    }
                }
             }
            foreach (int k in liste)
            { 
                Console.WriteLine(k);
            }

            Console.WriteLine(string.Join(" , ", liste));
        }
    }
}
