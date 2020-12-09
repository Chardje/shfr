using System;

namespace shfr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите: ");
            string st = Console.ReadLine();
            Console.WriteLine("\n"+pas(st));
            Console.Write("Введите: ");
            string pasw = Console.ReadLine();
            Console.WriteLine("\n" +repas(pasw));
        }
        static string pas (string st)
        {
            char[] Slowo =st.ToCharArray();
            string pasw1 = null;
            Random R = new Random();
            int g = R.Next(5,100);
            for (int i=0;i<Slowo.Length;i++)
            {
                if (Slowo[i]+g < 10)
                {
                    pasw1 += "0";
                }
                if (Slowo[i]+g<100)
                {
                    pasw1 += "0";
                }
                pasw1 +=(Convert.ToInt32(Slowo[i])+g);
            }
            if (g < 10)
            {
                pasw1 += "0";
            }            
            pasw1 +=g;
            return pasw1;
        }
        static string repas(string pasw)
        {
            short x;
            byte gb =Convert.ToByte(Convert.ToString(pasw[pasw.Length-2] +""+ pasw[pasw.Length - 1]));
            string gs = null;
            string slowo = null;
            for (int i = 0; i < (pasw.Length - 2) / 3; i++)
            {
                gs = Convert.ToString(pasw[i*3]) + Convert.ToString(pasw[i * 3 + 1]) + Convert.ToString(pasw[i * 3 + 2]);
                x = Convert.ToInt16(gs);
                x-=gb;
                slowo += (char)x;
            }
            return slowo;
        }

    }
}
