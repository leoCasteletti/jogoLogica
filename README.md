# Jogo de Lógica

Aplicação desktop em **C# / Windows Forms** com persistência em **SQL Server**.
Feita como avaliação da disciplina de Técnicas de Linguagem de Programação II.

O jogador informa um nome e tenta adivinhar o número associado a ele.
A regra: quantidade de letras do nome, ao quadrado. Cada tentativa fica salva e aparece no histórico.

## Estrutura

| Arquivo | Papel |
|---|---|
| `Form1.cs` | Tela e eventos |
| `MovimentoJogo.cs` | Regra do jogo |
| `Resultado.cs` | Modelo da tabela `Resultados` |
| `JogoDAO.cs` | Inserção e listagem com Dapper |
| `Conexao.cs` | Conexão com o SQL Server |
| `database.sql` | Criação do banco e da tabela |

## Rodando

1. Executar `database.sql` no SQL Server local
2. Abrir `src/ProvaTLPII_2B_107081.sln` no Visual Studio
3. Instalar o pacote **Dapper** pelo NuGet
4. F5

## Stack

C# · .NET Framework 4.7.2 · Windows Forms · SQL Server · Dapper
