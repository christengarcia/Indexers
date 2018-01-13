/*
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

        static void Main(string[] args)
        {
            
        }
    }
}
