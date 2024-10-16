using Ex_4;

 namespace Ex_4
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public double Velocidade { get; set; }

        public Carro(string marca, string modelo, double velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
        }
        public void acelerar()
        {
            Console.WriteLine($"O carro da marca {Marca}, está acelerando há {Velocidade}km/h");
        }

        public void desacelerar()
        {
            Console.WriteLine($"O carro da marca {Marca}, desacelerou 70km/h");
        }
    }
}

