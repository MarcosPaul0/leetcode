using System.Text.Json;

public static class Test
{
  public static void Main(char[] args)
  {
    Test.FinalSum();

    Test.BelongToFibonacci();

    Test.ProcessInvoicing();

    Test.Percentage();

    Test.ReverseString();
  }

  public static void FinalSum()
  {
    int index = 13;
    int sum = 0;
    int k = 0;

    while (k < index)
    {
      k++;
      sum += k;
    }

    Console.WriteLine($"O valor final será {sum}");
  }

  public static void BelongToFibonacci()
  {
    int value = 5;

    int currentValue = 0;
    int nextValue = 1;
    int aux = 0;

    while (currentValue <= value)
    {
      aux = currentValue;
      currentValue = nextValue;
      nextValue = aux + nextValue;

      if (nextValue == value)
      {
        Console.WriteLine($"{value} pertence a sequência fibonacci.");
        return;
      }
    }

    Console.WriteLine($"{value} NÃO pertence a sequência fibonacci.");
  }

  public static void ProcessInvoicing()
  {
    string dirname = Directory.GetCurrentDirectory();
    var stream = File.OpenRead(dirname + "./data.json");
    var result = JsonSerializer.Deserialize<IEnumerable<Invoicing>>(stream);

    var resultFiltered = result.Where(invoicing => invoicing.Valor != 0);

    var minValue = resultFiltered.Min(invoicing => invoicing.Valor);
    var maxValue = resultFiltered.Max(invoicing => invoicing.Valor);

    var averageValue = resultFiltered.Average(invoicing => invoicing.Valor);
    var upperInvoicing = resultFiltered.Count(invoicing => invoicing.Valor > averageValue);

    Console.WriteLine($"Faturamento mínimo no mês {minValue}.");
    Console.WriteLine($"Faturamento máximo no mês {maxValue}.");
    Console.WriteLine($"Número de dia superior a média de faturamento {maxValue}.");
  }

  public static void Percentage()
  {
    double SP = 7836.43;
    double RJ = 36678.66;
    double MG = 29229,88;
    double ES = 27165.48;
    double others = 19849.53;

    double total = SP + RJ + MG + ES + others;

    double SPPercentage = SP / total * 100;
    double RJPercentage = RJ / total * 100;
    double MGPercentage = MG / total * 100;
    double ESPercentage = ES / total * 100;
    double othersPercentage = others / total * 100;

    Console.WriteLine($"SP = {SPPercentage}%");
    Console.WriteLine($"RJ = {RJPercentage}%");
    Console.WriteLine($"MG = {MGPercentage}%");
    Console.WriteLine($"ES = {ESPercentage}%");
    Console.WriteLine($"Outros = {othersPercentage}%");
  }

  public static void ReverseString()
  {
    string test = "Teste";
    string reversed = "";

    for (int i = test.Length - 1; i >= 0; i--)
    {
      reversed += test[i];
    }

    Console.WriteLine($"Reverso {reversed}.");
  }
}

