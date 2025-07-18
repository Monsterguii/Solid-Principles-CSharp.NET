# CSharp SOLID Playground 🚀

Bem-vindo ao C# SOLID Playground! Este repositório é um ambiente de aprendizado prático e interativo, projetado para estudar, praticar e dominar os cinco princípios de design de software **SOLID** utilizando a linguagem C#.

O objetivo deste projeto não é apenas apresentar as soluções, mas sim seguir uma metodologia de desafios: para cada princípio, um problema (código em violação) é apresentado, e o desafio é refatorá-lo para uma solução limpa e coesa.

## O que são os Princípios SOLID?

SOLID é um acrônimo para cinco princípios de design que visam tornar o software mais compreensível, flexível e manutenível.

* **S - Single Responsibility Principle (Princípio da Responsabilidade Única):** Uma classe deve ter apenas um motivo para mudar.
* **O - Open/Closed Principle (Princípio Aberto/Fechado):** As entidades de software devem ser abertas para extensão, mas fechadas para modificação.
* **L - Liskov Substitution Principle (Princípio da Substituição de Liskov):** Objetos de uma superclasse devem ser substituíveis por objetos de uma subclasse sem afetar a corretude do programa.
* **I - Interface Segregation Principle (Princípio da Segregação de Interface):** Um cliente não deve ser forçado a depender de interfaces que não utiliza.
* **D - Dependency Inversion Principle (Princípio da Inversão de Dependência):** Módulos de alto nível не devem depender de módulos de baixo nível. Ambos devem depender de abstrações.

## 🏛️ Estrutura do Projeto

O playground está organizado em pastas, uma para cada princípio SOLID. Dentro de cada pasta, você encontrará a seguinte estrutura:

* **`Violacao/`**: Contém o código original que apresenta o problema, violando o respectivo princípio.
* **`Solucao/`**: Contém o código refatorado que representa a solução do desafio, aplicando o princípio corretamente.

```
SOLID_CSharp_Playground/
│
├── 1_SRP_Single_Responsibility_Principle/
│   ├── Violacao/
│   └── Solucao/
│
├── 2_OCP_Open_Closed_Principle/
│   ├── Violacao/
│   └── Solucao/
│
└─── ... (e assim por diante para os outros princípios)

```

## 🚀 Como Começar

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/SEU-USUARIO/SOLID_CSharp_Playground.git](https://github.com/SEU-USUARIO/SOLID_CSharp_Playground.git)
    ```
2.  **Navegue até a pasta do projeto:**
    ```bash
    cd SOLID_CSharp_Playground
    ```
3.  **Abra o projeto** em sua IDE de preferência (Visual Studio, Rider ou VS Code).
4.  **Execute o projeto:**
    ```bash
    dotnet run
    ```
    O arquivo `Program.cs` na raiz pode ser usado para testar e executar os diferentes exemplos de código de cada princípio.

## 🏆 Metodologia de Desafios e Avaliação

Este repositório segue uma metodologia de aprendizado ativa. Para cada princípio, o código na pasta `Violacao/` serve como um desafio. Seu objetivo é refatorá-lo e criar a versão da `Solucao/`.

As soluções são avaliadas com base nas seguintes condições e restrições:

### Condições de Implementação

| Nível     | Achievement             | Condição                                                                             |
| :-------- | :---------------------- | :----------------------------------------------------------------------------------- |
| 🥉 Bronze | Classe Limpa            | Criar uma classe que tenha apenas uma razão para mudar.                              |
| 🥈 Silver | Delegador Nato          | Identificar e extrair responsabilidades secundárias em novas classes ou serviços.    |
| 🥇 Gold   | Refatorador Mestre      | Refatorar uma classe existente cheia de responsabilidades, separando em classes coesas. |
| 💎 Platinum | Código à Prova de Mudança | Adicionar testes automatizados que validem o comportamento das classes refatoradas.  |
| ⚔️ Extra    | Anti-Deus               | Detectar uma *God Class* e documentar em um arquivo `ANTI-GOD.md` como ela poderia ser dividida. |

### 🚨 Restrições Obrigatórias

| Achievement             | Restrição                                                               |
| :---------------------- | :---------------------------------------------------------------------- |
| Classe Limpa            | Não mover responsabilidades para funções estáticas ou helpers genéricos. |
| Delegador Nato          | Cada nova classe deve ter um propósito claro e único.                   |
| Refatorador Mestre      | Nenhuma nova classe pode ter métodos não relacionados ao seu propósito.  |
| Código à Prova de Mudança | Os testes devem quebrar se alguém adicionar uma nova responsabilidade indevida a qualquer classe. |
| Anti-Deus               | Não pode apenas comentar ou apagar código — precisa apresentar uma solução de design clara. |

---

Este README é um documento vivo e será atualizado à medida que os desafios forem concluídos. Sinta-se à vontade para contribuir, sugerir novos desafios ou melhorias!