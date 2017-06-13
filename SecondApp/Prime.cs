using System;
using System.Collections.Generic;
using System.Text;

namespace SecondApp
{
    public class Prime
    {
        public static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
    }
}
