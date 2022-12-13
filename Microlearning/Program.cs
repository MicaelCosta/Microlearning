namespace Microlearning
{
    class Program
    {
        static void Main()
        {
            ExemploOperacaoMatematica();
        }

        static void ExemploOperacaoMatematica()
        {
            Console.Clear();
            Console.WriteLine(" ******************* ");
            Console.WriteLine(" Operação Matematica ");
            Console.WriteLine(" ******************* ");

            var math = new OperacaoMatematica();

            Console.WriteLine($" A soma de 1 + 1 é igual a: {math.Somar(1, 1)} ");
            Console.WriteLine("  ");

            Console.WriteLine($" A subtração de 1 - 1 é igual a: {math.Subtrair(1, 1)} ");
            Console.WriteLine("  ");

            Console.WriteLine($" A multiplicação de 1 * 1 é igual a: {math.Subtrair(1, 1)} ");
            Console.WriteLine("  ");

            Console.WriteLine($" A divisão de 1 / 1 é igual a: {math.Subtrair(1, 1)} ");
            Console.WriteLine("  ");
        }
    }
}