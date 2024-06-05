// Exercício 3:

int num = 0;
int quantidade = 0;
double soma = 0.00;
double media = 0.00;

Console.WriteLine("Digite 0 para sair.");

do
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

   if(num != 0)
    {
        soma = soma + num;
        quantidade++;
    }
   
} while (num!=0);

media = soma/quantidade;
Console.WriteLine("Média dos números digitados: "+media);
