namespace TP3.Exerc6
{
    public class Ingresso2
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public Ingresso2(string nome, double valor, int quantidade)
        {
            nomeDoShow = nome;
            preco = valor;
            quantidadeDisponivel = quantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
            Console.WriteLine($"Ingressos disponíveis: {quantidadeDisponivel} ");
        }
    }
}