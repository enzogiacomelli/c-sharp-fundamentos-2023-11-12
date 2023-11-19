Console.Write("Digite o preço do produto");
double precoProduto = Convert.ToDouble(Console.ReadLine());

if((precoProduto >= 950.75) && (precoProduto <= 2540.60))
{
    Console.WriteLine("Temos produtos em estoque!");
}
else
{
    Console.WriteLine("Não temos produtos em estoque!");
}