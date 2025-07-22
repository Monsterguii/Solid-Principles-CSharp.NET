using System;

namespace ISP.Violacao
{
    /// <summary>
    /// VIOLAÇÃO DO ISP: Esta interface tem muitos métodos não relacionados.
    /// 
    /// O problema é que nem todas as impressoras implementam todas as funcionalidades.
    /// Uma impressora simples pode imprimir, mas não digitalizar ou enviar fax.
    /// Ao forçar todas as classes a implementarem métodos que não usam, estamos violando o ISP.
    /// 
    /// Isso cria implementações vazias ou que lançam exceções, tornando o código frágil e difícil de manter.
    /// </summary>
    public interface IDispositivo
    {
        void Imprimir(string documento);
        void Digitalizar(string documento);
        void EnviarFax(string documento);
        void Copiar(string documento);
    }

    // Implementação para uma impressora multifuncional que suporta todas as operações
    public class ImpressoraMultifuncional : IDispositivo
    {
        public void Imprimir(string documento)
        {
            Console.WriteLine($"Imprimindo {documento}");
        }

        public void Digitalizar(string documento)
        {
            Console.WriteLine($"Digitalizando {documento}");
        }

        public void EnviarFax(string documento)
        {
            Console.WriteLine($"Enviando fax: {documento}");
        }

        public void Copiar(string documento)
        {
            Console.WriteLine($"Copiando {documento}");
        }
    }

    // Implementação para uma impressora velha que só imprime
    // Aqui temos o problema: somos forçados a implementar métodos que não usamos!
    public class ImpressoraVelha : IDispositivo
    {
        public void Imprimir(string documento)
        {
            Console.WriteLine($"Imprimindo {documento}");
        }

        public void Digitalizar(string documento)
        {
            // Esta impressora não suporta digitalização
            throw new NotImplementedException("Esta impressora não suporta digitalização");
        }

        public void EnviarFax(string documento)
        {
            // Esta impressora não suporta fax
            throw new NotImplementedException("Esta impressora não suporta fax");
        }

        public void Copiar(string documento)
        {
            // Esta impressora não suporta cópia
            throw new NotImplementedException("Esta impressora não suporta cópia");
        }
    }
}
