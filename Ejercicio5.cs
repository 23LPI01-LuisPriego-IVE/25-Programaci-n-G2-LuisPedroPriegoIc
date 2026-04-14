




internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número del 1 al 12 para conocer el mes:");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1: Console.WriteLine("Mes: Enero | Días: 31"); break;
            case 2: Console.WriteLine("Mes: Febrero | Días: 28 (o 29 en bisiesto)"); break;
            case 3: Console.WriteLine("Mes: Marzo | Días: 31"); break;
            case 4: Console.WriteLine("Mes: Abril | Días: 30"); break;
            case 5: Console.WriteLine("Mes: Mayo | Días: 31"); break;
            case 6: Console.WriteLine("Mes: Junio | Días: 30"); break;
            case 7: Console.WriteLine("Mes: Julio | Días: 31"); break;
            case 8: Console.WriteLine("Mes: Agosto | Días: 31"); break;
            case 9: Console.WriteLine("Mes: Septiembre | Días: 30"); break;
            case 10: Console.WriteLine("Mes: Octubre | Días: 31"); break;
            case 11: Console.WriteLine("Mes: Noviembre | Días: 30"); break;
            case 12: Console.WriteLine("Mes: Diciembre | Días: 31"); break;
            default: Console.WriteLine("Error: El número ingresado no es válido."); break;
        }
    }
}