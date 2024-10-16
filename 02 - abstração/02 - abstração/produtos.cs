namespace _02___abstração
{
    public class Produtos
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Estoque { get; set; }

        /*é necessario um metodo construtor para acessar as propriedades*/

        public Produtos(int codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        //metodo estoque
        public void estoque()
        {
            Console.WriteLine($"O seu estoque é {Estoque}");
        }
    }
}



