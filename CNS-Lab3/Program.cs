using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNS_Lab3
{
    class Program
    {
        static void Main(String[] args)
        {
            
            String hash1 = "236223eef855bb5701f71dbccbf1d1b2";
            String hash2 = "5fec27b38bd92b0adae476ee9c3e9f19";
            String s;
            //Console.WriteLine("{0} : {1}",s = GetBits(hash1),s.Length);
            Compare(hash1, hash2);

            hash1 = "21ef3538c7963d0515ab15ca2ebdb4f2";
            hash2 = "18bfc11803ece8d3b37cef25ca36b19a";

            Compare(hash1, hash2);
        }
        public static void Compare(String hash1, String hash2)
        {
            String Bits1 = GetBits(hash1);
            String Bits2 = GetBits(hash2);
            
            int count = 0;
            for (int i = 0; i < Bits1.Length; i++)
            {
                if (Bits1[i] == Bits2[i])
                    count++;
            }

            Console.WriteLine("Hash 1: {0}\nHash 2: {1}",hash1,hash2);
            Console.WriteLine("{0}/{1} matches - {2}%\n\n", count, Bits1.Length, (float)count / Bits1.Length * 100);
        }

        public static String GetBits(String input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.Append(Convert.ToString(Convert.ToByte(c),2).PadLeft(8,'0'));
            }
            return sb.ToString();
        }
    }
}
