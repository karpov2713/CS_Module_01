using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module1_HW_ParenthesisExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression;
            int leftSymbol = 0;
            int rightSymbol = 0;
            int enclousure = 0;
            bool isCorrect = true;

            Console.WriteLine("Введите скобочное выражение: ");
            expression = "(()()((())))(";

            foreach (var symbol in expression)
            {
                if (symbol == 40)
                {
                    enclousure++;
                }
                else if (symbol == 41)
                {
                    enclousure--;
                }
            }

            if (enclousure != 0)
            {
                isCorrect = false;
            }
        }
    }
}
