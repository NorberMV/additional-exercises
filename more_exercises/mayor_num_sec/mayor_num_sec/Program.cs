internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dada una secuencia de números, imprime el mayor número.\n");
        Console.Write("Ingrese una lista de numeros separados por un espacio ' '. (Ejemplo: 1 2 3 4 5 6 7 8) : ");

        string serie = Console.ReadLine();
        Console.Write($"La lista ingresada fue: [{serie}]\n");

        // split that string
        string[] splittedText = serie.Split(' ');
        // Max Reference
        int maxRef = 0;

        for (int i = 0; i < splittedText.Length; i++)
        {
            if (int.TryParse(splittedText[i], out int num))
            {
                if(num > maxRef)
                {
                    maxRef = num;
                }
            }
        }
        Console.Write($"El mayor número de la lista fue: {maxRef}");



        //Console.Write(String.Join(", ", splittedText));

    }
}