namespace TP3.Exerc3
{
    public class Ingresso
    {
        public static string nomeDoShow;
        public static double preco;
        public static int quantidadeDisponivel;

        public static void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public static void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public static void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
            Console.WriteLine($"Disponíveis: {quantidadeDisponivel} ingressos");
        }

        
    }
}