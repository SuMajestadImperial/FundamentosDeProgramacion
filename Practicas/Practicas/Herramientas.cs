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
            Console.WriteLine("Que rellene un array con los 100 primeros números enteros y los muestre en pantalla en orden ascendente.");
            Console.WriteLine("Ingrese el numero de posiciones que desea");
            Posiciones = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] numeros = new int[Posiciones];
            for (int i = 0; i < Posiciones; i++)
            {
                numeros[i] = i+1;
            }
            for (int i = 0; i < Posiciones; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio10()
        {
            int Posiciones;
            Console.WriteLine("Elegiste el Ejercicio No.10");
            Console.WriteLine("");
            Console.WriteLine("Que rellene un array con los 100 primeros números enteros y los muestre en pantalla en orden descendente.");
            Console.WriteLine("Ingrese el numero de posiciones que desea");
            Posiciones = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] numeros = new int[Posiciones];
            for (int i = 0; i<Posiciones; i++)
            {
                numeros[i] = i+1; 
            }
            for (int i = Posiciones-1; i >-1 ; i--)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio11()
        {
            int Posiciones;
            Console.WriteLine("Elegiste el Ejercicio No.11");
            Console.WriteLine("");
            Console.WriteLine("Que lea 10 números por teclado, los almacene en un array y muestre la suma, resta, multiplicación y división de todos.");
            Console.WriteLine("Ingrese el numero de posiciones que desea");
            Posiciones = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] numeros = new int[Posiciones];
            decimal suma, resta, division, multiplicacion,error1;
            Console.WriteLine("Ingrese los numeros");
            for (int i = 0; i < Posiciones; i++)
            {
                int y = int.Parse(Console.ReadLine());
                numeros[i] = y;
            }
            suma = numeros[0];
            resta = numeros[0];
            division = numeros[0];
            multiplicacion = numeros[0];
            error1 = numeros[0];
            string error = "Syntax Error";
            for (int i = 1; i < Posiciones; i++)
            {
                suma = suma + numeros[i];
                resta = resta - numeros[i];
                if (numeros[i] == 0)
                {
                    error1 = 1000;
                }
                else
                {
                    division = division / numeros[i];
                }
                multiplicacion = multiplicacion * numeros[i];
            }

            Console.WriteLine("La suma de los numeros ingresados es  " + suma);
            Console.WriteLine("La resta de los numeros ingresados es  " + resta);
            if ( error1 == 1000)
            {
                Console.WriteLine("La division de los numeros ingresados es  " + error);
            }
            else
            {
                Console.WriteLine("La division de los numeros ingresados es  " + division);
            }
            Console.WriteLine("La multiplicacion de los numeros ingresados es  " + multiplicacion);
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio12()
        {
            int a,b=0,c=0,d;
            Console.WriteLine("Elegiste el Ejercicio No.12");
            Console.WriteLine("");
            Console.WriteLine("Sumar los números enteros de 1 a 100");
            do
            {
                Console.WriteLine("Que metodo desea utilizar");
                Console.WriteLine("a) Do/While         --> 1");
                Console.WriteLine("b) While            --> 2");
                Console.WriteLine("c) For              --> 3");
                Console.WriteLine("No desea continuar  --> 4");
                a = int.Parse(Console.ReadLine());
                do
                {
                    if (a < 1 || a > 4)
                    {
                        Console.WriteLine("Numero no valido, vuelve a escribir un numero dentro del rango");
                        a = int.Parse(Console.ReadLine());
                    }
                } while (a < 1 || a > 4);

                Console.WriteLine("");

                switch (a)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Eligio el metodo de Do/While");
                        Console.WriteLine("");
                        Console.WriteLine("Hasta que numero desea llegar");
                        d = int.Parse(Console.ReadLine());
                        do
                        {
                            b = b + 1;
                            c = c + b;
                        } while (b < d);
                        Console.WriteLine("La suma de los 100 primeros numeros es   " + c);
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Eligio el metodo de While");
                        Console.WriteLine("");
                        Console.WriteLine("Hasta que numero desea llegar");
                        d = int.Parse(Console.ReadLine());
                        while (b<d)
                        {
                            b = b + 1;
                            c = c + b;
                        }
                        Console.WriteLine("La suma de los 100 primeros numeros es   " + c);
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Eligio el metodo de For");
                        Console.WriteLine("");
                        Console.WriteLine("Hasta que numero desea llegar");
                        d = int.Parse(Console.ReadLine());
                        for (int e=0;e<d+1;e++) 
                        {
                            c = c + e;
                        }
                        Console.WriteLine("La suma de los 100 primeros numeros es   " + c);
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Presione Enter para regresar al menu");
                Console.ReadKey();
            } while (a==4);
        }
        public static void Ejercicio13()
        {
            decimal f,h,i=0;
            Console.WriteLine("Elegiste el Ejercicio No.13");
            Console.WriteLine("");
            Console.WriteLine("Se desea leer las calificaciones de una clase de informática y contar el número total de aprobados");
            Console.WriteLine("Cuantos alumnos hay en la clase de informatica");
            f = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escriba las calificaciones");
            for(int g=0;g<f;g++)
            {
                h = decimal.Parse(Console.ReadLine());
                if (h >= 5) 
                {
                    i = i + 1;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Hay  "+i+"  alumnos aprobados");
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio14()
        {
            int f, h, i=0;
            Console.WriteLine("Elegiste el Ejercicio No.14");
            Console.WriteLine("");
            Console.WriteLine("Se pretende leer todos los empleados de una empresa y a la terminación de la lectura se debe visualizar un mensaje");
            Console.WriteLine("«existen trabajadores mayores de 65 años en un número de ...» y el número de trabajadores mayores de 65 años.");
            Console.WriteLine("Cuantos empleados hay en la empresa");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba las edades de los empreados");
            for (int g = 0; g < f; g++)
            {
                h = int.Parse(Console.ReadLine());
                if (h > 65)
                {
                    i = i + 1;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("En la empresa hay  "+i+"  empleados que tienen mas de 65 años");
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
        public static void Ejercicio15()
        {
            int f, h, i=0,j=0,k=0;
            Console.WriteLine("Elegiste el Ejercicio No.15");
            Console.WriteLine("");
            Console.WriteLine("Se desea conocer una serie de datos de una empresa con 50 empleados ¿Cuántos empleados ganan:");
            Console.WriteLine("a) Más de 300.000 pesetas al mes(salarios altos)");
            Console.WriteLine("b) Entre 100.000 y 300.000 pesetas(salarios medios");
            Console.WriteLine("c) Menos de 100.000 pesetas(salarios bajos y empleados a tiempo parcial");
            Console.WriteLine("Cuantos empleados hay en la empresa");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el salario de los empreados");
            for (int g = 0; g < f; g++)
            {
                h = int.Parse(Console.ReadLine());
                if (h > 300000)
                {
                    i = i + 1;
                }
                if (h >=100000 || h<=300000)
                {
                    j = j + 1;
                }
                if (h < 100000)
                {
                    k = k + 1;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("En la empresa hay  " + i + "  empleados que ganan mas de 300.000 pesetas");
            Console.WriteLine("En la empresa hay  " + j + "  empleados que ganan entre 100.000 y 300.000 pesetas");
            Console.WriteLine("En la empresa hay  " + k + "  empleados que ganan menos de 100.000");
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
            
        }
        public static void Ejercicio16()
        {
            decimal f, g, c=0, d=0;
            
            Console.WriteLine("Elegiste el Ejercicio No.16");
            Console.WriteLine("");
            Console.WriteLine("Se dispone de un cierto número de valores de los cuales el último es el 999 y se desea ");
            Console.WriteLine("determinar el valor máximo de las medias correspondientes a parejas de valores sucesivos.");
            Console.WriteLine("Ingrese el valor del primer valor");
            Console.WriteLine("");
            for(int e=1;e<999;e++)
            {
                f = e;
                g = e+1;
                c = (f+g)/2;
                if(c>=d)
                {
                    d=c;
                }
            }
            Console.WriteLine("La media maxima es  " + d);
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para regresar al menu");
            Console.ReadKey();
        }
    }
}