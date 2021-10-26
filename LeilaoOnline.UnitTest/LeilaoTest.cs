using System;
using LeilaoOnline.Core;
using Xunit;

namespace LeilaoOnline.UnitTest
{
    public class LeilaoTest
    {
        [Fact]
        public void LeilaoComVariosLances_ComValorEsperado()
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
        public void LeilaoComVariosLances_ComValorNaoEsperado()
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
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;
            
            Assert.NotEqual(valorEsperado, valorObtido);
        }

        
        [Fact]
        public void LeilaoComUmLance_ComValorEsperado()
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
            Assert.NotEmpty(leilao.Ganhador.Cliente.Nome);
            Assert.Equal("Jorge", leilao.Ganhador.Cliente.Nome);
        }
        
    }
}