// Exercício 2:

int num = 0;
int quantidade = 0;

for(int i = 1; i<=10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 3 == 0)
    {
        quantidade++;
    }
}
Console.WriteLine("Quantidade de números múltiplos de 3: "+quantidade);