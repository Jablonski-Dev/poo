namespace _01___heranca
{
    public abstract class fazenda
    {
        public string Nome { get; set; }

        /*método abstrato - não possui implementação aqui
        *mais as classes que herdarem vão precisar implementar*/
        public abstract void EmitirSom();

    }

    public class gato : fazenda
    {
        public override void EmitirSom()
        {
            Console.WriteLine("miau miau");
        }

    }

    public class porco : fazenda
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Oinc Oinc");
        }

    }

    public class capivara : fazenda
    {
        public override void EmitirSom()
        {
            Console.WriteLine("iiiii iiiii");
        }

    }

}
