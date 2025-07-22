using System;

namespace LSP.Violacao
{
    /// <summary>
    /// VIOLAÇÃO DO LSP: Esta hierarquia viola o Princípio de Substituição de Liskov.
    /// 
    /// O problema está na relação entre Retangulo e Quadrado. Matematicamente, todo quadrado é um 
    /// retângulo, mas na orientação a objetos, esta relação cria problemas porque o comportamento 
    /// do Quadrado não é consistente com o comportamento esperado de um Retangulo.
    /// 
    /// Quando alteramos a largura de um quadrado, sua altura também muda (e vice-versa), o que não 
    /// é o comportamento esperado de um retângulo. Isso significa que não podemos substituir um objeto 
    /// Retangulo por um objeto Quadrado sem potencialmente quebrar a lógica do programa.
    /// </summary>
    public class Retangulo
    {
        protected double largura;
        protected double altura;

        public virtual double Largura 
        { 
            get { return largura; }
            set { largura = value; }
        }

        public virtual double Altura 
        { 
            get { return altura; }
            set { altura = value; }
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }

    // Violação do LSP: Um quadrado não pode substituir completamente um retângulo
    public class Quadrado : Retangulo
    {
        public override double Largura
        {
            get { return base.largura; }
            set 
            { 
                base.largura = value;
                base.altura = value; // Um quadrado tem lados iguais
            }
        }

        public override double Altura
        {
            get { return base.altura; }
            set 
            { 
                base.altura = value;
                base.largura = value; // Um quadrado tem lados iguais
            }
        }
    }
}
