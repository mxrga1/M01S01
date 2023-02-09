string opcao; //Variavel com nome opções

do //Faz um loop dentre as mensagens abaixo
{
    Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção:");
    Console.WriteLine("1 - Adicionar Transação");
    Console.WriteLine("2 - Consultar Extrato");
    Console.WriteLine("3 - Sair");
    Console.Write("Opção: ");

    opcao = Console.ReadLine(); //Armazena a opções que o usuario escolheu acima

    if (opcao == "1") //Verifica se a opções 1
    {
        Console.WriteLine("Adicionar Transação"); //Aparece "Adicionar Transação" caso a opção foi 1
    }
    else if (opcao == "2") //Verifica se a opções 2
    {
        Console.WriteLine("Consultar Extrato"); //Aparece "Consultar Extrato" caso a opção foi 2
    }
    else if (opcao != "3") //Verifica se a opções 3
    {
        Console.WriteLine("Opção inválida, por favor escolha uma opção válida."); //Aparece "Opção inválida, por favor escolha uma opção válida" caso a opção for diferente de 1, 2 e 3
    }

} while (opcao != "3"); //Verifica se a opção selecionada é diferente da 3, se for, volta a fazer o loop