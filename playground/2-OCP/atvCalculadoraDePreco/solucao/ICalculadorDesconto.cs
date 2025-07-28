namespace OCP.Solucao
{
    /// <summary>
    /// Interface que define o contrato para calcular descontos.
    /// </summary>
    public interface ICalculadorDesconto
    {
        double CalcularDesconto(Produto produto);
    }
}