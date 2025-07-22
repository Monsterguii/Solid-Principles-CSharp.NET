namespace SRP.Solucao
{
    /// <summary>
    /// Interface para o repositório de notas fiscais.
    /// Define o contrato para salvar uma nota fiscal.
    /// </summary>
    public interface INotaFiscalRepository
    {   
        void Salvar(NotaFiscal notaFiscal);
    }
}   