namespace OCP.Solucao
{
    /// <summary>
    /// Classe factory para criar instâncias de calculadores de desconto baseados no tipo de cliente.
    /// </summary>
    public class CalculadorDescontoFactory
    {
        private readonly Dictionary<TipoCliente, Func<ICalculadorDesconto>> _calculadorasFactory = 
            new Dictionary<TipoCliente, Func<ICalculadorDesconto>>();

        public CalculadorDescontoFactory()
        {
            // Registro inicial usando funções de fábrica em vez de reflection
            RegistrarCalculadora(TipoCliente.Comum, () => new DescontoClienteComum());
            RegistrarCalculadora(TipoCliente.Fidelidade, () => new DescontoClienteFidelidade());
            RegistrarCalculadora(TipoCliente.Especial, () => new DescontoClienteEspecial());
        }

        // Método para registrar novas calculadoras sem modificar o código existente
        public void RegistrarCalculadora(TipoCliente tipo, Func<ICalculadorDesconto> factoryFunc)
        {
            _calculadorasFactory[tipo] = factoryFunc;
        }

        public ICalculadorDesconto CriarCalculadora(Cliente cliente)
        {
            if (_calculadorasFactory.TryGetValue(cliente.tipo, out var factoryFunc))
            {
                return factoryFunc();
            }
            
            throw new ArgumentException($"Tipo de cliente desconhecido: {cliente.tipo}");
        }
    }
}