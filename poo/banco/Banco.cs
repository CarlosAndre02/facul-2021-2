using System;
using System.Collections.Generic;

class Banco {
  public Dictionary<string, Conta> CadastroContas { get; }
  
  public Banco() {
    this.CadastroContas = new Dictionary<string, Conta>();
  }
  
  public void inserir(string cod, Conta conta) {
    this.CadastroContas.Add(cod, conta);
  }
  
  public Conta buscar(string cod){
    return this.CadastroContas[cod];
  }
  
  public void listarTodasContas(){
    foreach(var conta in this.CadastroContas.Keys) {
      Console.WriteLine(this.CadastroContas[conta]);
    }
  }
  
  public void remover(string cod){
    this.CadastroContas.Remove(cod);
  }
}