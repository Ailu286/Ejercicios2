using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            //tarea1
            Console.WriteLine("Ingrese su número identificador: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su contraseña: ");
            int cont = Convert.ToInt32(Console.ReadLine());
                while (id != 1234 && cont != 1111)
                {
                    Console.WriteLine("Acceso Denegado, intente nuevamente");
                    Console.WriteLine("Ingrese su número identificador: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese su contraseña: ");
                    cont = Convert.ToInt32(Console.ReadLine());
                }
            
            //tarea2
            int cifras = 0;
            Console.WriteLine("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
                do
                {
                    num = num / 10;
                    cifras++;
                } while (num != 0);
            Console.WriteLine("El número es de "+ cifras + " cifras");
            Console.ReadKey();

            //tarea3
            int num1 = 9;
            Console.WriteLine(num1);
            do
            {
                num1 = num1 + 9;
                Console.WriteLine(num1);
            } while (num1 < 90);
            Console.ReadKey();

            //tarea4
            int num2 = 1;
            while (num2 > 0)
            {
                Console.WriteLine(num2);
                num2++;
            }
            Console.ReadKey();

            //tarea5
            while(true)
            {
                Console.Write("hola");
            }

            //tarea6
            int a1 = 5;
            Console.WriteLine("El resultado de a es " + a1);
            int b1 = ++a1;
            Console.WriteLine("El resultado de b es " + b1);
            int c1 = a1++;
            Console.WriteLine("El resultado de c es " + c1);
            b1 = b1 * 5;
            Console.WriteLine("El nuevo resultado de b es " + b1);
            a1 = a1 * 2;
            Console.WriteLine("El nuevo resultado de a es " + a1);
            Console.ReadKey();

            //tarea7
            int a2 = 5;
            Console.WriteLine("El resultado de a es " + a2);
            int b2 = a2+2;
            Console.WriteLine("El resultado de b es " + b2);
            b2-= 3;
            Console.WriteLine("El nuevo resultado de b es " + b2);
            int c2 = -3;
            Console.WriteLine("El resultado de c es " + c2);
            c2 *= 2;
            Console.WriteLine("El nuevo resultado de c es " + c2);
            c2 = ++c2;
            Console.WriteLine("El nuevo resultado de c es " + c2);
            a2 *= b2;
            Console.WriteLine("El nuevo resultado de a es " + a2);
            Console.ReadKey();

            //tarea8
            Console.WriteLine("Ingrese una letra: ");
            string letra = Console.ReadLine();
                if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                {
                Console.WriteLine("Esa letra es una vocal");
                Console.ReadLine();
                }
                else
                {
                Console.WriteLine("Esa letra no es una vocal");
                Console.ReadLine();
                }

            //tarea9 */
            Console.WriteLine("Ingrese su Usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su Contraseña: ");
            string contraseña1 = Console.ReadLine();
            Console.WriteLine("Ingrese nuevamente su Contraseña: ");
            string contraseña2 = Console.ReadLine();
            while (contraseña1 != contraseña2)  
            {
                Console.WriteLine("No se ingreso la misma contraseña, intente nuevamente");
                Console.WriteLine("Ingrese su Contraseña: ");
                contraseña1 = Console.ReadLine();
                Console.WriteLine("Ingrese nuevamente su Contraseña: ");
                contraseña2 = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Usuario Creado");
            Console.ReadKey();

            //tarea10
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            if (nombre == "Martín")
            {
                Console.WriteLine("Hola");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No te conozco");
                Console.ReadLine();
            }
        }
    }
}
