using System;
using LeilaoOnline.Core;

namespace LeilaoOnline.ConsoleApp
{
    class Program
    {
        private static void VerifyLeilao(double valorEsperado, double valorObtido)
        {
            var cor = Console.ForegroundColor;
            
            if (valorEsperado == valorObtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TEST OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TEST FALHOU! Valor Esperado:{valorEsperado}, Valor Obtido: {valorObtido}");
            }

            Console.ForegroundColor = cor;
        }
        
        private static void LeilaoComVariosLances()
        {
            // Arange
            var leilao = new Leilao("Dr Cash");
            var jorge = new Interessada("Jorge", leilao);
            var maria = new Interessada("Maria", leilao);
            
            leilao.RecebeLance(jorge, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(jorge, 1000);
            leilao.RecebeLance(maria, 950);

            // Act
            leilao.TerminaPregao();
            
            // Assert
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;
            
            VerifyLeilao(valorEsperado, valorObtido);
        }
        
        private static void LeilaoComUmLance()
        {
            // Arange
            var leilao = new Leilao("Dr Cash");
            var jorge = new Interessada("Jorge", leilao);
            
            leilao.RecebeLance(jorge, 800);

            // Act
            leilao.TerminaPregao();
            
            // Assert
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;
            
            VerifyLeilao(valorEsperado, valorObtido);
        }
        static void Main(string[] args)
        {
            LeilaoComVariosLances();
            LeilaoComUmLance();
        }
    }
}