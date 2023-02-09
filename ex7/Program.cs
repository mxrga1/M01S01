Console.WriteLine("Qual o nome do aluno?"); //Pergunta o nome do aluno
string nomeAluno = Console.ReadLine(); //Armazena em uma string nomeAluno o nome digitado acima

Console.WriteLine("Quantas notas serão usadas para compor a média?"); //Pergunta a quantidade de notas para compor a média
int quantidadeNotas = int.Parse(Console.ReadLine()); //Armazena em uma variavel chamada quantidadeNotas o número de notas digitadas acima

double soma = 0; //Inicia a soma de todas as notas com 0


//loop para percorrer as quantidade de notas informadas
for (int i = 1; i <= quantidadeNotas; i++)
{
Console.WriteLine("Digite a nota " + i); //Solicita uma das notas
double nota = double.Parse(Console.ReadLine()); //Armazena a nota citada acima
soma += nota; //Adiciona a nota a soma
}

double media = soma / quantidadeNotas; //Calcula a média das notas
 string situacao; //Variavel situação
            if (media >= 6) //Se a média for maior ou igual a 6 
            {
                situacao = "Aprovado"; //Exibe "Aprovado" se a média for maior ou igual a 6
            }
            else if (media >= 5) //Se a média for maior ou igual a 5
            {
                situacao = "Recuperação"; //Exibe "Recuperação se a média for maior ou igual a 5
            }
            else
            {
                situacao = "Reprovado"; //Exibe "Reprovado" caso não seja nenhuma das opções acima
            }

Console.WriteLine("Aluno: " + nomeAluno); //Exibe o nome do Aluno
Console.WriteLine("Média: " + media + " - " + situacao); //Exibe a média e a situação do aluno