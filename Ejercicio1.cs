internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dias de la Semana");
        Console.WriteLine("Ingrese un numero del 1 al 7:");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1: Console.WriteLine("Lunes"); break;
            case 2: Console.WriteLine("Martes"); break;
            case 3: Console.WriteLine("Miercoles"); break;
            case 4: Console.WriteLine("Jueves"); break;
            case 5: Console.WriteLine("Viernes"); break;
            case 6: Console.WriteLine("Sabado"); break;
            case 7: Console.WriteLine("Domingo"); break;
            default: Console.WriteLine("Número incorrecto debe ser entre 1 y 7."); break;
        }
    }
}