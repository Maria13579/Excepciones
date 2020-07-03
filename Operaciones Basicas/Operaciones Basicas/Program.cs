using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            while (op < 5)
            {
                Console.WriteLine("-------------OPERACIONES BASICAS-------------");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("\n \n ");
                try
                {
                    Console.WriteLine("Ingrese el numero de opcion que desea");
                    op = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opción no valida");
                    Console.WriteLine("Ingrese el numero de opcion que desea");
                    op = int.Parse(Console.ReadLine());
                }
                if (op < 6 && op > 0)
                {
                    if (op == 1)
                    {
                        try
                        {
                            Console.WriteLine("El resultado de la suma es: " + Suma(PedirValores(), PedirValores()));
                            Console.WriteLine("\n ");
                        }
                        catch
                        {
                            Console.WriteLine("Numero No Valido");
                            Console.WriteLine("El resultado de la suma es: " + Suma(PedirValores(), PedirValores()));
                            Console.Write(+Suma(PedirValores(), PedirValores()));
                            Console.WriteLine("\n ");
                        }
                    }
                    if (op == 2)
                    {
                        try
                        {
                            Console.WriteLine("El resultado de la resta es: " + Resta(PedirValores(), PedirValores()));
                            Console.WriteLine("\n ");
                        }
                        catch
                        {
                            Console.WriteLine("Numero No Valido");
                            Console.WriteLine("El resultado de la resta es: " + Resta(PedirValores(), PedirValores()));
                            Console.WriteLine("\n ");
                        }
                    }
                    if (op == 3)
                    {
                        try
                        {
                            Console.WriteLine("El resultado de la Multiplicación es: " + Mult(PedirValores(), PedirValores()));
                            Console.WriteLine("\n ");
                        }
                        catch
                        {
                            Console.WriteLine("Numero No Valido");
                            Console.WriteLine("El resultado de la Multiplicación es: " + Mult(PedirValores(), PedirValores()));

                            Console.WriteLine("\n ");
                        }
                    }
                    if (op == 4)
                    {
                        try
                        {
                            Console.WriteLine("El resultado de la División es: " + Div(PedirValores(), PedirValores()));
                            Console.WriteLine("\n ");
                        }
                        catch
                        {
                            Console.WriteLine("Numero No Valido");
                            Console.WriteLine("El resultado de la División es: " + Div(PedirValores(), PedirValores()));
                            Console.WriteLine("\n ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numero de opción Incorecta");
                }



            }
            if (op == 5)
            {
                Console.WriteLine("Gracias por usar nuestra aplicación");
            }

            Console.ReadKey();
        }


        static double PedirValores()
        {
            Console.WriteLine("\n Ingrese un valor: ");
            return double.Parse(Console.ReadLine());
        }
        static double Suma(double n1, double n2)
        {
            return n1 + n2;
        }
        static double Resta(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Mult(double n1, double n2)
        {
            return n1 * n2;
        }
        static double Div(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
