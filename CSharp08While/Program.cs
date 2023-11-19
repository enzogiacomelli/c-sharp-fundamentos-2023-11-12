/*
int indice = 0, soma = 0;

while (indice < 5)
{
    Console.Write("\nInforme um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
    indice++;
}
Console.WriteLine(soma);
*/

int indice = 0, quantidadePessoasAdultas = 0, quantidadePessoasIdosas = 0, somaIdades = 0;

while (indice <=2)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();

    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    somaIdades += idade;

    if((idade >=18) && (idade < 60))
    {
        quantidadePessoasAdultas += 1;
    }
    else if((idade >= 60))
    {
        quantidadePessoasIdosas += 1;
    }
    indice++;
}

double mediaIdades = somaIdades / 3.0;

Console.WriteLine("Média das idades:" + mediaIdades + "\nQuantidade de pessoas adultas: " + quantidadePessoasAdultas + "\nQuantidade de pessoas idosas: " + quantidadePessoasIdosas);