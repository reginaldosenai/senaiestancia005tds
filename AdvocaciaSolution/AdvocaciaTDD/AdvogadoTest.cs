using AdvocaciaPrincipal.Modelo;
using System;
using Xunit;

namespace AdvocaciaTDD
{
    public class AdvogadoTest
    {
        [Fact]
        public void MaiorDeIdadeVerdadeiro()
        {
            //Arrange
            Advogado ad = new Advogado();
            ad.Idade = 20;
            bool esperado = true;
            bool resultado = false;
            //act
            resultado = ad.verificarSeAdovagdoEMaiorIdade();

            //assert
            Assert.Equal(esperado, resultado);
        }
    }
}
