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
            int valor1, valor2, residuo;

            // VARIABLES OPCION 2

            int opArea = 0;
            int lado, _base, areaCal, altura ;
            double _pi = 3.14, radio, areaCalCir, areaCalRom ,diagonalA, diagonalB;

            // VARIABLES OPCION 3
            int _raiz;

            // VARIABLES OPCION 4
            int resultado = 0;
            int valor = 0;

            // VARIABLES OPCION 5

            int opDiv =0;

            double dolar = 19.96, euro = 19.79, libra = 22.89, yen = 0.14;

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

                    residuo = valor2 % valor1;
                    Console.Write("El residuo de {0}/{1} es: {2} ", valor1, valor2, residuo);
                }
                else if(opMenu == 2)
                {
                    Console.WriteLine("-------CALCULAR AREA DE FIGURA-------");

                    do
                    {
                        Console.WriteLine("[1].`CUADRADO");
                        Console.WriteLine("[2].`RECTANGULO");
                        Console.WriteLine("[3].`CIRCULO");
                        Console.WriteLine("[4].`ROMBO");
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
                            Console.WriteLine("RADIO DEL CIRCULO: ");
                            radio = Convert.ToDouble(Console.ReadLine());

                            areaCalCir = _pi * (radio * radio);

                            Console.WriteLine("El area del ciculo es: {0}", areaCalCir);
                        }
                        else if (opArea == 4)
                        {
                            Console.WriteLine("-------ROMBO-------");
                            Console.WriteLine("DIAGONAL A");
                            diagonalA = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("DIAGONAL B");
                            diagonalB = Convert.ToDouble(Console.ReadLine());

                            areaCalRom = (diagonalA * diagonalB) / 1;

                            Console.WriteLine("El area calculada del rombo es: {0}", areaCalRom);

                        }
                        Console.WriteLine("Desea seleccionar otra calcular otra area? [1]-SI  [2]-NO");
                        opArea = Convert.ToInt32(Console.ReadLine());
                    }
                    while (opArea == 1);
                }
                else if(opMenu == 3)
                {
                    Console.WriteLine("-------OBTENER LA RAIZ DE UN VALOR-------");

                    Console.WriteLine("Ingrese el valor para obtener la raiz cuadrada: ");
                    _raiz = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("la raiz cuadrada de {0} es: {1}", _raiz, Math.Sqrt(_raiz));

                }
                else if(opMenu == 4)
                {
                    
                    do
                    {
                        Console.WriteLine("Ingrese un valor: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        resultado = valor + resultado;

                        Console.WriteLine(resultado);

                    }
                    while (valor != 0);
                    /*for (int i = 0; i < 30; i++)
                    {
                        //Almacenamos el valor v1 en una variable temporal para no perderlo.
                        int temp = v1;

                        //El valor 1 se convierte en el valor 2.
                        v1 = v2;

                        //Sumamos los valores.
                        v2 = temp + v1;

                        //Mostramos por pantalla el resultado. 
                        Console.WriteLine(v2);
                    }*/
                }
                else if(opMenu == 5)
                {

                    do
                    {
                        Console.WriteLine("[1]. DOLARES");
                        Console.WriteLine("[2]. EUROS");
                        Console.WriteLine("[3]. LIBRAS");
                        Console.WriteLine("[4]. YEN");
                        opDiv = Convert.ToInt32(Console.ReadLine());

                        if (opDiv == 1)
                        {
                            Console.WriteLine("-------DOLARES-------");
                            Console.WriteLine("Ingrese la cantidad en dolares: ");
                            double canDolar = Convert.ToDouble(Console.ReadLine());

                            double conversion = canDolar * dolar;
                            Console.WriteLine("La cantidad de {0} Dolares a pesos MXN es de ${1} MXN", canDolar, conversion);
                        }
                        else if (opDiv == 2)
                        {
                            Console.WriteLine("-------EUROS-------");
                            Console.WriteLine("Ingrese la cantidad en euros: ");
                            double canEuro = Convert.ToDouble(Console.ReadLine());

                            double conversion = canEuro * euro;
                            Console.WriteLine("La cantidad de {0} Euros a pesos MXN es de ${1} MXN", canEuro, conversion);
                        }
                        else if (opDiv == 3)
                        {
                            Console.WriteLine("-------LIBRAS-------");
                            Console.WriteLine("Ingrese la cantidad en libras: ");
                            double canLibra = Convert.ToDouble(Console.ReadLine());

                            double conversion = canLibra * libra;
                            Console.WriteLine("La cantidad de {0} Libras a pesos MXN es de ${1} MXN", canLibra, conversion);
                        }
                        else if (opDiv == 4)
                        {
                            Console.WriteLine("-------YEN-------");
                            Console.WriteLine("Ingrese la cantidad en yen: ");
                            double canYen = Convert.ToDouble(Console.ReadLine());

                            double conversion = canYen * yen;
                            Console.WriteLine("La cantidad de {0} Yen a pesos MXN es de ${1} MXN", canYen, conversion);

                        }

                        Console.WriteLine("Desea seleccionar otra opcion de conversion [1]-SI [2]-NO");
                        opDiv = Convert.ToInt32(Console.ReadLine());

                    }
                    while (opDiv == 1);

                }

                Console.WriteLine("Desea seleccionar otra opcion? [1]-SI  [2]-NO");
                op = Convert.ToInt32(Console.ReadLine());
            }
            while (op == 1);
            Console.WriteLine("El proceos ah terminado");
        }
    }
}
