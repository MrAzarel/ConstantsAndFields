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
        private int[] masPrivate = new int[4];
        public int[] mas3 = new int[4];
        protected int[] mas4 = new int[4];
        internal int[] mas5 = new int[4];
        protected internal int[] mas6 = new int[4];
        private protected int[] mas7 = new int[4];
        public static int[] mas8 = new int[4];
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