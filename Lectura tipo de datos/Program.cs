using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectura_tipo_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //La palabra reservada int me sirve para declarar
            //numeros enteros
            int a;
            Console.WriteLine("Ejemplo");
            a = 3;
            Console.WriteLine("El valor de a: \n" + a);
            a = 8;
            Console.WriteLine("El valor de a: \n" + a);
            //Prueba propando ingresar un valor de 7.8
            //Y dime que es lo que pasa
            Console.WriteLine("El valor de a: \n" + a);
            //<-------------------------------------------->
            //Numeros decimales o con punto decimal 
            //en c# estan dos palabras reservadas 
            //double y float
            double b;
            float f;
            Console.WriteLine("Ejemplo");
            b = 3.1416;
            Console.WriteLine("El valor de b: \n" + b);
            b = 45.15;
            Console.WriteLine("El valor de b: \n" + b);
            Console.WriteLine("Ejemplo de flotantes");
            /*Declaramos variables de tipo flotante al final se debe colocar
             * el sufijo f que hace alucion al tipo de dato flotante
              En resumen, la f al final de un numero decimal se utiliza para asegurarse de que el valor sea tratado como float y no como double.*/
            f = 3.001f;
            Console.WriteLine("El valor de f: \n" + f);
            f = 45.16f;
            Console.WriteLine("El valor de f: \n" + f);
            //Declaramos la variable f y le asignamos notacion cientifica como 
            //en el ejemplo
            f = 134.45E-2f;
            Console.WriteLine(f);
            //Salida: 1.3445

            //<----------------------------------------

            char z = 'A';
            char y = '1';
            char t;
            //Al momento de declararlo lo hacemos con comillas simple ''
            Console.WriteLine("El valor de z = {0} y el valor de y = {1}", z,y);
            Console.WriteLine("Ingresa un valor o letra");
            t = char.Parse(Console.ReadLine());
            Console.WriteLine("El valor de t: char t:\n" + t);
            Console.ReadKey();

            //<-------------------------------------------------->>
            //tipo de daos logicos o booleans
            //Este tipo de datos nos sirve para comprar y lo podemos manejar con los
            //Siguientes valores
            //true y false
            //Verdadero o falso
            //en el ejemplo se encuentra directamente asignado valores a las varibables
            bool verdadero = true;
            bool falso = false;
            //Normalmente esto nos sirve para manejar respuestas condicionales
            Console.WriteLine("Valores de las variables valor de verdad: {0}, valor de falso; {1}", verdadero, falso);
            Console.ReadKey();

        }
    }
}
