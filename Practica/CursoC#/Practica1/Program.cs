using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int number1 = 10;
           int number2 = 25;
           var resultado = number1 + number2 ;
           Console.WriteLine($"El resultado es: {resultado} y el tipo es: "+resultado.GetType());

            //Operadores de comparacion
            //< > <= >= == !=
           int valor1 = 9;
           int valor2 = 15;
           var summa = valor1 < valor2;
           Console.WriteLine($"{valor1} < {valor2}");
           if(summa == true)
           {
               Console.WriteLine("Confirmadisimo");
               if(valor1 != 9)
               {
                   Console.WriteLine(true);
               }
               else
                   Console.WriteLine(false);
           }
           else
           {
               Console.WriteLine("Negadisimo");
           }

           

        }
        //Declaration the variable
    }
}
