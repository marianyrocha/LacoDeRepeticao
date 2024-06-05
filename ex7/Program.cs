// Exercício 7:

string nome;
int usuarios = 0;
double salario = 0.00;

while (usuarios!=2)
{
    Console.WriteLine("Digite o nome do funcionário: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o valor do salário: ");
    salario = int.Parse(Console.ReadLine());

    if (salario >= 1000)
    {
        Console.WriteLine(nome);
    }

    Console.WriteLine("Deseja cadastrar um novo usuário?");
    Console.WriteLine("1. sim");
    Console.WriteLine("2. não");
    usuarios = int.Parse(Console.ReadLine());

}
