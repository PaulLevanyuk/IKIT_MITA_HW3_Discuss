using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class IsEvenExtension
    {
        public static bool IsEven(this int digit)
        {
            bool flag = false;
            if (digit % 2 ==1)
            {
                flag = false;
            }
            else flag = true;

            return flag;
        }
    }
}
