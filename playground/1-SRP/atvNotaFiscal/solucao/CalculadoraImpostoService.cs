namespace SRP.Solucao
{
    /// <summary>
    /// SOLUÇÃO DO SRP: Esta classe tem uma única responsabilidade, que é pegar o valor da nota fiscal
    /// e calcular o imposto sobre ela.
    /// </summary>
    public class CalculadoraImpostoService : ICalculadoraImpostoService
    {
        public double CalcularImposto(NotaFiscal notaFiscal)
        {
            return notaFiscal.Valor * 0.06;
        }
    }
}
