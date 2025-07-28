namespace OCP.Solucao
{
    /// <summary>
    /// Classe que representa o desconto para clientes comuns.
    /// </summary>
    public class DescontoClienteComum : CalculadorDescontoBase
    {
        public override double CalcularDesconto(Produto produto)
        {
            // Lógica de cálculo de desconto para cliente comum
            return produto.Preco * 0.1; // 10% de desconto
        }
    }
}
