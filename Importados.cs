class Importados : Carro {
  
  protected override void definiValorVeiculo (double CustoFixo){
    if (CustoFixo >= 0 ) {
      double Cf = CustoFixo * 3.0 + 0.6*CustoFixo + CustoFixo/5;
      Console.WriteLine(Cf);
    }
  }
}
