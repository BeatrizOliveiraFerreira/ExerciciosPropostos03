// See httusing System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d= int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
