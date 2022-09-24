decimal GastosMensais, ValorAInvestir;
double dividendYield;
Console.WriteLine("Vivendo de Dividendos\n");
Console.Write("Gastos Mensais (em R$) : ");
GastosMensais = Convert.ToDecimal(Console.ReadLine());
Console.Write("Rendimentos Mensais (%) : ");
dividendYield = Convert.ToDouble(Console.ReadLine());
ValorAInvestir = GastosMensais / Convert.ToDecimal(dividendYield / 100);
Console.WriteLine($"\nPara receber {GastosMensais:C} por mês com rendimentos de {dividendYield:N1}% você precisa ter investido {ValorAInvestir:C}.");