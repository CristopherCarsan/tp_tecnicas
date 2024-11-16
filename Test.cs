using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace Practica_35363369_Cardozo_Sanchez_Cristopher_parte_1
{
    internal class Program
    {

        static void Mostrar(string titulo){
            Console.WriteLine(titulo);
        }
      /*  static void parte1_ejercicio1(int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Módulo ejecutándose");
            }
        }

        static void parte1_ejercicio2(string nombre)
        {
            Console.WriteLine($"\nHola {nombre}, ¿Cómo estas?");


        }
        static void parte1_ejercicio3(int numero1, int numero2)
        {
            if (numero1 < numero2)
            {
                Console.WriteLine($"\nel numero maximo es: {numero2}");
            }
            else
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine($"\nel numero maximo es: {numero1}");
                }
                else
                {
                    Console.WriteLine("\nAmbos numero son iguales, no hay maximo");
                }
            }
        }

        static void parte1_ejercicio4(int numero1, int numero2, int numero3)
        {
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine($"\nel numero maximo es: {numero1}");
            }
            else if (numero2 > numero3 && numero2 > numero1)
            {
                Console.WriteLine($"\nel numero maximo es: {numero2}");
            } else if (numero3 > numero1 && numero3 > numero2)
            {
                Console.WriteLine($"\nel numero maximo es: {numero3}");
            }
            else
            {
                Console.WriteLine("\nAmbos numero son iguales, no hay maximo");
            }
        }

        static void parte1_ejercicio5(int[] vector)
        {
            int maximo = 0;
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }
            }
            Console.WriteLine($"\nel numero maximo es: {maximo}");
        }

        static void parte1_ejercicio6(int numero_entero1, int numero_entero2)
        {
            if (numero_entero1 == numero_entero2)
            {
                Console.WriteLine($"\n{numero_entero1}");
            }
            else if (numero_entero1 > numero_entero2)
            {
                for (int i = numero_entero2; i <= numero_entero1; i++)
                {
                    Console.WriteLine($"\n{i}");
                }
            }
            else
            {
                for (int i = numero_entero1; i <= numero_entero2; i++)
                {
                    Console.WriteLine($"\n{i}");
                }
            }
        }*/

        static void parte1_ejercicio7(int numero_doble )
        {
            numero_doble.GetType().ToString();
            Mostrar($"\nEl doble es: {numero_doble*2}");
        }

        static void Main(string[] args)
        {
            /*
            int numero = 0;
            int numero1= 0;
            int numero2= 0;
            int numero3= 0;
            int dimension = 0;
            string nombre = "vacio";

            Console.WriteLine("ingrese un numero:");
            numero = int.Parse(Console.ReadLine());
            parte1_ejercicio1(numero);

            Console.WriteLine("ingrese su nombre:");
            nombre = Console.ReadLine();
            parte1_ejercicio2(nombre);

            Console.WriteLine("ingrese el primer numero para comparar:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero para comparar");
            numero2 = int.Parse(Console.ReadLine());
            parte1_ejercicio3(numero1, numero2);

            Console.WriteLine("ingrese el tercer numero para comparar");
            numero3 = int.Parse(Console.ReadLine());
            parte1_ejercicio4(numero1, numero2, numero3);

            Console.WriteLine("ingrese la cantidad de elementos que desea calcular el maximo:");
            dimension = int.Parse(Console.ReadLine()); 
            int[] numeros = new int[dimension];
            for (int i = 0; i < dimension; i++)
            {
                Console.WriteLine("\ningrese un numero:");
                numeros[i]= int.Parse(Console.ReadLine());
            }
            parte1_ejercicio5(numeros);

            int numero_entero1 = 0;
            int numero_entero2 = 0;
            Console.WriteLine("ingrese el primer numero entero :");
            numero_entero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero entero");
            numero_entero2 = int.Parse(Console.ReadLine());
            parte1_ejercicio6(numero_entero1, numero_entero2);
            
            int numero_doble= 0;
            Console.WriteLine("ingrese un numero para calcular el doble: ");
            numero_doble = int.Parse(Console.ReadLine());
            parte1_ejercicio7(numero_doble);
            */



            int numero_doble = int.Parse(Console.ReadLine());
            parte1_ejercicio7(numero_doble);
        }
    }
}