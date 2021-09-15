using System.Collections.Generic;
using System;

class Carro {
  private string modelo;
  private string marca;
  protected string cor;
  protected double valor;
  private int ano;
  protected bool nacional;
  protected var gasolina;

//contrutor
public Carro (string mod,string mar,string c,double val,int a,bool nac) {
modelo = mod;
marca = mar;
cor = c;
valor = val;
ano = a;
nacional = nac;
gasolina = 0;
}
//gets e sets
  public string GetModelo(){
   return modelo;
   }
  public void SetModelo(string mod){
     modelo = mod;
   }

  public string GetMarca(){
     return marca;
     }
  public void SetMarca(string mar){
     marca - mar;
     }
  public int GetAno(){
   return ano;
   }
  public void SetAno(int a){
     ano = a;
   }
  //metodos
  protected virtual void definiValorVeiculo (double CustoFixo){
  
  }

  public void Abastecer(int mililitros) {
    gasolina = mililitros + gasolina;
}

  public void Abastecer(double litros) {
    gasolina = litros + gasolina;
}

  public double Abastecer(float mililitros) {
    gasolina = mililitros + gasolina;
    return gasolina;
}
}









