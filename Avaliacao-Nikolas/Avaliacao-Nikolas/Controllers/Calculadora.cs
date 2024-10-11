using Microsoft.AspNetCore.Mvc;
using Avaliacao_Nikolas.Services;

namespace Avaliacao_Nikolas.Controllers
{
    public class Calculadora : Controller
    {
        private readonly CalculadoraService _calculadoraService;

        public Calculadora()
        {
            _calculadoraService = new CalculadoraService();
        }

        public IActionResult RealizarSoma(int a, int b)
        {
            var resultado = _calculadoraService.Somar(a, b);
            return View("Resultado", $"O resultado da soma é: {resultado}");
        }

        public IActionResult RealizarSubtracao(int a, int b)
        {
            var resultado = _calculadoraService.Subtrair(a, b);
            return View("Resultado", $"O resultado da subtração é: {resultado}");
        }

        public IActionResult RealizarMultiplicacao(int a, int b)
        {
            var resultado = _calculadoraService.Multiplicar(a, b);
            return View("Resultado", $"O resultado da multiplicação é: {resultado}");
        }

        public IActionResult RealizarDivisao(int a, int b)
        {
            try
            {
                var resultado = _calculadoraService.Dividir(a, b);
                return View("Resultado", $"O resultado da divisão é: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                return View("Resultado", ex.Message);
            }
        }
    }
}
