using System;

namespace Triangulo_Pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int[1];
            //Mostramos el mensaje y capturamos el dato ingresado desde la consola.
            Console.WriteLine("Ingrese el número de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());
            /* Delaramos el primer ciclo for que va a recorrer dependiendo
             * el dato ingresado que esta almacenado en la variable pisos*/
             for(int i =1; i <= pisos; i++)
            {
                /*Colocamos un arreglo y colocamos la variable i del ciclo for
                 * que será el tamaño que tendra el arreglo cada vez que el ciclo for
                 * se ejecute */
                int[] pascal = new int[i];
                //Ciclo de decrementa para crear el triangulo
                for (int j = pisos; j < i; j--)
                {
                    Console.Write(" ");
                }
                //Ciclo for que genera la suma de las cifras
                for (int k = 0; k < i; k++)
                {
                    //Condición que evalua la variable del ciclo for
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.WriteLine("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
