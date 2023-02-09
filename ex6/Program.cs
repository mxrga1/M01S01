Console.WriteLine("Digite um número inteiro: "); //Digite o número que você quer que apareça a tabuada até 10
int num = Convert.ToInt32(Console.ReadLine()); //Variavel que armazena o número

Console.WriteLine("Tabuada de " + num + ":"); //Informa uma mensagem da tabuada do número coletado


//loop de 0 a 10 que a cada interação mostra o valor da multipliação na tela
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(num + " X " + i + " = " + num * i);
}