// Exercício 9:

string nome;
double  preço = 0.00;
double acrescimo = 0.00;
int produtos = 0;
double novop  = 0.00;

do
{
    Console.WriteLine("Digite o nome do produto: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o preço atual do produto: ");
    preço = double.Parse(Console.ReadLine());

    acrescimo = (preço * 15) / 100;
    novop = preço + acrescimo;
    Console.WriteLine("O novo preço do produto " + nome + " é R$" + novop);

    Console.WriteLine("Deseja verificar o preço de outro produto?");
    Console.WriteLine("1. sim");
    Console.WriteLine("2. nao");
    produtos = int.Parse(Console.ReadLine());




} while (produtos != 2);


while ()
{
    

}

