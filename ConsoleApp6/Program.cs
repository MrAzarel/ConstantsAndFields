using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    class ConstantsAndFields
    {
        public const int constant = 5;
        public readonly int[] masToRead = { 2, 3, 4, 5 };
        private int priv = 0;
        public int publ = 0;
        protected int protect;
        internal int inter = 0;
        protected internal int protectIter = 0;
        private protected int privProtect = 0;
        public static int publStat = 0;

        public ConstantsAndFields(int n)
        {
            masToRead[1] = n;
        }

        public int Priv()
        {
            return priv;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int constTest = ConstantsAndFields.constant;
            constTest -= 1;
            //Console.WriteLine(constTest);
        }
    }
}