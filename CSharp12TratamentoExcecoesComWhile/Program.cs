int idade = 0;
bool idadeValida = false;


while (!idadeValida)
{
    try//impede a aplicação de quebrar quando ocorre um erro, possibilitando o tratamento
    {
        Console.Write("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        if(idade < 0)//validando valores da idade
        {
            Console.WriteLine("Idade não pode ser negativa!");
            continue;
        }
        if(idade > 120)//validando valores da idade
        {
            Console.WriteLine("Idade máxima é 120");
            continue;
        }
        idadeValida = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Idade não é um número inteiro válido!");
    }
}

double peso = 0.0;
bool pesoValido = false;

while (!pesoValido)
{
    try
    {
        Console.Write("Digite o peso: ");
        peso = Convert.ToDouble(Console.ReadLine().ToLower().Replace("kg", ""));//se o usuario informar o peso com kg, ele remove o kg
        if(peso < 1)
        {
            Console.WriteLine("O peso não pode ser menor que 1!");
            continue;
        }
        if(peso > 400)
        {
            Console.WriteLine("O peso máximo é 400kg");
            continue;
        }

        pesoValido = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Peso não é um número válido!");
    }
}
