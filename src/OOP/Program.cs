// ------------------------------
// OOP
// ------------------------------

namespace OOP;

class Schule
{
    public string name; // member Variable oder Feld
    public int anzahlSchueler;
    public int anzahlLehrer;

    // non static Methode
    public int AnzahlPersonen()
    {
        return anzahlSchueler + anzahlLehrer;
    }

    // ToString() Methode
    public override string ToString()
    {
        return $"Schule: {name}, Schüler: {anzahlSchueler}, Lehrer: {anzahlLehrer}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Schule htl = new Schule(); // Objekt erstellen (instanzieren)
        htl.name = "HTL Braunau"; // member Variable setzen
        htl.anzahlSchueler = 800;
        htl.anzahlLehrer = 100;
        // Aufruf der methode AnzahlPersonen() für Objekt htl
        Console.WriteLine($"Gesamte Anzahl der Personen {htl.AnzahlPersonen()} an der {htl.name}");

        // HLW
        Schule hlw = new Schule();
        hlw.name = "HLW Braunau";
        hlw.anzahlSchueler = 600;
        hlw.anzahlLehrer = 80;
        Console.WriteLine($"Gesamte Anzahl der Personen {hlw.AnzahlPersonen()} an der {hlw.name}");


        //-----------------

        int n = 42;
        Console.WriteLine(n);
        Console.WriteLine(htl); // automatischer Aufruf von ToString
        Console.WriteLine(htl.ToString());
    }
}
