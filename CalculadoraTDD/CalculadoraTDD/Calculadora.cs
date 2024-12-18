namespace CalculadoraTDD
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int valor1, int valor2)
        {
            int result = valor1 + valor2;

            listaHistorico.Insert(0, "Soma: " +  result);
            return result;
        }

        public int Subtratir(int valor1, int valor2)
        {
            int result = valor1 - valor2;

            listaHistorico.Insert(0, "Subtratir: " + result);
            return result;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            int result = valor1 * valor2;

            listaHistorico.Insert(0, "Multiplicar: " + result);
            return result;
        }

        public int Dividir(int valor1, int valor2)
        {
            int result = valor1 / valor2;

            listaHistorico.Insert(0, "Dividir: " + result);
            return result;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
