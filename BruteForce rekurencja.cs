using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string pass = "aad";
        public static bool ok = false;

        public static void Main(string[] args)
        {
            string charset = "abcdefghijklmnopqrstuvwxyz";
            int l = 1;
            while (!ok)
            {
                brute("", l, charset);
                l++;
            }
            Console.Read();
        }

        private static string brute(string str, int l, string charset)
        {
            if (str.Length == l)
            {
                return str;
            }
            foreach (var a in charset)
            {
                string temp = str + a;
                //Console.WriteLine(temp);
                if (temp == pass)
                {
                    Console.WriteLine("Haslo to " + temp);
                    ok = true;
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                brute(temp, l, charset);
            }
            return str;
        }
    }
}