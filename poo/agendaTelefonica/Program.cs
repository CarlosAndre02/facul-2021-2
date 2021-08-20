using System;

namespace ex_slide2_agendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica ag = new AgendaTelefonica();
            ag.inserir("Carlos", "99878-8878");
            Console.WriteLine(ag.buscarNumero("Carlos"));
            Console.WriteLine(ag.tamanho());
            ag.remover("Carlos");
            Console.WriteLine(ag.tamanho());
        }
    }
}
