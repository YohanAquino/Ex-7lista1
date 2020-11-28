using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_7_LISTA_1_Yohan_Aquino
{
    class Comparador
    {
        private double n1;
        private double n2;

        public void setNum1(double x) 
        {
            n1 = x;
        }
        public void setNum2(double x)
        {
            n2 = x;
        }
        public double getMaior() 
        {
            if (n1 > n2) 
            {
                return n1;
            }
            else 
            {
                return n2;
            }
        }
    }
}
