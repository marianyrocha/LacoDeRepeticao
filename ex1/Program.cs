// Exercício 1: 

int n = 0;
int quantidade = 0;

for (int i =1; i<=30; i++)
{   
    Console.WriteLine("Digite um número: ");
    n = int.Parse(Console.ReadLine());
    
    if (n > 100)
    {
        quantidade++;
    }
}Console.WriteLine("Quantidade de números maior que 100: "+quantidade);

