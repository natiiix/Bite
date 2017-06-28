using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bite
{
    class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                try
                {
                    byte[] code = File.ReadAllBytes(args[0]);
                }
                catch (FileNotFoundException e)
                {
                    Error("File \"" + args[0] + "\" not found!" + Environment.NewLine + e.Message);
                }
                catch (Exception e)
                {
                    Error(e.Message);
                }
            }

            Console.ReadLine();
        }

        private static void Error(string errormsg)
        {
            Console.WriteLine("Error: " + errormsg);
            Console.ReadLine();
        }
    }
}
