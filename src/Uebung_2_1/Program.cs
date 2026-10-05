// ------------------------------
// Übung_2
// ------------------------------

namespace Konstruktoren;

class Schulklasse
{
    public string KV_Name;
    public int anzahlSchueler;

    public Schulklasse() : this("test", 10)
    {

    }

    public Schulklasse(string name, int zahl)
    {
        KV_Name = name;
        anzahlSchueler = zahl;

    }


    public override string ToString()
    {
        return $"Name des Klassenvorstands: {KV_Name}, Anzahl der Schüler: {anzahlSchueler}";
    }

    public void Dazu()
    {
        anzahlSchueler++;
    }

    public void Raus(int anzahl)
    {
        anzahlSchueler = anzahlSchueler - anzahl;
    }

    public void Klassenwechselnach(Schulklasse AHET)
    {
        AHET.anzahlSchueler += 1;
        anzahlSchueler -= 1;

    }
}


class Program
{
    static void Main(string[] args)
    {
        Schulklasse AHITS = new Schulklasse("Straßer", 22);
        Schulklasse AHET = new Schulklasse("Falkner", 12);

        AHITS.Klassenwechselnach(AHET);

        Console.WriteLine(AHITS);
        Console.WriteLine(AHET);



    }


}
