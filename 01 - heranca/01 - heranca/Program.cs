
using _01___heranca;
using Ex_7;
/*exemplo1*/
//Cachorro cachorro = new Cachorro
//{
//    Nome = "Noah Biju da Silva",
//    Idade = 3,
//    TipoAlimento = "Carnivoro",
//    Raca = "Lulu da Pomerania",
//    BuscaObjetos = true
//};

//Console.WriteLine($"Nome: {cachorro.Nome},\nIdade: {cachorro.Idade},\nAlimentação: {cachorro.TipoAlimento},\nRaça: {cachorro.Raca},\nBusca obejetos? {cachorro.BuscaObjetos}");
//Console.ReadKey();

/*atv2*/
//gato gato = new gato
//{
//    Nome = "jablonski"
//};

//porco porco = new porco
//{
//    Nome = "Silva"
//};

//capivara capivara = new capivara
//{
//    Nome = "Felipe"

//};

//Console.WriteLine($"Gato: {gato.Nome}");
//gato.EmitirSom();
//Console.WriteLine($"\nPorco: {porco.Nome}");
//porco.EmitirSom();
//Console.WriteLine($"\nCapivara: {capivara.Nome}");
//capivara.EmitirSom();


//Console.ReadKey();

/*atv3*/
using Ex_7;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "INTER",
    Agencia = 4321,
    Conta = 11111,
    Saldo = 500,
    Limite = 3000,
};
ContaCorrente conta2 = new ContaCorrente
{
    Banco = "NUBANK",
    Agencia = 1234,
    Conta = 76543,
    Saldo = 200,
    Limite = 2500,
};
ContaCorrente conta3 = new ContaCorrente
{
    Banco = "BRADESCO",
    Agencia = 9876,
    Conta = 64545,
    Saldo = 2000,
    Limite = 8000,
};
Console.WriteLine($"\nO Banco é: {conta1.Banco}, sua agencia é: {conta1.Agencia}, sua conta é: {conta1.Conta}, seu saldo é de: {conta1.Saldo}, seu limite é de: {conta1.Limite}.");
conta1.Depositar(200);
conta1.Sacar(300);
Console.WriteLine($"\nO Banco é: {conta2.Banco}, sua agencia é: {conta2.Agencia}, sua conta é: {conta2.Conta}, seu saldo é de: {conta2.Saldo}, seu limite é de: {conta2.Limite}.");
conta2.Depositar(200);
conta2.Sacar(300);
Console.WriteLine($"\nO Banco é: {conta3.Banco}, sua agencia é: {conta3.Agencia}, sua conta é: {conta3.Conta}, seu saldo é de: {conta3.Saldo}, seu limite é de: {conta3.Limite}.");
conta3.Depositar(2900);
conta3.Sacar(2300);

Console.ReadKey();