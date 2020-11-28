using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_7_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8. Entrar via teclado, com dois valores distintos. Exibir o maior deles. */
            Comparador com = new Comparador();

            Console.WriteLine("Digite o 1° valor");
            com.setNum1(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 2° valor");
            com.setNum2(double.Parse(Console.ReadLine()));

            Console.WriteLine("O maior valor é {0}", com.getMaior());
            Console.ReadKey();

        }
    }
}
