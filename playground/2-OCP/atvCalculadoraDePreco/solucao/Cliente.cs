namespace OCP.Solucao
{
    public class Cliente
    {
        public string nome { get; set; }
        public TipoCliente tipo { get; set; }
        public Cliente(string nome, TipoCliente tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }
    }
}