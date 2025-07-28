using OCP.Solucao;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Criar um produto de exemplo
        var produto = new Produto("Notebook", 2000.0);
        Console.WriteLine($"Produto: {produto.Nome}, Preço: R$ {produto.Preco}");

        // Criar a factory e então a calculadora de preço
        var factory = new CalculadorDescontoFactory();
        var calculadora = new CalculadoraDePreco(factory);

        // Criar diferentes clientes
        var clienteGuilherme = new Cliente("Guilherme", TipoCliente.Comum);
        var clienteJonas = new Cliente("Jonas", TipoCliente.Especial);
        var clienteSara = new Cliente("Sara", TipoCliente.Fidelidade);

        // Calcular os preços
        double precoClienteComum = calculadora.CalcularPreco(produto, clienteGuilherme);
        Console.WriteLine($"Preço para cliente comum: {precoClienteComum}");

        double precoClienteEspecial = calculadora.CalcularPreco(produto, clienteJonas);
        Console.WriteLine($"Preço para cliente especial: {precoClienteEspecial}");

        double precoClienteFidelidade = calculadora.CalcularPreco(produto, clienteSara);
        Console.WriteLine($"Preço para cliente fidelidade: {precoClienteFidelidade}");
    }
}