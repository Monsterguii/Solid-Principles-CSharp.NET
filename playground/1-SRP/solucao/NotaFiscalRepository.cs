namespace SRP.Solucao
{
    /// <summary>
    /// SOLUÇÃO DO SRP: Esta classe tem a responsabilidade de salvar a nota fiscal no banco de dados.
    /// Ela não deve se preocupar com os dados da nota fiscal ou com o cálculo de impostos
    /// </summary>
    public class NotaFiscalRepository
    {
        public void Salvar(NotaFiscal notaFiscal)
        {
            // Finge que tem um insert aqui salvando a nota fiscal no banco de dados
            Console.WriteLine($"Salvando a Nota Fiscal {notaFiscal.Numero} no banco de dados...");
        }
    }
}
