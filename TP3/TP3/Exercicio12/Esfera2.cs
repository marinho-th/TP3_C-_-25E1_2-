﻿using System;

namespace TP3.Exercicio12
{
    public class Esfera2
    {
        public double Raio;

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }
    }
}