using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class kuriage
    {
        public static int kuriage10(int i)
        {
            int x, y;

            x = 0;
            y = 0;

            if (i < 0)
            {
                i = i * -1;
                x = i % 10;
                y = i - x;
                i = y + 10;
                i = i * -1;
                return i;
            }
            x = i % 10;
            if(x==0){
                return i;
            }
            else
            {
                y = i - x;
                i = y + 10;
                return i;
            }
        }
    }
}