// ------------------------------
// Uebung_4_3_Reverse
// ------------------------------

namespace Uebung_4_3_Reverse;

class Program
{
    static void Main(string[] args)
    {
        string s = "Hi";

        string erg = Reverse(s);
        Console.WriteLine(erg);
    }

    static string Reverse(string s1)
    {
        string string_rückwärts = "";

        for(int i=0; i<s1.Length; i++)
        {
            string_rückwärts = s1[i] + string_rückwärts;
        }

        return string_rückwärts;
    }
}
