using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int Suma(int a, int b)
        {
            return a + b;
        }

        private static int Resta(int a, int b)
        {
            return a - b;
        }

        private static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        private static double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir por cero.");
                return 0;
            }

            return (double)a / b;
        }

        private static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                double raiz = Math.Sqrt(i);
                Console.WriteLine("La raíz cuadrada de {0} es {1}", i, raiz);
            }
        }

        private static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            if (numero <= 3)
                return true;

            if (numero % 2 == 0 || numero % 3 == 0)
                return false;

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        private static void ImprimirPrimerosNPrimos(int n)
        {
            int contador = 0;
            int numeroActual = 2;

            while (contador < n)
            {
                if (EsPrimo(numeroActual))
                {
                    Console.Write(numeroActual + " ");
                    contador++;
                }

                numeroActual++;
            }

            Console.WriteLine();
        }

        private static double FahrenheitACelsius(double fahrenheit)
        {
            double celsius = (5.0 * (fahrenheit - 32.0)) / 9.0;
            return celsius;
        }

        private static double CelsiusAFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 * celsius / 5.0) + 32.0;
            return fahrenheit;
        }

        private static void Main(string[] args)
        {
            Console.Title = "Operaciones Matemáticas y Conversión de Temperatura";

            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir de Fahrenheit a Celsius");
                Console.WriteLine("[8] Convertir de Celsius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Código para suma
                        break;
                    case "2":
                        // Código para resta
                        break;
                    case "3":
                        // Código para multiplicación
                        break;
                    case "4":
                        // Código para división
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Los primeros 10 números primos son:");
                        ImprimirPrimerosNPrimos(10);
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
                        double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());
                        double temperaturaCelsius = FahrenheitACelsius(temperaturaFahrenheit);
                        Console.WriteLine("{0} grados Fahrenheit equivalen a {1} grados Celsius.", temperaturaFahrenheit, temperaturaCelsius);
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
                        double temperaturaCelsius2 = Convert.ToDouble(Console.ReadLine());
                        double temperaturaFahrenheit2 = CelsiusAFahrenheit(temperaturaCelsius2);
                        Console.WriteLine("{0} grados Celsius equivalen a {1} grados Fahrenheit.", temperaturaCelsius2, temperaturaFahrenheit2);
                        Console.ReadKey();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}

