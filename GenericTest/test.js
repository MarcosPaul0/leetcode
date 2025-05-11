const fs = require("fs");

class Test {
  static Main() {
    Test.FinalSum();
    Test.BelongToFibonacci();
    Test.ProcessInvoicing();
    Test.Percentage();
    Test.ReverseString();
  }

  static FinalSum() {
    let index = 13;
    let sum = 0;
    let k = 0;

    while (k < index) {
      k++;
      sum += k;
    }

    console.log(`O valor final será ${sum}`);
  }

  static BelongToFibonacci() {
    let value = 5;

    let currentValue = 0;
    let nextValue = 1;
    let aux = 0;

    while (currentValue <= value) {
      aux = currentValue;
      currentValue = nextValue;
      nextValue = aux + nextValue;

      if (nextValue === value) {
        console.log(`${value} pertence a sequência fibonacci.`);
        return;
      }
    }

    console.log(`${value} NÃO pertence a sequência fibonacci.`);
  }

  static ProcessInvoicing() {
    const data = fs.readFileSync(__dirname + "/data.json", "utf8");
    const result = JSON.parse(data);

    const resultFiltered = result.filter((invoicing) => invoicing.valor !== 0);

    const minValue = Math.min(...resultFiltered.map((i) => i.valor));
    const maxValue = Math.max(...resultFiltered.map((i) => i.valor));

    const averageValue = resultFiltered.reduce((sum, invoicing) => sum + invoicing.valor, 0) / resultFiltered.length;
    const upperInvoicing = resultFiltered.filter(
      (invoicing) => invoicing.valor > averageValue
    ).length;

    console.log(`Faturamento mínimo no mês ${minValue}.`);
    console.log(`Faturamento máximo no mês ${maxValue}.`);
    console.log(
      `Número de dias que foi superior a média de faturamento ${upperInvoicing}.`
    );
  }

  static Percentage() {
    const SP = 7836.43;
    const RJ = 36678.66;
    const MG = 29229.88;
    const ES = 27165.48;
    const others = 19849.53;

    const total = SP + RJ + MG + ES + others;

    const SPPercentage = (SP / total) * 100;
    const RJPercentage = (RJ / total) * 100;
    const MGPercentage = (MG / total) * 100;
    const ESPercentage = (ES / total) * 100;
    const othersPercentage = (others / total) * 100;

    console.log(`SP = ${SPPercentage}%`);
    console.log(`RJ = ${RJPercentage}%`);
    console.log(`MG = ${MGPercentage}%`);
    console.log(`ES = ${ESPercentage}%`);
    console.log(`Outros = ${othersPercentage}%`);
  }

  static ReverseString() {
    const test = "Teste";
    let reversed = "";

    for (let i = test.length - 1; i >= 0; i--) {
      reversed += test[i];
    }

    console.log(`Reverso ${reversed}.`);
  }
}

Test.Main();
