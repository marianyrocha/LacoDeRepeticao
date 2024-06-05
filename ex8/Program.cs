// Exercício 8:

int nota1 = 0;
int nota2 = 0;
int alunos = 0;
double media =  0.00;

while (alunos != 2)
{
    Console.WriteLine("Digite a primeira nota: ");
    nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota: ");
    nota2 = int.Parse(Console.ReadLine());

    media = (nota1 + nota2) / 2;

    if(media>=0.0 && media < 5.0)
    {
        Console.WriteLine("reprovado");
    }
    else
    {
        if(media >= 5.0 && media < 7.0)
        {
            Console.WriteLine("exame");
        }
        else
        {
            Console.WriteLine("aprovado");
        }
    }

    Console.WriteLine("Deseja verificar outra nota?");
    Console.WriteLine("1. sim");
    Console.WriteLine("2. não");
    alunos = int.Parse(Console.ReadLine());
}