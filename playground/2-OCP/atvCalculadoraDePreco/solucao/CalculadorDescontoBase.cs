namespace OCP.Solucao
{
    /// <summary>
    /// Classe base para os tipos de desconto, implementa a interface ICalculadorDesconto.
    /// </summary>
    public abstract class CalculadorDescontoBase : ICalculadorDesconto
    {
        public abstract double CalcularDesconto(Produto produto);
    }
}