using System;
using LeilaoOnline.Core;
using Xunit;

namespace LeilaoOnline.UnitTest
{
    public class LeilaoTest
    {
        [Fact]
        public void LeilaoComVariosLances()
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
            
            Assert.Equal(valorEsperado, valorObtido);
        }
        
        [Fact]
        public void LeilaoComUmLance()
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
            
            Assert.Equal(valorEsperado, valorObtido);
        }
        
    }
}