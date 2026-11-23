// ------------------------------
// Uebung_4_2_Reverse_Output
// ------------------------------

namespace Uebung_4_2_Reverse_Output;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hi";
        ReverseOutput(s1);
    }

    static void ReverseOutput(string s)
    {

        for(int i = s.Length-1; i >= 0; i-- )
        {
            Console.Write(s[i]);
        }
    }
}
