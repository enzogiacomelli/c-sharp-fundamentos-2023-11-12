double salario = 2571.30;
double aliquota = 0;

if(salario > 8000)
{
    double valorBonus  = salario * 0.1;
    salario = salario + valorBonus;
}

Console.WriteLine("Salário: " + salario);

if(salario <= 1302.00)
{
    aliquota = 0.075;
}
else if(salario <= 2571.29)
{
    aliquota = 0.09;
}
else if(salario <= 3856.94)
{
    aliquota = 0.12;
}
else
{
    aliquota = 0.14;
}

double valorInss = salario * aliquota;
Console.WriteLine("INSS: " + valorInss);