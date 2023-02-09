
//Variaveis do tipo int
int n1 = 0; 
int n2 = 1; 
int n3;
int count = 20;


Console.WriteLine("Os primeiros 20 números da sequência de Fibonacci são:"); //Exibe uma mensagem "Os primeiros 20 números da sequência de Fibonacci são:"
Console.WriteLine(n1); //exibe a variavel n1
Console.WriteLine(n2); //exibe a variavel n2

//Faz um loop começando em 2 e vai repetindo enquanto i for menor que a variavel count
for (int i = 2; i < count; i++)
{
    n3 = n1 + n2;
    Console.WriteLine(n3);
    n1 = n2;
    n2 = n3;
}

Console.ReadLine(); 