using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Windows;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int max = 50;
            ArrayList liczbyArrayList = new ArrayList(max);

            for (int i = 1; i <= max; i++)
            {
                liczbyArrayList.Add(i);
            }
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int index = rand.Next(0, max - 1);
                Console.WriteLine(liczbyArrayList[index]);
                max--;
                liczbyArrayList.Remove(index);
            }
            Console.Read();
        }
    }
}