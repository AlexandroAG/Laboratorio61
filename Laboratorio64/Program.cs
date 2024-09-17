using System;

namespace Laboratorio64
{
    class Program
    {
        static void CheckAge(int age)
        {

             if (age< 10 )
             {
                throw new ArithmeticException("Acceso negado - No cumple con el criterio de Edad");                                           
             }
             else 
             {
                Console.WriteLine("Accseso Concedido");
             }
        }

        static void Main(String[] args)
        {
            CheckAge(15);
        }
    
    } 
}