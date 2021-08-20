using System;

namespace ex_slide2_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b1 = new Banco();
            b1.inserir("1111", new Conta("Carlos André", "Rua Neymar Jr", 1200));
            b1.inserir("151", new Conta("João", "Rua Getulio Vargas", 500));
            b1.inserir("202", new Conta("Lionel Messi", "Rua undefined", 100));

            Console.WriteLine(b1.buscar("1111").nome);
            b1.remover("1111");
            b1.listarTodasContas();
        }
    }
}
