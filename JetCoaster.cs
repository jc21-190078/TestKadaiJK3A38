using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {
        public static int ride(int k,int[] g,int r)
        {
            int b = 0 ;//添え字
            int all = 0; //搭乗人数
            int cnt = 0;　//現在の添字
            int c = 0;
            for(int z = 0; z < r; z++)
            {                      


                for(int y = cnt; y <= g.Length; y++)
                {
                    if (y > g.Length)
                    {
                        y--;
                    }
                    if (b  > k) //定員
                    {
                        b = c;
                        c = 0;
                        all = all + b;
                        b=c;
                        cnt = y-1; 
                        break;
                    }
                    c = b;
                    b = b + g[y];

                    if (y + 1 == g.Length && b > k)
                    {
                        z--;
                        c = b;
                        break;
                    }else if (y + 1 == g.Length)
                    {
                        y = -1;
                        cnt = 0;
                    }
                    else
                    {

                    }

                }                

            }           

            return all;
        }
    }
}
