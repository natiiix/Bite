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

                    // Process the code

                    // Let the user see the output
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    WriteException(e.Message);
                }
            }
            else
            {
                WriteError("Invalid arguments!");
            }
        }

        private static void WriteError(string errmsg)
        {
            Exit("---- Fatal Error ----" + Environment.NewLine + errmsg);
        }

        private static void WriteException(string excmsg)
        {
            Exit("---- Fatal Exception ----" + Environment.NewLine + excmsg);
        }

        private static void Exit(string msg)
        {
            Console.WriteLine(msg);
            Console.Write(Environment.NewLine + "Press ENTER to exit...");
            Console.ReadLine();

            Environment.Exit(1);
        }
    }
}
