namespace Ex05_Funcionarios
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public void Envelhecer (int anos)
        {
            Idade += anos;
        }

        public void juventude(int anos)
        {
            Idade -= anos;
        }

    }

    public class Funcionario : Pessoa 
    {

    }
}
