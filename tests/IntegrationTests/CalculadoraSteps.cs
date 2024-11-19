using TechTalk.SpecFlow;

[Binding]
public class CalculadoraSteps
{
    private int _numero1, _numero2, _resultado;

    [Given(@"o número (.*)")]
    public void DadoONumero(int numero)
    {
        _numero1 = numero;
    }

    [When(@"eu somar os dois")]
    public void QuandoSomarOsDois()
    {
        _resultado = _numero1 + _numero2;
    }

    [Then(@"o resultado deve ser (.*)")]
    public void EntaoOResultadoDeveSer(int esperado)
    {
        Assert.AreEqual(esperado, _resultado);
    }
}
