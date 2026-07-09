using Challenges.Day01_TwoSum;
using FluentAssertions;
using Xunit;

namespace Challenges.Tests;

public class TwoSumTests
{
    [Fact]
    public void TwoSum_ExemploDoEnunciado_DeveRetornarIndicesCorretos()
    {
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;

        var resultado = Solution.TwoSum(nums, target);

        resultado.Should().BeEquivalentTo(new[] { 0, 1 });
    }

    [Fact]
    public void TwoSum_ParNoFinalDoArray_DeveEncontrarIndicesCorretos()
    {
        var nums = new[] { 3, 2, 4 };
        var target = 6;

        var resultado = Solution.TwoSum(nums, target);

        resultado.Should().BeEquivalentTo(new[] { 1, 2 });
    }

    [Fact]
    public void TwoSum_NumerosIguais_DeveRetornarSeusIndices()
    {
        var nums = new[] { 3, 3 };
        var target = 6;

        var resultado = Solution.TwoSum(nums, target);

        resultado.Should().BeEquivalentTo(new[] { 0, 1 });
    }

    [Fact]
    public void TwoSum_ComNumerosNegativos_DeveEncontrarParCorreto()
    {
        var nums = new[] { -1, -2, -3, -4, -5 };
        var target = -8;

        var resultado = Solution.TwoSum(nums, target);

        resultado.Should().BeEquivalentTo(new[] { 2, 4 });
    }

    [Fact]
    public void TwoSum_ComZeroNoArray_DeveEncontrarParCorreto()
    {
        var nums = new[] { 0, 4, 3, 0 };
        var target = 0;

        var resultado = Solution.TwoSum(nums, target);

        resultado.Should().BeEquivalentTo(new[] { 0, 3 });
    }

    [Fact]
    public void TwoSum_ArrayGrande_DeveEncontrarParCorretoEmTempoRazoavel()
    {
        // Array grande o suficiente para expor uma solução O(n²) caso não seja otimizada.
        var nums = Enumerable.Range(1, 10_000).ToArray();
        var target = 19_999; // último elemento + penúltimo

        var resultado = Solution.TwoSum(nums, target);

        resultado.Should().BeEquivalentTo(new[] { 9998, 9999 });
    }

    [Fact]
    public void TwoSum_NaoDeveUsarOMesmoElementoDuasVezes_DeveLancarArgumentException()
    {
        var nums = new[] { 3, 5 };
        var target = 6; // só existe 3+3=6, mas há apenas um "3" no array

        Action act = () => Solution.TwoSum(nums, target);

        act.Should().Throw<ArgumentException>().WithMessage("No two sum solution*");
    }
}