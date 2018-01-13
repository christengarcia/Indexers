﻿/*
 * C# Program to Implement Use of Indexers
 */

using System;

namespace Indexers
{
    class values
    {
        private int[] val = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        public int Length
        {
            get { return val.Length; }
        }
        public int this[int index]
        {
            get
            {
                return val[index];
            }
            set
            {
                val[index] = value;
            }
        }

        class MainClass
        {
            static void Main(string[] args)
            {
                values newval = new values();
                newval[3] = 58;
                newval[5] = 60;
                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine("Element #{0} = {1}", i, newval[i]);
                }
                System.Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
            }
        }
    }
}      
    

