using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    public class Herramientas
    {
        public static void Menu()
        {
            int a;
            do
            {
                Console.WriteLine("Que numero de ejercicio desea elegir");
                Console.WriteLine("");
                Console.WriteLine("Practica No.1");
                Console.WriteLine("Ejercicio 1 --> 1");
                Console.WriteLine("Ejercicio 2 --> 2");
                Console.WriteLine("Ejercicio 3 --> 3");
                Console.WriteLine("Ejercicio 4 --> 4");
                Console.WriteLine("Ejercicio 5 --> 5");
                Console.WriteLine("");
                Console.WriteLine("Ejercicios de clase No.1");
                Console.WriteLine("Ejercicio 6 --> 6");
                Console.WriteLine("Ejercicio 7 --> 7");
                Console.WriteLine("Ejercicio 8 --> 8");
                Console.WriteLine("");
                Console.WriteLine("Ejercicios de clase No.2");
                Console.WriteLine("Ejercicio 9  --> 9");
                Console.WriteLine("Ejercicio 10 --> 10");
                Console.WriteLine("Ejercicio 11 --> 11");
                Console.WriteLine("");
                Console.WriteLine("Practica No.2");
                Console.WriteLine("Ejercicio 12 --> 12");
                Console.WriteLine("Ejercicio 13 --> 13");
                Console.WriteLine("Ejercicio 14 --> 14");
                Console.WriteLine("Ejercicio 15 --> 15");
                Console.WriteLine("Ejercicio 16 --> 16");
                Console.WriteLine("");
                Console.WriteLine("Escriba el numero 17 si no desea continuar");
                a = int.Parse(Console.ReadLine());
                do
                {
                    if (a < 1 || a > 17)
                    {
                        Console.WriteLine("Numero no valido, vuelve a escribir un numero dentro del rango");
                        a = int.Parse(Console.ReadLine());
                    }
                } while (a < 1 || a > 17);

                Console.WriteLine("");

                switch (a)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                    case 5:
                        Ejercicio5();
                        break;
                    case 6:
                        Ejercicio6();
                        break;
                    case 7:
                        Ejercicio7();
                        break;
                    case 8:
                        Ejercicio8();
                        break;
                    case 9:
                        Ejercicio9();
                        break;
                    case 10:
                        Ejercicio10();
                        break;
                    case 11:
                        Ejercicio11();
                        break;
                    case 12:
                        Ejercicio12();
                        break;
                    case 13:
                        Ejercicio13();
                        break;
                    case 14:
                        Ejercicio14();
                        break;
                    case 15:
                        Ejercicio15();
                        break;
                    case 16:
                        Ejercicio16();
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            } while (a != 17);
        }

        public static void Ejercicio1()
        {
            Console.WriteLine("Elegiste el Ejercicio No.1");
            Console.WriteLine("");
            Console.WriteLine("Realizar un programa que lea por teclado dos números, ");
            Console.WriteLine("si el primero es mayor al segundo informar su suma y diferencia, en caso ");
            Console.WriteLine("contrario informar el producto y la división del primero respecto al segundo ");
            decimal b, c, suma, resta, division, multiplicacion;
            Console.WriteLine("Ingrese el valor del primer numero");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero");
            c = decimal.Parse(Console.ReadLine());
            if (b > c)
            {
                suma = b + c;
                resta = b - c;
                Console.WriteLine("La suma de los 2 numeros es  " + suma);
                Console.WriteLine("La resta de los 2 numeros es  " + resta);
            }
            else
            {
                division = b / c;
                multiplicacion = b * c;
                if (c == 0)
                {
                    Console.WriteLine("La division de los 2 numeros es Syntax error");
                    Console.WriteLine("La multiplicacion de los 2 numeros es  " + multiplicacion);
                }
                else
                {
                    Console.WriteLine("La division de los 2 numeros es " + division);
                    Console.WriteLine("La multiplicacion de los 2 numeros es  " + multiplicacion);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio2()
        {
            Console.WriteLine("Elegiste el Ejercicio No.2");
            Console.WriteLine("");
            Console.WriteLine("Se ingresa por teclado un número positivo de uno o dos dígitos (1.99) ");
            Console.WriteLine("mostrar un mensaje indicando si el número tiene uno o dos dígitos.");
            int d;
            Console.WriteLine("Ingrese un numero");
            d = int.Parse(Console.ReadLine());
            if (d < 0)
            {
                do
                {
                    Console.WriteLine("Numero no valido, escriba un numero positivo");
                    d = int.Parse(Console.ReadLine());
                } while (d < 0);
            }
            if (d > 0 && d < 10)
            {
                Console.WriteLine("El numero que ingresate tiene 1 digito");
            }
            else if (d >= 10 && d < 100)
            {
                Console.WriteLine("El numero tiene 2 digitos");
            }
            else if (d >= 100 && d < 1000)
            {
                Console.WriteLine("El numero tiene 3 digitos");
            }
            else if (d >= 1000 && d < 10000)
            {
                Console.WriteLine("El numero tiene 4 digitos");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio3()
        {
            Console.WriteLine("Elegiste el Ejercicio No.3");
            Console.WriteLine("");
            Console.WriteLine("Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar");
            Console.WriteLine("un mensaje en pantalla indicando que debe abonar impuestos de un 16 %.");
            int e;
            double f;
            Console.WriteLine("Ingrese la cantidad de sueldo que recibe");
            e = int.Parse(Console.ReadLine());
            if (e > 3000)
            {
                f = e * 0.16;
                Console.WriteLine("Usted debe abonar impuestos de un 16%");
                Console.WriteLine("El impuesto dado es  $" + f);
                Console.WriteLine("Tu sueldo final es  $" + (e - f));
            }
            else
            {
                Console.WriteLine("Tu sueldo esta libre de impuestos");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio4()
        {
            Console.WriteLine("Elegiste el Ejercicio No.4");
            Console.WriteLine("");
            Console.WriteLine("Realizar un programa que que me indique si un número es par o impar, que muestre un mensaje de salida.");
            int g, h;
            Console.WriteLine("Ingrese un numero");
            g = int.Parse(Console.ReadLine());
            h = (g % 2);
            if (h == 0)
            { 
                Console.WriteLine("El numero que ingreso es un numero par, el numero que ingreso fue  " + g); Console.ReadKey();
            }
            else 
            { 
                Console.WriteLine("El numero que ingreso es un numero impar, el numero que ingreso fue  " + g); Console.ReadKey(); 
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
  
        public static void Ejercicio5()
        {
            Console.WriteLine("Elegiste el Ejercicio No.5");
            Console.WriteLine("");
            Console.WriteLine("Un estacionamiento cobra de la siguiente forma:");
            Console.WriteLine("Menos de 60 min $5.50");
            Console.WriteLine("Por 60 min exacta $6.00");
            Console.WriteLine("Por más de 60 min, se cobrará $6.00 de la primera hora más 0.15 pesos por minuto de exceso");
            int i;
            double j, k, l;
            Console.WriteLine("Ingrese el tiempo que duro estacionado en minutos");
            i = int.Parse(Console.ReadLine());
            if (i < 60) 
            { 
                Console.WriteLine("El total que tendra que pagar es $5.50"); Console.ReadKey();
            }
            else if (i == 60) 
            { 
                Console.WriteLine("El total que tendra que pagar es $6.00"); Console.ReadKey(); 
            }
            else if (i > 60)
            {
                k = i - 60; j = k * .15; l = j + 6;
                Console.WriteLine("El total que tendra que pagar es " + l); Console.ReadKey();
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio6()
        {
            decimal b, c;
            Console.WriteLine("Elegiste el Ejercicio No.6");
            Console.WriteLine("");
            Console.WriteLine("Escribe un programa que pida numeros decimales mientras que el usiario escriba numeros mayores que el primero");
            Console.WriteLine("Ingrese un numero base");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese algun numero");
            c = decimal.Parse(Console.ReadLine());
            while (c < b)
            {
                Console.WriteLine("El numero ingresado es menor que el de base");
                Console.WriteLine("Vuelve a ingresar un numero");
                c = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio7()
        {
            int d, e, f;
            Console.WriteLine("Elegiste el Ejercicio No.7");
            Console.WriteLine("");
            Console.WriteLine("Escribe un programa que escriba las tablas del 2 al 10");
            Console.WriteLine("Que numero de tabla quiere realizar");
            d = int.Parse(Console.ReadLine());
            e = 0;
            for (f = 0; f < 10; f++)
            {
                e = e + 1;
                Console.WriteLine(d + " por " + e + " = " + (d * e));
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio8()
        {
            int usuario = 1024;
            int contraseña = 4567;
            Console.WriteLine("Elegiste el Ejercicio No.8");
            Console.WriteLine("");
            Console.WriteLine("Crear un programa que pida al usuario, su codigo de usuario y su contraseña numerica ");
            Console.WriteLine("y no le permita seguir hasta que introduzca como codigo 1024 y como contraseña 4567");
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese su usuario");
                usuario = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la contraseña");
                contraseña = int.Parse(Console.ReadLine());
                if (usuario != 1024 || contraseña != 4567)
                {
                    Console.WriteLine("El usuario o contraseña que ingreso es incorrecta");
                    Console.WriteLine("Por favor vuelva a ingresar sus datos");
                    Console.WriteLine("");
                }
            } while (usuario != 1024 || contraseña != 4567);
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio9()
        {
            int Posiciones;
            Console.WriteLine("Elegiste el Ejercicio No.9");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el numero de posiciones que desea");
            Posiciones = int.Parse(Console.ReadLine());
            int[] numeros = new int[Posiciones];
            for (int x = 0; x < Posiciones; x++)
            {
                numeros[x] = x + 1;
                Console.WriteLine(numeros[x]);
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio10()
        { }
        public static void Ejercicio11()
        { }
        public static void Ejercicio12()
        { }
        public static void Ejercicio13()
        { }
        public static void Ejercicio14()
        { }
        public static void Ejercicio15()
        { }
        public static void Ejercicio16()
        { }
        public static void Ejercicio17()
        { }
    }
}