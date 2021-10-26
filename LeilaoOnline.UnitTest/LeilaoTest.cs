using System;
using Xunit;

namespace LeilaoOnline.UnitTest
{
    public class LeilaoTest
    {
        [Fact]
        public void LeilaoComVariosLances()
        {
        }
        
        [Fact]
        public void LeilaoComUmLance()
        {
        }
        
        private static void VerifyLeilao(double valorEsperado, double valorObtido)
        {
            if (valorEsperado == valorObtido)
                Console.WriteLine("TEST OK");
            else
                Console.WriteLine($"TEST FALHOU! Valor Esperado:{valorEsperado}, Valor Obtido: {valorObtido}");
        }
    }
}