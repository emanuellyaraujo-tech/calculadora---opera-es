namespace git_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número:");
                int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine("resultado: " + resultado);
        }
    }
}
