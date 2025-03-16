using System;
using TP3.Exerc1;
using TP3.Exerc4;
using TP3.Exerc5;
using TP3.Exerc6;
using TP3.Exerc8;
using TP3.Exerc9;
using TP3.Exercicio11;
using TP3.Exercicio12;

namespace TP3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Exercicio 1:
            Console.WriteLine("Execução do Exercício 1:");
            TP3.Exerc1.Program.MeuLivro();
            Console.WriteLine();
            Console.WriteLine();

            // Exercicio 4:
            Console.WriteLine("Execução do Exercício 4:");
            Ingresso meuIngresso = new Ingresso();

            meuIngresso.nomeDoShow = "Show da minha banda";
            meuIngresso.preco = 100.00;
            meuIngresso.quantidadeDisponivel = 370;
            meuIngresso.AlterarPreco(200.00);
            meuIngresso.AlterarQuantidade(500);
            meuIngresso.ExibirInformacoes();
            Console.WriteLine();
            Console.WriteLine();

            // Exercicio 5:
            Console.WriteLine("Execução do Exercício 5:");
            Ingresso1 meuIngresso1 = new Ingresso1();

            meuIngresso1.SetNomeDoShow("Show da minha banda");
            meuIngresso1.SetPreco(100.00);
            meuIngresso1.SetQuantidadeDisponivel(370);

            Console.WriteLine($"Nome do Show: {meuIngresso1.GetNomeDoShow()}");
            Console.WriteLine($"Preço: R$ {meuIngresso1.GetPreco():F2}");
            Console.WriteLine($"Ingressos disponíveis: {meuIngresso1.GetQuantidadeDisponivel()}");
            meuIngresso1.SetPreco(200.00);
            Console.WriteLine($"Novo preço: R$ {meuIngresso1.GetPreco():F2}");
            Console.WriteLine();
            Console.WriteLine();


            // Exercicio 6:
            Console.WriteLine("Execução do Exercício 6:");
            Ingresso2 meuIngresso2 = new Ingresso2("Show da minha Banda", 200.00, 370); // Usando construtor
            meuIngresso2.ExibirInformacoes();
            Console.WriteLine();
            Console.WriteLine();


            // Exercicio 8:
            Console.WriteLine("Execução do Exercício 8:");
            Matricula1.TesteMatricula();
            Console.WriteLine();
            Console.WriteLine();


            // Exercicio 9:
            Console.WriteLine("Execução do Exercício 9:");
            Matricula2 minhaMatricula2 = new Matricula2();

            minhaMatricula2.NomeDoAluno = "Thiago Marinho";
            minhaMatricula2.Curso = "Eng. Software";
            minhaMatricula2.NumeroMatricula = 1234555;
            minhaMatricula2.Situacao = "Ativa";
            minhaMatricula2.DataInicial = "2023-02-01";

            Console.WriteLine("Informações iniciais:");
            minhaMatricula2.ExibirInformacoes();

            minhaMatricula2.Trancar();
            Console.WriteLine("\nMatrícula trancada:");
            minhaMatricula2.ExibirInformacoes();

            minhaMatricula2.Reativar();
            Console.WriteLine("\nMatrícula reativada:");
            minhaMatricula2.ExibirInformacoes();
            Console.WriteLine();
            Console.WriteLine();

            // Exercicio 11:
            Console.WriteLine("Execução do Exercício 11:");
            Circulo1.TesteCirculo();
            Esfera1.TesteEsfera();
            Console.WriteLine();
            Console.WriteLine();


            // Exercicio 12:
            Console.WriteLine("Execução do Exercício 12:");
            Circulo2 meuCirculo2 = new Circulo2();
            meuCirculo2.Raio = 3.0;
            double areaCirculo2 = meuCirculo2.CalcularArea();
            Console.WriteLine($"Área do círculo: {areaCirculo2:F2}");

            Esfera2 minhaEsfera2 = new Esfera2();
            minhaEsfera2.Raio = 5.0;
            double volumeEsfera2 = minhaEsfera2.CalcularVolume();
            Console.WriteLine($"Volume da esfera: {volumeEsfera2:F2}");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}