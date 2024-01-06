using System;

namespace TPfinal_GonzalezNazarenaAraceli
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
             A partir de dichos datos informar:
                    a. El mayor de los números pares.
                    b. La cantidad de números impares.
                    c. El menor de los números primos.
            Nota:evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false
            según corresponda.*/
            int num=1,impar=0,menorPrim=0,mayorPar=0;
            Console.WriteLine("Ingrese un numero ");
            num = int.Parse(Console.ReadLine());
            while (num!=0)
            { 
               if (esUnNumeroPrimo(num))
               {
                    if(menorPrim==0 || num<menorPrim)
                        menorPrim=num;
               }
               if (esUnNumeroPar(num))
               {
                    if(mayorPar==0 || num>mayorPar)
                        mayorPar=num;
               }
               else 
                    impar++;
                Console.WriteLine("Ingrese un numero ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El mayor de los numeros pares es: "+mayorPar);
            Console.WriteLine("La cantidad de numeros impares es: "+impar);
            Console.WriteLine("El menor de los numeros primos es: "+menorPrim);
        }
        static bool esUnNumeroPrimo (int a)
        {
            int i,cont=0;
            for(i=1;i<=a;i++)
            {
                if (a%i==0)
                    cont++;
            }
            if (cont==2)
                return true;
            else 
                return false;
        }
        static bool esUnNumeroPar (int a)
        {
            if (a%2==0)
                return true;
            else 
                return false;
        }
    }
}
