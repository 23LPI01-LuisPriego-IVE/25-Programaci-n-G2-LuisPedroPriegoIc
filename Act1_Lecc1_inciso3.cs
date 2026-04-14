internal class Program
{
    private static void Main(string[] args)
    {
        int op, tipoPrecio, cantidad;
        double precio = 0, total;

        Console.WriteLine("Estadio Doroteo Guamuch Flores");
        Console.WriteLine("1. Palco (Q300)");
        Console.WriteLine("2. Tribuna (Q100 o Q125)");
        Console.WriteLine("3. Preferencia (Q50 o Q75)");
        Console.WriteLine("4. Generales (Q30 o Q50)");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                precio = 300;
                break;

            case 2:
                Console.WriteLine("Seleccione: 1. Q100 | 2. Q125");
                tipoPrecio = int.Parse(Console.ReadLine());
                switch (tipoPrecio)
                {
                    case 1: precio = 100; break;
                    case 2: precio = 125; break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }
                break;

            case 3:
                Console.WriteLine("Seleccione: 1. Q50 | 2. Q75");
                tipoPrecio = int.Parse(Console.ReadLine());
                switch (tipoPrecio)
                {
                    case 1: precio = 50; break;
                    case 2: precio = 75; break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }
                break;

            case 4:
                Console.WriteLine("Seleccione: 1. Q30 | 2. Q50");
                tipoPrecio = int.Parse(Console.ReadLine());
                switch (tipoPrecio)
                {
                    case 1: precio = 30; break;
                    case 2: precio = 50; break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

       
        Console.Write("Cantidad de entradas: ");
        cantidad = int.Parse(Console.ReadLine());

        total = precio * cantidad;

        Console.WriteLine("Total a pagar: Q" + total);
    }
}