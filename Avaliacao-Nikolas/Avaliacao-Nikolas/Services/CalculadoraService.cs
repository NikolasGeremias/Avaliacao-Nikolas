namespace Avaliacao_Nikolas.Services
{
    public class CalculadoraService
    {
        public int Somar(int a, int b) => a + b;

        public int Subtrair(int a, int b) => a - b;

        public int Multiplicar(int a, int b) => a * b;

        public double Dividir(int a, int b) => b != 0 ? (double)a / b : throw new DivideByZeroException("Divisão por zero não é permitida.");
    }
}
