using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
   public class ConsoleHelper
    {
        public static void WriteHeading(string heading)
        {
            if (String.IsNullOrWhiteSpace(heading))
            {
                throw new ArgumentNullException("heading");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(heading);
            Console.ResetColor();
        }

        public static void Indent(string msg)
        {
            if (String.IsNullOrWhiteSpace(msg))
            {
                throw new ArgumentNullException("msg");
            }
            var message = String.Format("    {0}", msg);
            Console.WriteLine(message);
        }

        public static void ConfirmSuccess(string heading = "")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (String.IsNullOrWhiteSpace(heading))
            {
                Console.WriteLine("Command finished successfully.");
            }
            else
            {
                Console.WriteLine(heading);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static string WarnGetResponse(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (String.IsNullOrWhiteSpace(warning))
            {
                throw new ArgumentNullException("warning");
            }
            Console.Write(warning);
            Console.ResetColor();
            var input = Console.ReadLine();
            return input;
        }

        public static void Warn(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (String.IsNullOrWhiteSpace(warning))
            {
                throw new ArgumentNullException("warning");
            }
            Console.Write(warning);
            Console.ResetColor();
        }

        public static void Processing(int total, int complete, int lineNumber)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            decimal percent = ((decimal)complete / total) * 100;
            Console.CursorTop = lineNumber;
            if (total <= complete || percent == 100M)
            {
                Console.Write("Processing command:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" COMPLETE");
            }
            else
            {
                Console.WriteLine(String.Format("Processing command:{0}%", percent.ToString("##")));
            }

            Console.ResetColor();
        }

        public static void Processing(long page, int lineNumber)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.CursorTop = lineNumber;
            Console.WriteLine(String.Format("Processing page:{0}", page.ToString()));

            Console.ResetColor();
        }
    }
}
