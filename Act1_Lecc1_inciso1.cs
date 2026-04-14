internal class Program
{
    private static void Main(string[] args)
    {
        int op;
        double grados, radianes, resultado;

        Console.WriteLine("Calculadora de funciones trigonométricas");
        Console.Write("Ingrese el ángulo: ");
        grados = double.Parse(Console.ReadLine());

        // Conversión a radianes
        radianes = grados * (Math.PI / 180);

        Console.WriteLine("***************************************************");
        Console.WriteLine("* Lista de funciones trigonometricas              *");
        Console.WriteLine("* 1- Seno                                         *");
        Console.WriteLine("* 2- Coseno                                       *");
        Console.WriteLine("* 3- Tangente                                     *");
        Console.WriteLine("***************************************************");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                resultado = Math.Sin(radianes);
                Console.WriteLine("El Seno es: " + resultado);
                break;

            case 2:
                resultado = Math.Cos(radianes);
                Console.WriteLine("El Coseno es: " + resultado);
                break;

            case 3:
                resultado = Math.Tan(radianes);
                Console.WriteLine("La Tangente es: " + resultado);
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}