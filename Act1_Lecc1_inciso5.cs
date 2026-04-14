internal class Program
{
    private static void Main(string[] args)
    {
        int cant, forma;
        double precioConIva, totalSinDesc, desc, total;
        string nombre;

        precioConIva = 650 * 1.12;

        Console.Write("Cantidad de impresoras a comprar: ");
        cant = int.Parse(Console.ReadLine());

        totalSinDesc = precioConIva * cant;

        Console.WriteLine("Seleccione forma de pago:");
        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Tarjeta de credito");
        Console.WriteLine("3. Vale de regalo");
        forma = int.Parse(Console.ReadLine());

        switch (forma)
        {
            case 1:
                nombre = "Efectivo";
                desc = totalSinDesc * 0.10;
                break;

            case 2:
                nombre = "Tarjeta de credito";
                desc = totalSinDesc * 0.05;
                break;

            case 3:
                nombre = "Vale de regalo";
                desc = totalSinDesc * 0.15;
                break;

            default:
                nombre = "No valido";
                desc = 0;
                break;
        }

        total = totalSinDesc - desc;

        Console.WriteLine("\nDetalle del Pago:");
        Console.WriteLine("Cantidad: " + cant);
        Console.WriteLine("Precio Unitario (con IVA): Q" + precioConIva);
        Console.WriteLine("Total sin descuento: Q" + totalSinDesc);
        Console.WriteLine("Forma de pago: " + nombre);
        Console.WriteLine("Descuento realizado: Q" + desc);
        Console.WriteLine("Total a Pagar: Q" + total);
    }
}
