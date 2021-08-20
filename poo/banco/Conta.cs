class Conta {
  public string nome { get; set; }
  public string endereco { get; set; }
  public float saldo { get; set; }
  
  public Conta(string nome, string endereco, float saldoInicial)
  {
    this.nome = nome;
    this.endereco = endereco;
    this.saldo = saldoInicial;
  }
}