// See https://aka.ms/new-console-template for more information

string nome;
int idade;
char sexo;
string profissao;
double salario;

//Solicitação dos valores

Console.WriteLine("Digite os seus dados");

Console.Write("Nome: ");
nome = Console.ReadLine();

Console.Write("Idade: ");
idade = Convert.ToInt32( Console.ReadLine() );

Console.Write("Sexo: ");
sexo = Console.ReadLine()[0];

Console.Write("Profissão: ");
profissao =  Console.ReadLine();

Console.Write("Salário: ");
salario = Convert.ToDouble (Console.ReadLine());

// Exibição na tela
Console.WriteLine("\nOlá, "  + nome +" . segue abaixo os seus dados.");
Console.WriteLine("Idade: " + idade + " anos " );
Console.WriteLine("sexo: " + sexo );
Console.WriteLine("profissao: " + profissao);
Console.WriteLine("salario: " + salario);