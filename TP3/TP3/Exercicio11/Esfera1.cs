using System;

namespace TP3.Exercicio11
{
    public class Esfera1
    {
        public double Raio;

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }

        public static void TesteEsfera()
        {
            Console.Write("Informe o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            Esfera1 minhaEsfera = new Esfera1();
            minhaEsfera.Raio = raio;

            double volume = minhaEsfera.CalcularVolume();
            Console.WriteLine($"Volume da esfera: {volume:F2}");
        }
    }
}