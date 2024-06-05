// Exercício 6:

int n  = 0;
int soma = 0;

Console.WriteLine("Digite 0 para sair.");

do
{
    Console.WriteLine("Digite um número negativo para somar: ");
    n = int.Parse(Console.ReadLine());

    if (n < 0)
    {
        soma = soma + n;
    }


} while (n!=0);

Console.WriteLine("O total da soma dos números negativos é: "+soma);