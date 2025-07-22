using SRP.Solucao;
using System;

class Program
{
    static void Main(string[] args)
    {
        var notaFiscal = new NotaFiscal(1, 1327.50);
        var calculadoraImposto = new CalculadoraImposto();
        Console.WriteLine(calculadoraImposto.CalcularImposto(notaFiscal));
        
        var notaFiscalRepository = new NotaFiscalRepository();
        notaFiscalRepository.Salvar(notaFiscal);
        Console.WriteLine("Nota Fiscal salva com sucesso!");
    }
}

