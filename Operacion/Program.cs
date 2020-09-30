using Operacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc = 0;
            string salir;
            int n1;
            int n2;

            Console.WriteLine("                                      ********************************");
            Console.WriteLine("                                      ***** B I E N V E N I D O S ****");
            Console.WriteLine("                                      ********************************\n");

            

            do
            {

                Console.Clear();

                Console.WriteLine("Elija Una Opcion: ");
                
                Console.WriteLine("1| SUMA");
                Console.WriteLine("2| RESTA");
                Console.WriteLine("3| SALIR");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        {
                            Console.WriteLine("Ingrese el valor de N°1 ");
                            n1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el valor de N°2 ");
                            n2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("El Resultado De La Suma = " + Operacion.Operacion.Sumar(n1,n2));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Ingrese el valor de N°1 ");
                            n1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el valor de N°2 ");
                            n2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("El Resultado De La Resta = " + Operacion.Operacion.Restar(n1, n2));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case 3:

                        Console.Clear();
                        Console.WriteLine("Realmente Deseea Salir... S/N");
                        salir = Console.ReadLine();

                        if (salir == "s" || salir == "S")
                        {
                            opc = 10;
                        }
                        if (salir == "n" || salir == "N")
                        {
                            opc = 0;
                        }

                        break;

                    default:
                        Console.WriteLine("La opcion ingresada es incorrecta\n");
                        break;

                }

                

            } while (opc != 10);

            Console.ReadKey();
        }
    }
}
