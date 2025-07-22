namespace SRP.Solucao
{
    /// <summary>
    /// SOLUÇÃO DO SRP: Esta classe tem uma única responsabilidade, que é conter os dados da nota fiscal.
    /// </summary>
    public class NotaFiscal
    {
        public int Numero { get; set; }
        public double Valor { get; set; }

        public NotaFiscal(int numero, double valor)
        {
            Numero = numero;
            Valor = valor;
        }
    }
}
