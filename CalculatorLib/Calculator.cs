using System;

namespace CalculatorLib
{
    public class Calculator
    {
        //int buffer1;
        //int buffer2;
        //char operand = '-';

        // A decimal to hold the result
        private decimal result; 


        // Võtab vastu nupuvajutusi
        public void KeyPress(char key)
        {
        }

        // Tagastab tulemuse
        public decimal? Result
        {
            get
            {
                return result;
            }
        }
    }
}
