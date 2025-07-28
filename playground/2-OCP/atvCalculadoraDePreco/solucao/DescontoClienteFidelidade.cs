namespace OCP.Solucao
{
    /// <summary>
    /// Classe que representa o desconto para clientes fidelidade.
    /// </summary>
    public class DescontoClienteFidelidade : CalculadorDescontoBase
    {
        public override double CalcularDesconto(Produto produto)
        {
            return produto.Preco * 0.15; 
        }
    }
}