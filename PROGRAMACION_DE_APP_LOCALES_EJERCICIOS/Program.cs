using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_DE_APP_LOCALES_EJERCICIOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES MENU
            int op = 0;
            int opMenu;

            // VARIABLES OPCION 1
            int valor1, valor2, _raiz;

            // VARIABLES OPCION 2

            int opArea = 0;
            int lado, _base, areaCal, altura;

            // VARIABLES OPCION 3

            // VARIABLES OPCION 4

            // VARIABLES OPCION 5
            do
            {
                Console.WriteLine("[1]. RECIDUO DE DIVISION");
                Console.WriteLine("[2]. CALCULAR AREA DE FIGURA");
                Console.WriteLine("[3]. OBTENER LA RAIZ DE UN VALOR");
                Console.WriteLine("[4]. SERIE FIBONACCI");
                Console.WriteLine("[5]. CONVERSION DE DIVISAS");
                Console.WriteLine("Escoge una opcion: ");
                opMenu = Convert.ToInt32(Console.ReadLine());
                if (opMenu == 1)
                {
                    Console.WriteLine("-------RECIDUO DE DIVISAS-------");

                    Console.WriteLine("Ingrese el primer valor valo: ");
                    valor1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo valor valo:");
                    valor2 = Convert.ToInt32(Console.ReadLine());

                    _raiz = valor2 % valor1;
                    Console.Write("El residuo de {0}/{1} es: {2} ", valor1, valor2, _raiz);
                }
                else if(opMenu == 2)
                {
                    Console.WriteLine("-------CALCULAR AREA DE FIGURA-------");

                    do
                    {
                        Console.WriteLine("[1].`CUADRADO");
                        Console.WriteLine("[1].`RECTANGULO");
                        Console.WriteLine("[1].`CIRCULO");
                        Console.WriteLine("[1].`ROMBO");
                        opArea = Convert.ToInt32(Console.ReadLine());
                        if (opArea == 1)
                        {
                            Console.WriteLine("-------CUADRADO-------");

                            Console.WriteLine("LADO: ");
                            lado = Convert.ToInt32(Console.ReadLine());
                            areaCal = lado * lado;

                            Console.WriteLine("El area del cuadrado es: {0}", areaCal);

                        }
                        else if (opArea == 2)
                        {
                            Console.WriteLine("-------RECTANGULO-------");

                            Console.Write("BASE: ");
                            _base = Convert.ToInt32(Console.ReadLine());

                            Console.Write("ALTURA: ");
                            altura = Convert.ToInt32(Console.ReadLine());

                            areaCal = _base * altura;

                            Console.WriteLine("El area calculada del rectangulo es: {0}", areaCal);
                        }
                        else if (opArea == 3)
                        {
                            Console.WriteLine("-------CIRCULO-------");
                        }
                        else if (opArea == 4)
                        {
                            Console.WriteLine("-------ROMBO-------");
                        }
                        Console.WriteLine("Desea seleccionar otra calcular otra area? [1]-SI  [2]-NO");
                        opArea = Convert.ToInt32(Console.ReadLine());
                    }
                    while (opArea == 1);
                }
                else if(opMenu == 3)
                {
                    Console.WriteLine("Selecciono la opcion 3");
                }
                else if(opMenu == 4)
                {
                    Console.WriteLine("Selecciono la opcion 1");
                }
                else if(opMenu == 5)
                {

                }

                Console.WriteLine("Desea seleccionar otra opcion? [1]-SI  [2]-NO");
                op = Convert.ToInt32(Console.ReadLine());
                // newOp = op;
            }
            while (op == 1);
            Console.WriteLine("El proceos ah terminado");
        }
    }
}
