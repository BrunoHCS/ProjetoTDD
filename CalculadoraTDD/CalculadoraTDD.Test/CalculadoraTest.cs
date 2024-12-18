namespace CalculadoraTDD.Test
{
    public class CalculadoraTest
    {
        public Calculadora ConstruirClasse()
        {
            Calculadora calc = new Calculadora();
            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar (int val1, int val2, int res)
        {
            Calculadora calc = ConstruirClasse();

            int result = calc.Somar(val1, val2);

            Assert.Equal(res, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {
            Calculadora calc = ConstruirClasse();

            int result = calc.Multiplicar(val1, val2);

            Assert.Equal(res, result);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, 5, -1)]
        public void TesteSubtratir(int val1, int val2, int res)
        {
            Calculadora calc = ConstruirClasse();

            int result = calc.Subtratir(val1, val2);

            Assert.Equal(res, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDivir(int val1, int val2, int res)
        {
            Calculadora calc = ConstruirClasse();

            int result = calc.Dividir(val1, val2);

            Assert.Equal(res, result);
        }

        [Fact]
        public void TesteDivirPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws <DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 2);
            calc.Somar(3, 4);
            calc.Somar(4, 4);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}