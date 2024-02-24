using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 1;
        int numero = 0;

        Console.WriteLine("Los primeros 5 números pares son:");

        while (contador <= 5)
        {
            numero += 2;
            Console.WriteLine(numero);
            contador++;
        }


        //2

        static void Main(string[] args)
        {
            int suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                suma += i;
            }

            Console.WriteLine("La suma de los primeros 10 números naturales es: " + suma);
        }


        //3


        static void Main(string[] args)
        {
            int numero;
            int suma = 0;

            do
            {
                Console.Write("Ingrese un número entero positivo (o un número negativo para terminar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    suma += numero;
                }
            } while (numero >= 0);

            Console.WriteLine("La suma de los números positivos ingresados es: " + suma);
        }

        //4

        static void Main(string[] args)
        {
            string contraseñaCorrecta = "Jutiapa"; // Contraseña correcta
            string contraseñaIngresada;

            do
            {
                Console.Write("Ingrese la contraseña: ");
                contraseñaIngresada = Console.ReadLine();

                if (contraseñaIngresada != contraseñaCorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta. Inténtelo de nuevo.");
                }

            } while (contraseñaIngresada != contraseñaCorrecta);

            Console.WriteLine("¡Contraseña correcta! Bienvenido.");
        }



    }
}