// Exercício 4:

int num = 0;
int quantidade = 0;
double soma = 0.00;
double media = 0.00;

Console.WriteLine("Digite um valor negativo para sair.");
Console.WriteLine("Os valores positivos seráo somados.");

do
{
    Console.WriteLine("Digite um número para somar: ");
    num = int.Parse(Console.ReadLine());
    if (num > 0)
    {
        soma = soma + num;
        quantidade++;
    }

} while (num>0);
media = soma / quantidade;
Console.WriteLine("A média dos valores digitados é: "+media);
