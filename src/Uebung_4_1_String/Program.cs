// ------------------------------
// Uebung_4_1_String
// ------------------------------

namespace Uebung_4_1_String;

class Program
{
    static void Main(string[] args)
    {
       string s = "Hi was geht";

       Console.WriteLine(s.Length);
       Console.WriteLine(s[0]);

       Console.WriteLine("a".CompareTo("b"));

       Console.WriteLine(s.Substring(1));

       Console.WriteLine(s.Contains("was"));
       Console.WriteLine(s.IndexOf("i"));
       Console.WriteLine(s.LastIndexOf("e"));
       Console.WriteLine(s.StartsWith("Hi"));
       Console.WriteLine(s.EndsWith("eht"));

       Console.WriteLine(s.ToLower());
       Console.WriteLine(s.ToUpper());

       Console.WriteLine(s.Insert(2, ","));

       Console.WriteLine(s.PadLeft(15));
       Console.WriteLine(s.PadRight(15, '.'));

       string s2 = "  Hi  ";
       Console.WriteLine(s2.Trim());
       Console.WriteLine(s2.TrimStart());
       Console.WriteLine(s2.TrimEnd());

    }
}
