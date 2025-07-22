
namespace SRP.Violacao
{
    /// <summary>
    /// VIOLAÇÃO DO SRP: Esta classe tem múltiplas responsabilidades.
    /// 1. Conter os dados da nota fiscal (valor, número).
    /// 2. Calcular o imposto sobre a nota.
    /// 3. Salvar a nota fiscal no banco de dados.
    /// 
    /// Um motivo para mudar esta classe seria uma alteração na regra de negócio do cálculo de imposto.
    /// Outro motivo seria a mudança da tecnologia do banco de dados (ex: de SQL Server para Oracle).
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

        public double CalcularImposto()
        {
            return Valor * 0.06; 
        }

        public void SalvarNoBancoDeDados()
        {
            // Finge que tem um insert aqui salvando a nota fiscal no banco de dados
            Console.WriteLine($"Salvando a Nota Fiscal {Numero} no banco de dados...");
        }
    }
}