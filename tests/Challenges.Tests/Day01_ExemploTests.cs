using Challenges.Day01_Exemplo;
using FluentAssertions;
using Xunit;

namespace Challenges.Tests;

public class Day01_ExemploTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Somar_DeveRetornarSomaCorreta(int a, int b, int esperado)
    {
        var resultado = Solution.Somar(a, b);

        resultado.Should().Be(esperado);
    }
}
