using Xunit;

public class ConversorTemperaturaTests
{
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    public void TestarConversaoDeFahrenheitParaCelsius(double fahrenheit, double celsiusEsperado)
    {
        var resultado = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
        Assert.Equal(celsiusEsperado, resultado);
    }
}
