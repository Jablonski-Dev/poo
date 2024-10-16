namespace Ex_7
{
    public class ContaGenerica
    {
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public decimal Saldo { get; set; }

        public decimal valor { get; set; }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso. Novo saldo: R${Saldo}");
            }
            else
            {
                Console.WriteLine($"O valor do depósito deve ser positivo");
            }
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso. Novo saldo: R${Saldo - valor}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }

        }
    }
    class ContaCorrente : ContaGenerica
    {
        public decimal Limite { get; set; }

        public override void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= (Saldo + Limite))
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso. Saldo restante: R${Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
