using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Exercicio 1

int idade = 17;
string nome = "Bernardo";

Console.WriteLine($"Olá, meu nome é {nome} e eu tenho " + idade + "anos.");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

// Exercicio 2

int dataNascimento = 2007;
int anoAtual = 2024;

int idadeCalculo = anoAtual - dataNascimento;
Console.WriteLine($"Uma pessoa que nasceu em {dataNascimento} e está vivo até o ano de " + anoAtual + $", ela tem {idadeCalculo} anos.");
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

// Exercicio 3

int n1 = 1500;
int n2 = 2007;
int n3 = 1174;

int mediaSimples = (n1 + n2 + n3) / 3;
Console.WriteLine($"A média simples dos números {n1}, {n2} e {n3} é: {mediaSimples}.");
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

// Exercicio 4

int n4 = 8;
int n5 = 7;
int n6 = 5;
int peso1 = 3;
int peso2 = 4;
int peso3 = 5;
double mediaPonderada = (n4 * peso1 + n5 * peso2 + n6 * peso3) / (peso1 + peso2 + peso3);
Console.WriteLine($"A média ponderada dos números {n4}, {n5}, {n6} com os pesos {peso1}, {peso2}, {peso3} é: " + mediaPonderada);
Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();


// Exercicio 5

Console.Write("Informe o tamanho em metros quadrados da área a ser pintada: ");
double area = Convert.ToDouble(Console.ReadLine());

double litrosNecessarios = area / 3;
double latasNecessarias = Math.Ceiling(litrosNecessarios / 18);
double precoTotal = latasNecessarias * 80;

Console.WriteLine($"Você precisará de {latasNecessarias} latas de tinta.");
Console.WriteLine($"O preço total será de R$ {precoTotal:F2}.");
Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

// Exercicio 6

Console.WriteLine("Olá, qual turno você estuda?");
Console.WriteLine("M - Matutino");
Console.WriteLine("V - Vespertino");
Console.WriteLine("N - Noturno");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "m":
    Console.WriteLine("Bom dia!");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
    break;

    case "v":
    Console.WriteLine("Boa tarde!");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
    break;

    case "n":
    Console.WriteLine("Boa noite!");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
    break;

    default:
    Console.WriteLine("Opção inválida.");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
    break;
}

// Exercicio 7
try
{
    Console.WriteLine("Digite sua idade.");
int idadeExSete = int.Parse(Console.ReadLine());

if (idadeExSete >= 18)
{
    Console.WriteLine("Você é maior de idade.");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}
if (idadeExSete < 18)
{
    Console.WriteLine("Você é menor de idade.");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}
}
catch (FormatException)
{
    Console.WriteLine("Idade inválida. Digite uma idade válida.");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}

// Exercicio 8

Console.WriteLine("Digite um ano para verificar se ele é bissexto.");
int anoBissexto = int.Parse(Console.ReadLine());

bool SimBissexto = (anoBissexto % 4 == 0 && anoBissexto % 100 != 0) || anoBissexto % 400 == 0;
if (SimBissexto)
{
    Console.WriteLine("O ano é bissexto.");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}
else
{
    Console.WriteLine("O ano não é bissexto.");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}

// Exercicio 9

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

// Exercicio 10

int soma = 0;
for (int i = 0; i <= 100; i++)
{
    soma += i;
}
Console.WriteLine("A soma de todos os números de 0 a 100 é: " + soma);
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

// Exercicio 11

long fatorial = 1;
for (int i = 1; i <= 100; i++)
{
    fatorial *= i;
}
Console.WriteLine("O fatorial de 100 é: " + fatorial);
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

// Exercicio 12

string nomeExDoze;
string senhaExDoze;

while (true)
{
    Console.Write("Informe seu nome de usuário: ");
    nomeExDoze = Console.ReadLine();

    Console.Write("Informe sua senha: ");
    senhaExDoze = Console.ReadLine();

    if (nomeExDoze == senhaExDoze)
    {
        Console.WriteLine("Erro: A senha não pode ser igual ao nome de usuário.");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Cadastro realizado com sucesso!");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
        break;
    }
}

// Exercicio 13

for (int i = 1; i <= 50; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

Console.WriteLine("FIM...");