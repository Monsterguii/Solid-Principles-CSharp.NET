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

O playground está organizado em uma pasta principal `playground` contendo subpastas numeradas para cada princípio SOLID. Dentro de cada pasta de princípio, você encontrará diferentes exemplos e desafios:

```
Solid-Principles-C#-.NET/
│
├── playground/
│   ├── 1-SRP/
│   │   ├── exemplo/
│   │   │   ├── solucao/
│   │   │   └── violacao/
│   │   └── ... (outros exemplos do SRP)
│   │
│   ├── 2-OCP/
│   │   ├── exemplo/
│   │   │   ├── solucao/
│   │   │   └── violacao/
│   │   └── ... (outros exemplos do OCP)
│   │
│   └── ... (e assim por diante para os outros princípios)
│
└── ... (outros arquivos do repositório)
```

Para cada exemplo:
* **`violacao/`**: Contém o código original que apresenta o problema, violando o respectivo princípio.
* **`solucao/`**: Contém o código refatorado que representa a solução do desafio, aplicando o princípio corretamente.

## 🚀 Como Começar

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/SEU-USUARIO/Solid-Principles-C#-.NET.git
    ```
2.  **Navegue até a pasta do projeto:**
    ```bash
    cd Solid-Principles-C#-.NET
    ```
3.  **Abra o projeto** em sua IDE de preferência (Visual Studio, Rider ou VS Code).
4.  **Execute os exemplos específicos:**
    ```bash
    cd playground/1-SRP/atvNotaFiscal
    dotnet run
    ```
    Cada exemplo tem seu próprio arquivo `Program.cs` para demonstração.

## 🏆 Metodologia de Desafios e Avaliação

Este repositório segue uma metodologia de aprendizado ativa. Para cada princípio, o código na pasta `violacao/` serve como um desafio. Seu objetivo é refatorá-lo e criar a versão da `solucao/`.

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