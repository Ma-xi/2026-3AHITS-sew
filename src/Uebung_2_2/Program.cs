// ------------------------------
// Uebung_2_2
// ------------------------------

using System.Security.Cryptography;

namespace Uebung_2_2;

class Rechteck
{
    double a;
    double b;

    public Rechteck() : this(10, 20)
    {

    }
    public Rechteck(double laenge1, double laenge2)
    {
        a = laenge1;
        b = laenge2;
    }

    public override string ToString()
    {
        return $"Die Seite a hat die Länge: {a} und die Seite b hat die Länge: {b}";
    }

    public void Resize()
    {
        if (a < b)
        {
            b -= a;
        }
        else
        {
            a -= b;
        }
    }

    public void Inflate(double prozent)
    {
        a *= prozent;
        b *= prozent;
    }

    public double AspectRatio()
    {
        double erg;
        if (a < b)
        {
            erg = b / a;
        }
        else
        {
            erg = a / b;
        }

        return erg;
    }

    public void SetMaxSide(double newLength)
    {
        if (a < b)
        {
            double e = a / b;
            b = newLength;
            a *= e;
        }
        else
        {
            double e = b / a;
            a = newLength;
            b *= e;

        }
    }

    public double flaeche()
    {
        double fl = a * b;
        return fl;
    }

    public int Tile(Rechteck r)
    {
        int anzahl =  (int)(flaeche() / r.flaeche());

        return anzahl;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Rechteck r1 = new Rechteck(25, 20);
        Rechteck r = new Rechteck(1, 15);
        Console.WriteLine(r1);
        r1.SetMaxSide(30);
        double e = r1.AspectRatio();
        Console.WriteLine(r1);
        Console.WriteLine(e);
        double fläche = r1.flaeche();
        Console.WriteLine(fläche);
        int anzahl = r1.Tile(r);
        Console.WriteLine(anzahl);

    }
}
