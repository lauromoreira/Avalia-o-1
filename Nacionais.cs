class Nacionais : Carro {
  
  protected override void definiValorVeiculo (double CustoFixo){
    if (CustoFixo >= 0 ) {
      double Cf = CustoFixo * 1.5 + 0.2 * CustoFixo + CustoFixo/10;
      Console.WriteLine(Cf);
    }
  }
}

