using Moq;
using Xunit;

public class ServicoCreditoTests
{
    [Fact]
    public void Deve_RetornarStatus_Apropriado()
    {
        var mock = new Mock<IServicoCredito>();
        mock.Setup(servico => servico.AnaliseCredito(It.IsAny<string>())).Returns("Aprovado");

        var resultado = mock.Object.AnaliseCredito("12345678900");

        Assert.Equal("Aprovado", resultado);
    }
}
