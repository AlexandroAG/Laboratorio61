﻿using System;

namespace Laboratorio63
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                int[] MyNumbers = { 1, 2, 3 };
                Console.WriteLine(MyNumbers[10]);
            }
            catch (Exception e)
            {

                Console.WriteLine("Algo salio mal, valide el indice del Arreglo");

            }
            finally
            {

                Console.WriteLine("Continuacion de la aplicacion, luego del bloque try/catch");

            }

        }
    }
}