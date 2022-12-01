using AdvocaciaPrincipal.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdvocaciaTDD
{
    public class TratamentoDeTextoTDD
    {
      [Fact]
      public void RetornarQtdTextoSENAI()
      {
            //Arrange
            int esperado = 5;
            int resultado = 0;

            //Act
            TratamentoDeTexto tratamento = new TratamentoDeTexto();
            resultado = tratamento.qtdDeTexto("SEMAI");
            
            //Assert
            Assert.Equal(esperado, resultado);
      }

        [Fact]
        public void VerificarSesitrocadoPorSenainoTexto()
        {
            //Arrange
            string conteudo = "Escola SESI em Estância";
            string esperado = "Escola SENAI em Estância";
            string resultado;
            //Act
            TratamentoDeTexto tratamento = new TratamentoDeTexto();
            resultado = tratamento.TextoAlterado("SESI","SENAI", conteudo);

            //Assert
            Assert.Equal(esperado, resultado);

        }
    }
}
