namespace _01___heranca
{
    //a classe "animal" é uma classe abstrata que servirá de modelo para outros animais
   
    public abstract class animal
    {
        public string Nome {  get; set; }

        public int Idade { get; set; }

        public string TipoAlimento { get; set; }

        /*método abstrato - não possui implementação aqui
        *mais as classes que herdarem vão precisar implementar*/
        public abstract void EmitirSom();
    }

    //A classe cachorro herda da classe animal
    //Isso significa que o cachorro tera todos os atributos e comportamento de animal.. mas tambem pode ter suas proprias caracteristicas
    public class Cachorro : animal
    {

        public string Raca { get; set; }
        //bool significa booleana, ou seja, espera
        //uma resposta verdadeira ou falsa para o atributo
        public bool BuscaObjetos { get; set; }


        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }

    }
}
