namespace exercise_2;

class Program
{
    static void Main(string[] args)
    {
        int numero1;
        int numero2;

        Console.WriteLine("Este programa dados dos números diferentes, determina cuál" + 
        "es el mayor entre los dos. El programa revisa la posibilidad de que " + 
        "sean iguales y si es así, imprime un mensaje notificándolo.\n\n");
        Console.Write("Ingrese el primer número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2){
            Console.WriteLine($"El primer número {numero1} es mayor.");
        }
        else if (numero2 > numero1){
            Console.WriteLine($"El segundo número {numero2} es mayor.");
        }
        else {
            Console.WriteLine($"Ambos números {numero1} y {numero2} son iguales.");
        }
    }
}
