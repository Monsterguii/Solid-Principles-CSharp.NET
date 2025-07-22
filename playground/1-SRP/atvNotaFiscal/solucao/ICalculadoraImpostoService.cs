namespace SRP.Solucao
{
    /// <summary>
    /// Interface para o serviço de cálculo de impostos.
    /// Define o contrato para calcular o imposto de uma nota fiscal.
    /// </summary>
    public interface ICalculadoraImpostoService
    {
        double CalcularImposto(NotaFiscal notaFiscal);
    }
}