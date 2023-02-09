


Console.WriteLine("Insira as três notas do aluno: "); // Pergunta as três notas do aluno




        // Salva o valor das três notas

float nota1 = float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());
float nota3 = float.Parse(Console.ReadLine());

float notaFinal = (nota1 + nota2 + nota3) / 3;  // define a nota final fazendo a soma dos três valores e dividindo pela mesma quantidade

if (notaFinal >= 6)    //Define se o aluno irá ser aprovado
{

   Console.WriteLine("Aluno Aprovado com a média " + notaFinal);   

}
else if (notaFinal >= 5 && notaFinal < 6)          //Define se o aluno irá ficar em recuperação

{
Console.WriteLine("Aluno em recuperação com média " + notaFinal);
}
 

 else if ( notaFinal < 5)           //Define se o aluno irá ser reprovado

 {
   Console.WriteLine("Aluno reprovado com a média " + notaFinal);
 }


