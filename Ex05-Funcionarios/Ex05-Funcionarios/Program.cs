using Ex05_Funcionarios;

//instanciando a classe funcionario
Funcionario func1 = new Funcionario { Nome = "Rafael", Idade = 30 };

//chamando o metodo envelhecer
func1.Envelhecer(10);//somar a idade que você passou para a variavelfunc1 mais 10

func1.juventude(12);

//exibindo as informaçoes dos funcionarios
Console.WriteLine($"Nome: {func1.Nome}, Idade: {func1.Idade}");

//instanciando a classe funcionario
Funcionario func2 = new Funcionario { Nome = "Pedro x-tudo", Idade = 25 };

//chamando o metodo envelhecer
func2.Envelhecer(15);//somar a idade que você passou para a variavelfunc1 mais 10

func2.juventude(22);

//exibindo as informaçoes dos funcionarios
Console.WriteLine($"Nome: {func2.Nome}, Idade: {func2.Idade}");

//instanciando a classe funcionario
Funcionario func3 = new Funcionario { Nome = "Vini porpeta", Idade = 45 };

//chamando o metodo envelhecer
func3.Envelhecer(50);//somar a idade que você passou para a variavelfunc1 mais 10

func3.juventude(30);

//exibindo as informaçoes dos funcionarios
Console.WriteLine($"Nome: {func3.Nome}, Idade: {func3.Idade}");

Console.WriteLine("Pressiona qualquer tecla para encerrar");
Console.ReadKey();
