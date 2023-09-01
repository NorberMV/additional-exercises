namespace exercise_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Area (Triangulo Rectángulo / Cuadrado / Circulo)");

        
        Console.WriteLine("\n\n1 - Calculadora area Triángulo Rectángulo ***");
        float areaTriangulo = CalcularAreaTriangulo();
        Console.WriteLine("\n\n2 - Calculadora area Cuadrado ***");
        float areaCuadrado = CalcularAreaCuadrado();
        Console.WriteLine("\n\n3 - Calculadora area Círculo ***");
        float areaCirculo = CalcularAreaCirculo();

        MaxArea(areaTriangulo, areaCuadrado, areaCirculo);

    }

    static void MaxArea(float areaTriangulo, float areaCuadrado, float areaCirculo) {
        // write the logic
        float maxArea = areaTriangulo;
        string figura;

        if (areaTriangulo >= areaCuadrado && areaTriangulo >= areaCirculo) {
            maxArea = areaTriangulo;
            figura = "Triangulo";
        }

        else if (areaCuadrado >= areaTriangulo && areaCuadrado >= areaCirculo) {
            maxArea = areaCuadrado;
            figura = "Cuadraddo";
        }
        else {
            maxArea = areaCirculo;
            figura = "Circulo";
        }

        Console.WriteLine($"El mayor area es la del {figura}: {maxArea} m2");

    }



    static float CalcularAreaTriangulo()
    {
        Console.WriteLine("Ingrese la base del triángulo en [m]: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triángulo en [m]: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine($"El área del triángulo es: {areaTriangulo} m^2");
        return areaTriangulo;
    }

    static float CalcularAreaCuadrado()
    {
        Console.WriteLine("Ingrese la medida del lado del cuadrado:");
        double ladoCuadrado = double.Parse(Console.ReadLine());

        double areaCuadrado = ladoCuadrado * ladoCuadrado;
        Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
        return areaCuadrado;
    }

    static float CalcularAreaCirculo()
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radioCirculo = double.Parse(Console.ReadLine());

        double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
        Console.WriteLine($"El área del círculo es: {areaCirculo}");
        return areaCirculo;
    }
}



