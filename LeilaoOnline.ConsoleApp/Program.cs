using System;
using LeilaoOnline.Core;

namespace LeilaoOnline.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
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

            if (valorEsperado == valorObtido)
            {
                Console.WriteLine("TEST OK");
            }
            else
            {
                Console.WriteLine("TEST FALHOU");
            }
        }
    }
}