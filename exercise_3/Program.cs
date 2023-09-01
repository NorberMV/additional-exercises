namespace exercise_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Area (Triangulo Rectángulo / Cuadrado / Circulo)");

        
        Console.WriteLine("\n\n1 - Calculadora area Triángulo Rectángulo ***");
        double areaTriangulo = CalcularAreaTriangulo();
        Console.WriteLine("\n\n2 - Calculadora area Cuadrado ***");
        double areaCuadrado = CalcularAreaCuadrado();
        Console.WriteLine("\n\n3 - Calculadora area Círculo ***");
        double areaCirculo = CalcularAreaCirculo();

        MaxArea(areaTriangulo, areaCuadrado, areaCirculo);

    }

    static void MaxArea(double areaTriangulo, double areaCuadrado, double areaCirculo) {
        // write the logic
        double maxArea = areaTriangulo;
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

        Console.WriteLine($"\n\nLa mayor area de todas las figuras es la del {figura}: {maxArea:F3} m2");

    }



    static double CalcularAreaTriangulo()
    {
        Console.Write("Ingrese la base del triángulo en [m]: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo en [m]: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine($"El área del triángulo es: {areaTriangulo} m^2");
        return areaTriangulo;
    }

    static double CalcularAreaCuadrado()
    {
        Console.Write("Ingrese la medida del lado del cuadrado en [m] : ");
        double ladoCuadrado = double.Parse(Console.ReadLine());

        double areaCuadrado = ladoCuadrado * ladoCuadrado;
        Console.WriteLine($"El área del cuadrado es: {areaCuadrado} m^2");
        return areaCuadrado;
    }

    static double CalcularAreaCirculo()
    {
        Console.Write("Ingrese el radio del círculo en [m]: ");
        double radioCirculo = double.Parse(Console.ReadLine());

        double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
        Console.WriteLine($"El área del círculo es: {areaCirculo:F3} m^2");
        return areaCirculo;
    }
}



