using System;

namespace TP3.Exercicio11
{
    public class Circulo1
    {
        public double Raio;

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }

        public static void TesteCirculo()
        {
            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            Circulo1 meuCirculo = new Circulo1();
            meuCirculo.Raio = raio;

            double area = meuCirculo.CalcularArea();
            Console.WriteLine($"Área do círculo: {area:F2}");
        }
    }
}