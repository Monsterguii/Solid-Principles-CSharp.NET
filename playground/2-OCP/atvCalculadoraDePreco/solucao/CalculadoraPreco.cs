namespace OCP.Solucao
{
    /// <summary>
    /// Classe para fazer o calculo do preço de um produto com base no tipo de cliente.
    /// </summary>
    public class CalculadoraDePreco
    {
        private readonly CalculadorDescontoFactory _factory;

        public CalculadoraDePreco(CalculadorDescontoFactory factory)
        {
            _factory = factory;
        }

        public double CalcularPreco(Produto produto, Cliente cliente)
        {
            var calculadora = _factory.CriarCalculadora(cliente);
            double desconto = calculadora.CalcularDesconto(produto);
            return produto.Preco - desconto;
        }
    }
}