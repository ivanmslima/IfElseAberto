using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 8 && hora < 23)
            {
                Console.WriteLine("Estamos abertos!");
            }
            else
            {
                Console.WriteLine("Estamos fechados");
            }


        }
    }
}