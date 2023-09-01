namespace exercise_1;

using System;


    class Program
    {
        static void Main(string[] args)
        { // Programa que recibe tres edades (int) y calcula la edad mayor
            int edad_1;
            int edad_2;
            int edad_3;
            int edad_mayor;

            Console.Write("Ingrese la edad del primer perro: ");
            edad_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la edad del segundo perro: ");
            edad_2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la edad del tercer perro: ");
            edad_3 = Convert.ToInt32(Console.ReadLine());

            edad_mayor = CalcularMayor(edad_1, edad_2, edad_3);

            Console.WriteLine($"La edad del mayor perro es: {edad_mayor} años");
        }

        static int CalcularMayor(int num1, int num2, int num3) {
            // Determinar el mayor numero
            if (num1 >= num2 && num1 >= num3) {
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3) {
                return num2;
            }
            else {
                return num3;
            }
        }
    }


