using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_medidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de medidas \n");

            Console.WriteLine("Operações: \n 1 - Metros (m) para quilômetros (Km) \n 2 - Quilômetros (Km) para Metros (m) \n 3 - Celsius (C) para fahrenheit (F) \n 4 - Fahrenheit (F) para Celsius (C)\n ");

            Console.Write("Digite a operação: ");
            int conv = int.Parse(Console.ReadLine());
            int me1;
            int conversao;

            while (conv < 1 || conv > 4)
            {
                Console.WriteLine("Operação inválida!");
                Console.Write("Digite a operação: ");
                conv = int.Parse(Console.ReadLine());
            }
            switch (conv)
            {
                case 1:
                    Console.Write("Digite a medida em Metros: ");

                    me1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite a medida em Metros: ");

                    conversao = converter(conv, me1);

                    Console.WriteLine($"{conversao} Km");
                    break;

                case 2:

                    Console.Write("Digite a medida em Quilometros: ");

                    me1 = int.Parse(Console.ReadLine());

                    conversao = converter(conv, me1);

                    Console.WriteLine($"{conversao} metros");
                    break;
                case 3:

                    Console.Write("Digite a medida em Celsius: ");

                    me1 = int.Parse(Console.ReadLine());

                    conversao = converter(conv, me1);

                    Console.WriteLine($"{conversao}ºF");
                    break;
                case 4:

                    Console.Write("Digite a medida em Fahrenheit: ");

                    me1 = int.Parse(Console.ReadLine());

                    conversao = converter(conv, me1);

                    Console.WriteLine($"{conversao}ºC");
                    break;
            }


            int converter(int operation, int m1)
            {
                int result;

                if (operation == 1)
                {
                    result = m1 / 1000;
                }
                else if (operation == 2)
                {

                    result = m1 * 1000;
                }

                else if (operation == 3)
                {
                    result = (m1 * 9 / 5) + 32;
                }
                else
                {
                    result = (m1 - 32) * 5 / 9;

                }

                return result;
            }


        }

    }
}




