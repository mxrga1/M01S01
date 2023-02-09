Console.WriteLine("Informe o salário bruto:"); //Coloque o valor do salário bruto
double salarioBruto = Convert.ToDouble(Console.ReadLine());   //Várivael que armanará o sálario bruto



             

     //Verifica o valor do salário e calcula o imposto devida as condições listadasd abaixo

     //Se o salário bruto for menor ou igual a 900, o imposto devido é zero.
     //Se o salário bruto estiver entre 900 e 1500, o imposto devido é calculado como 5% do salário bruto.
     //Se o salário bruto estiver entre 1500 e 2500, o imposto devido é calculado como 10% do salário bruto.
     //Se o salário bruto for maior que 2500, o imposto devido é calculado como 20% do salário bruto.



 double impostoDevido;

if (salarioBruto <= 900)
{
    impostoDevido = 0;
}
else if (salarioBruto <= 1500)
{
    impostoDevido = salarioBruto * 0.05;
}
else if (salarioBruto <= 2500)
{
    impostoDevido = salarioBruto * 0.1;
}
else
{
    impostoDevido = salarioBruto * 0.2;
}

Console.WriteLine("O imposto devido é de R$" + impostoDevido);  //Impre o imposto sobre o sálario bruto
        