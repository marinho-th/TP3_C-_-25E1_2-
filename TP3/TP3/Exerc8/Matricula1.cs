namespace TP3.Exerc8
{
    public class Matricula1
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
            Console.WriteLine($"Situação Atual: {Situacao}");
            Console.WriteLine($"Data Inicial: {DataInicial}");
        }
        //Abaixo criei um método de teste:
        public static void TesteMatricula()
        {
            Matricula1 minhaMatricula = new Matricula1();

            minhaMatricula.NomeDoAluno = "Thiago Marinho";
            minhaMatricula.Curso = "Eng Sogwtare";
            minhaMatricula.NumeroMatricula = 1234555;
            minhaMatricula.Situacao = "Ativa";
            minhaMatricula.DataInicial = "2023-01-15";

            minhaMatricula.ExibirInformacoes();

            minhaMatricula.Trancar();
            Console.WriteLine("\nMatrícula trancada:");
            minhaMatricula.ExibirInformacoes();

            minhaMatricula.Reativar();
            Console.WriteLine("\nMatrícula reativada:");
            minhaMatricula.ExibirInformacoes();
        }
    }
}