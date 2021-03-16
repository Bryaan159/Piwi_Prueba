/*
SUMA DE LOS PRIMEROS 100 NUMEROS #1
using System;

namespace Excer1_10
{
    class Program
    {
        static void Main(string[] args)
        {   
            int number = 0;
            //int resultado = 0;
            //La suma de los primeros 100 numeros
            for(int i =1 ; i<=100;i++)
            {
                
                number = number+i;
            }
            Console.WriteLine($"El resultado es: {number}");
        }
    }
}
*/
using System;

namespace Excer1_10
{
    class Program
    {
        static void Main(string[] args)
        {   
            int suma = 0;
            int acumulador = 0;
            while (acumulador<=10)
            {
                
                suma = suma+acumulador;
                
            }
            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}

