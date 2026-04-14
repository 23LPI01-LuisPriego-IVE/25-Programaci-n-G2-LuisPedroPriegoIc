internal class Program
{
    private static void Main(string[] args)
    {
        char op;

        Console.Write("Ingrese un carácter: ");
        op = Console.ReadLine().ToUpper()[0];

        switch (op)
        {
 
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Es una vocal");
                break;

            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Es un dígito");
                break;

            default:
                Console.WriteLine("Es otro tipo de carácter");
                break;
        }
    }
}