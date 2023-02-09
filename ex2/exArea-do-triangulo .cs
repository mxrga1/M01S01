   
   
           
           
            Console.WriteLine("Calculadora da Área de Triângulo"); //Informa que é uma calculadora da área do triângulo

            Console.Write("Digite o valor da base: "); //Aqui você coloca o valor da base do triângulo

            float baseTriangulo = float.Parse(Console.ReadLine()); //Pega o valor colocado na linha acima

            Console.Write("Digite o valor da altura: "); //Aqui você insere o valor da altura do triângulo

            float alturaTriangulo = float.Parse(Console.ReadLine()); //Pega o valor colado na linha acima
               
            float area = (baseTriangulo * alturaTriangulo) / 2; //Calcula a base x altura e faz a divisão por 2

            Console.WriteLine("A área do triângulo é: " + area); //Informa a área do triângulo