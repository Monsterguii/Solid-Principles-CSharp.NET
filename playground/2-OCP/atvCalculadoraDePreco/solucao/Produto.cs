namespace OCP.Solucao
{
    /// <summary>
    /// Classe de Produtos
    /// </summary>
    
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
}