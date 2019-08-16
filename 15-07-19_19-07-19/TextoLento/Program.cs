using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

using System.Data;
using System.Threading;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace TextoLento
{
    class Program
    {
        static void Main(string[] args)
        {
            TextoLento("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            WriteAt("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 20, 10);

            Console.ReadKey();
        }
        static void TextoLento(string vTexto)
        {

            for (int i = 0; i < vTexto.Length; i++)
            {
                Console.Write(vTexto[i]);
                Thread.Sleep(20);
            }

            Console.WriteLine();


        }
        protected static int origRow;// Ponto horizontal ( X )

        protected static int origCol;// Ponto vertical (  . Y .)
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
