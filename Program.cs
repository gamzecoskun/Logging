using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loglama
{
    class Program
    {
        static void Main(string[] args)
        {
            Logging();
            Console.ReadLine();
        }

        private static void Logging()
        {
            Console.WriteLine("If you are not a robot, write the 'I'm not a robot'");
            string txt = Convert.ToString(Console.ReadLine());

            try
            {
                if (txt != "I'm not a robot")
                {
                    throw new Exception("You are a robot!");
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", ex.Message);
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", ex.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine + "ErrorErrorErrorError" + Environment.NewLine);


            }

        }
    }
}
