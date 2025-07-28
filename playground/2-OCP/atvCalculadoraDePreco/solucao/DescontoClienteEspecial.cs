namespace OCP.Solucao
{
    /// <summary>
    /// Classe que representa o desconto para clientes especiais.
    /// </summary>
    public class DescontoClienteEspecial : CalculadorDescontoBase
    {
        public override double CalcularDesconto(Produto produto)
        {
            // Lógica de cálculo de desconto para cliente especial
            return produto.Preco * 0.2; // 20% de desconto
        }
    }
    
    
}