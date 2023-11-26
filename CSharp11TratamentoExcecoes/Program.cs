/*try
{
    int numero1 = Convert.ToInt32("10");
    int numero2 = Convert.ToInt32("12p");

    int soma = numero1 + numero2;

    Console.WriteLine("Numero 01: " + numero1);
    Console.WriteLine("Numero 02: " + numero2);
    Console.WriteLine("Soma: " + soma);
}
catch (Exception ex)
{
    Console.WriteLine("Aconteceu um erro na conversão de numero");
}

Console.WriteLine("programa encerrou corretamente");
*/

Console.Write("\n\nDigite o nome");
string nome = Console.ReadLine();
int idade = 0;

try
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Idade não é um numero inteiro valido");
}

double peso = 0.0;

try
{
    Console.Write("Digite o peso: ");
    peso = Convert.ToDouble(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine("Peso não é um valor real válido");
}

Console.WriteLine("Nome: " + "\nIdade: " + idade + "\nPeso: " + peso);