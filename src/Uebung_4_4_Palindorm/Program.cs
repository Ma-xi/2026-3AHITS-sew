// ------------------------------
// Uebung_4_4_Palindorm
// ------------------------------

namespace Uebung_4_4_Palindorm;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Ein Esel lese nie";
        s1 = s1.Replace(" " ,"");
        s1 = s1.ToLower();

        string s2 = Reverse(s1);
        Console.WriteLine(s1.CompareTo(s2));
        
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
