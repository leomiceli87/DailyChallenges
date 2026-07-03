# Daily Challenges

Repositório de desafios diários de programação em .NET, resolvidos como prática pra entrevistas técnicas (LINQ, async/await, estruturas de dados, design de API, etc).

## Estrutura

```
src/Challenges/DayXX_NomeCurto/     -> solução do desafio
tests/Challenges.Tests/DayXX_*.cs   -> testes xUnit correspondentes
```

## Workflow

1. **André abre uma Issue** usando o template "Desafio diário", com o enunciado do dia (`Day XX - Nome`).
2. **Leo cria uma branch** a partir da issue:
   ```
   git checkout -b day-XX-nome-curto
   ```
3. Implementa a solução em `src/Challenges/DayXX_NomeCurto/Solution.cs` e os testes em `tests/Challenges.Tests/DayXX_NomeCurtoTests.cs`.
4. Roda localmente antes de subir:
   ```
   dotnet test
   ```
5. Abre um **Pull Request** referenciando a issue (`Closes #X`). O CI (GitHub Actions) roda build + testes automaticamente.
6. André revisa o PR, comenta, aprova e faz merge.

## Rodando localmente

```
dotnet restore
dotnet build
dotnet test
```

## Convenção de nomes

- Pasta do desafio: `DayXX_NomeCurto` (ex: `Day07_TwoSum`)
- Classe de teste: `DayXX_NomeCurtoTests`
- Numeração sequencial por dia útil de prática, sem pular números mesmo que um desafio seja pulado (documentar no README ou na issue por quê).
