using System.Collections.Generic;

class AgendaTelefonica {
 public Dictionary<string, string> Agenda { get; }

  public AgendaTelefonica() {
    this.Agenda = new Dictionary<string, string>();
  }

  public void inserir(string nome, string numero) {
    this.Agenda.Add(nome, numero);
  } 

  public string buscarNumero(string nome) {
    var numeroAgenda = "";
    foreach (string nomeAgenda in this.Agenda.Keys)
    {
      if (nomeAgenda == nome) {
        numeroAgenda =  this.Agenda[nome];
      }
    }
    return numeroAgenda;
  }

  public void remover(string nome) {
    this.Agenda.Remove(nome);
  }

  public int tamanho() {
    return this.Agenda.Count;
  }
}