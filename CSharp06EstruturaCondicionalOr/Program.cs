/*
Console.Write("Pessoa tem indicação (S/N): ");
string temIndicacaoTexto = Console.ReadLine().ToLower();

bool temIndicacao = false;

if ((temIndicacaoTexto == "s") || (temIndicacaoTexto == "sim"))
{
    temIndicacao = true;
}

Console.Write("Digite o Score da pessoa: ");
int score = Convert.ToInt32(Console.ReadLine());

if((temIndicacao == true) || (score > 700))
{
    Console.WriteLine("Abertura da conta realizada com sucesso!");
}
else
{
    Console.WriteLine("Não é possível abrir a conta!");
}

*/

Console.Write("Informe o nome do produto 1: ");
string nomeProduto1 = Console.ReadLine();

Console.Write("Informe o valor do produto 1: ");
double ValorProduto1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a quantidade do produto 1: ");
double QuantidadeProduto1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Informe o nome do produto 2: ");
string nomeProduto2 = Console.ReadLine();

Console.Write("Informe o valor do produto 2: ");
double ValorProduto2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a quantidade do produto 2: ");
double QuantidadeProduto2 = Convert.ToInt32(Console.ReadLine());


Console.Write("Informe o nome do produto 3: ");
string nomeProduto3 = Console.ReadLine();

Console.Write("Informe o valor do produto 3: ");
double ValorProduto3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a quantidade do produto 3: ");
double QuantidadeProduto3 = Convert.ToInt32(Console.ReadLine());


double valorTotal = (QuantidadeProduto1 * ValorProduto1) + (QuantidadeProduto2 * ValorProduto2) + (QuantidadeProduto3 * ValorProduto3);
double desconto = 0.0;

if (valorTotal < 100.00)
{
    desconto = 1.00;//sem desconto
}
else if ((valorTotal >=100.00) && (valorTotal <=1000.00))
{
    desconto = 0.98;//2%
}
else if((valorTotal >= 1000.01) && (valorTotal <= 2000.00))
{
    desconto = 0.96;//4%
}
else if ((valorTotal >= 2000.01) && (valorTotal <= 4000.00))
{
    desconto = 0.92;//8%
}
else if ((valorTotal >= 2000.01) && (valorTotal <= 4000.00))
{
    desconto = 0.85;//15%
}

double valorFinal = valorTotal * desconto;

Console.WriteLine("O valor total da compra é de: " + valorTotal + ". O valor final com desconto é de: " + valorFinal + ".");

