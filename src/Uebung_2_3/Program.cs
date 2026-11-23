// ------------------------------
// Uebung_2_3
// ------------------------------

using System.ComponentModel;

namespace Uebung_2_3;


class Bankkonto
{
    public double Kontostand = 100;
    public double Zinssatz = 1.5;
    public string Kontoinhaber = "Jonas";
    public int anzahl;

    public override string ToString()
    {
        return $"Inhaber: {Kontoinhaber} Kontostand: {Kontostand} Zinssatz: {Zinssatz}";
    }

    public Bankkonto(string Kontoinhaber, double Zinssatz, double Kontostand)
    {
        this.Kontostand = Kontostand;
        this.Kontoinhaber = Kontoinhaber;
        this.Zinssatz = Zinssatz;
    }

    public Bankkonto() : this("Unbekannt", 0.5, 500)
    { }

    public void Ein(double Betrag)
    {
        Kontostand += Betrag;
    }

    public void Aus(double Betrag)
    {
        Kontostand -= Betrag;
    }

    public double JahresAbschluss()
    {
        double erg;
        double gebühren = 0;
        erg = Kontostand * Zinssatz / 100;
        Kontostand += erg;

        if(anzahl>10)
        {
            gebühren = 1 + (anzahl -10) * 0.05;
        }
        else if(anzahl> 10)
        {
            gebühren = 1;
        }
        Kontostand -= gebühren;
        anzahl = 0;
        return erg;
    }

    public void ZinsPlus(double wert)
    {
        wert /= 10;
        Zinssatz += wert;
    }

    public void ZinsMinus(double wert)
    {
        wert /= 10;
        Zinssatz -= wert;
    }

    public void plus(double Betrag)
    {
        Kontostand += Betrag;
        anzahl++;
    }

    public void minus(double Betrag)
    {
        Kontostand -= Betrag;
        anzahl++;
    }

    public void Überweisung(Bankkonto empfänger, double Betrag)
    {
        empfänger.Kontostand += Betrag;
        minus(Betrag);

    }

    public Bankkonto neueskonto(double Betrag)
    {
        Bankkonto neu = new Bankkonto("Unbekannt", 1.5, Betrag);
        minus(Betrag);
        return neu;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Bankkonto b1 = new Bankkonto("Maxi",1.5,500);
    }
}
