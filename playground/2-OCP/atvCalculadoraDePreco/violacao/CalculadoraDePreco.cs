using System;

namespace OCP.Violacao
{
    /// <summary>
    /// VIOLAÇÃO DO OCP: Esta classe precisa ser modificada sempre que um novo tipo de desconto é adicionado.
    /// 
    /// Quando um novo tipo de desconto é criado, precisamos modificar o método CalcularDesconto adicionando
    /// mais um bloco condicional (if/else ou switch case). Isso viola o OCP, pois a classe não está fechada 
    /// para modificação - qualquer alteração na regra de negócios exige alterações nessa classe.
    /// </summary>
    public class CalculadoraDePreco
    {
        public double CalcularDesconto(Produto produto, TipoCliente tipoCliente)
        {
            // Violação do OCP: Se adicionarmos um novo tipo de cliente,
            // precisamos modificar este método
            if (tipoCliente == TipoCliente.Comum)
            {
                return produto.Preco * 0.05; // 5% de desconto para clientes comuns
            }
            else if (tipoCliente == TipoCliente.Fidelidade)
            {
                return produto.Preco * 0.1; // 10% de desconto para clientes fidelidade
            }
            else if (tipoCliente == TipoCliente.Especial)
            {
                return produto.Preco * 0.15; // 15% de desconto para clientes especiais
            }
            
            return 0;
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    public enum TipoCliente
    {
        Comum,
        Fidelidade,
        Especial
    }
}
