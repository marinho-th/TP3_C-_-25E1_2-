using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exerc1
{
    public class Livro
    {
        
        public string Titulo;
        public string Autor;
        public int Paginas;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Exercício 1:");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Páginas: {Paginas}");
        }
    }

    public class Program
    {
        public static void MeuLivro()
        {
            
            Livro meuLivro = new Livro();

           
            meuLivro.Titulo = "O carteiro de Neruda";
            meuLivro.Autor = "Antonio Skarmeta";
            meuLivro.Paginas = 200;

            meuLivro.ExibirDetalhes();
        }
    }
}
