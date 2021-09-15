using System.Collections.Generic;
using System;

class Concessionaria {
  private string localizacao;
  private string gerentePrincipal;
  private int anoDeFundacao;
  private List<Carro>carrosDisponiveis = new List<Carro>();

//construtor
public Concessionaria (string local,string gerent,int af){
local = localizacao;
gerent = gerentePrincipal;
af = anoDeFundacao;
}
//metodos
public void AdicionarCarro(Carro c){
    carrosDisponiveis.Add(c);
  }

 public double calcularPortfolio(){
   double totalValor = 0;
   foreach(Carro c in carrosDisponiveis){
     totalValor = c.valor + totalValor;
   }
   return totalValor;
 }


}