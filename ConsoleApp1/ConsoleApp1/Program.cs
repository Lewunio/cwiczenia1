class Program
{
    public static double ObliczSrednia(int[] liczby)
    {
        int SD = 0;
        foreach (int liczba in liczby)
        {
            SD += liczba;
        }
        return (double)SD / liczby.Length;
    }
    public static int ObliczMax(int[] liczby)
    {
        int max = liczby[0];
        foreach (int liczba in liczby)
        {
            if (max < liczba) max = liczba;
        }
        return max;
    }

    static void Main()
    {
        int[] liczby = { 1, 2, 3, 4, 5 };
            double srednia = ObliczSrednia(liczby);
            Console.WriteLine("Średnia: " + srednia);
        
    }
}