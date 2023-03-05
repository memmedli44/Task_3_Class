using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Class
{
    internal class Helper
    {
        static  public string ReadString(string text)
        {
          l1:
            Console.Write(text);
            string value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                goto l1;
            }

            return value;
        }
        static public int ReadInt(string question, int min, int max)
        {
            int value;

        l1: Console.Write(question);
            string valueStr = Console.ReadLine();
            if (!int.TryParse(valueStr, out value))
            {
                Console.WriteLine($"{valueStr} uygun deyil");
                goto l1;
            }

            if (min != 0 && value < min)
            {
                Console.WriteLine($"{value} minimal {min} qebul edile biler!");
                goto l1;
            }

            if (max != 0 && value > max)
            {
                Console.WriteLine($"{value} max {max} qebul edile biler!");
                goto l1;
            }
            return value;

        }
    }       
}
