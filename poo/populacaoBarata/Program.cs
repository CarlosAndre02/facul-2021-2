using System;

class PopulacaoBaratas
{
    public double population { get; set; }
    public PopulacaoBaratas()
    {
        Random rnd = new Random();
        this.population = rnd.Next(500);
    }

    public void aumentaBaratas() 
    {
        this.population *= 1.1;
        Console.WriteLine("População aumentada");
    }

    public void usaSpray() {
        this.population *= 0.9;
        Console.WriteLine("População pulverizada");
    }

    public void getQtdBaratas() {
        Console.WriteLine($"População atual -> {this.population}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PopulacaoBaratas pop1 = new PopulacaoBaratas();
        Console.WriteLine(pop1.population);
        pop1.aumentaBaratas();
        Console.WriteLine(pop1.population);
        pop1.usaSpray();
        Console.WriteLine(pop1.population);
    }
}
