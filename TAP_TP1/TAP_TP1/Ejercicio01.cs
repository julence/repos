using System;

namespace TAP_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4 = 0;

            float prom = 0;

            PedirNotas(out nota1, out nota2, out nota3, out nota4);

            prom = CalcularPromedio(nota1, nota2, nota3, nota4);

            MostrarPromedio(prom);

            Console.ReadKey();
        }
        
        private static void PedirNotas(out int nota1, out int nota2, out int nota3, out int nota4)
        {
            Console.WriteLine("Ingrese cada nota y luego presione <enter> ");
            Console.WriteLine();
            Console.WriteLine("Primera nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuarta nota: ");
            nota4 = int.Parse(Console.ReadLine());
        }
        
        private static float CalcularPromedio(int nota1, int nota2, int nota3, int nota4)
        {
            return (float)(nota1 + nota2 + nota3 + nota4) / (float)4;
        }
        
        private static void MostrarPromedio(float promedio)
        {
            Console.WriteLine("El promedio es de " + promedio);
        }
    }
}
