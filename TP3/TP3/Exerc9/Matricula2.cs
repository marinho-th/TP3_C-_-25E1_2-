﻿namespace TP3.Exerc9
{
    public class Matricula2
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;
        public string DataInicial;

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do Aluno: {NomeDoAluno}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Situação: {Situacao}");
            Console.WriteLine($"Data Inicial: {DataInicial}");
        }
    }
}