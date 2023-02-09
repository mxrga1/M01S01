Console.WriteLine("Informe o comprimento do lado 1:"); //Pergunta o comprimento do lado1
double lado1 = Convert.ToDouble(Console.ReadLine()); //Armazera o comprimento do lado1 em uma variavel

Console.WriteLine("Informe o comprimento do lado 2:"); //Pergunta o comprimento do lado2
double lado2 = Convert.ToDouble(Console.ReadLine());  //Armazera o comprimento do lado2 em uma variavel

Console.WriteLine("Informe o comprimento do lado 3:"); //Pergunta o comprimento do lado3
double lado3 = Convert.ToDouble(Console.ReadLine());  //Armazera o comprimento do lado3 em uma variavel



//O código a seguir verifica se as medidas informadas formam um triângulo, usando a condição "lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2".
//Se o primeiro lado é igual ao segundo e o segundo é igual ao terceiro, o triângulo é considerado equilátero.
//Se dois lados são iguais e o terceiro é diferente, o triângulo é considerado isósceles.
//Se todos os lados são diferentes, o triângulo é considerado escaleno.
//Se a condição inicial não for verdadeira, a mensagem "As medidas informadas não formam um triângulo".
if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}
else
{
    Console.WriteLine("As medidas informadas não formam um triângulo.");
}
