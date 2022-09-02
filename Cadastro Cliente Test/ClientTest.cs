using CadastroCLientes.Models;
using System;
using Xunit;

namespace Cadastro_Cliente_Test
{
    public class ClienteTest
    {
        [Fact]
        public void Idade_VinteAnosDepois_RetornaVinte()
        {
            //Arrange
            Cliente cliente = new Cliente("jose da silva", "jsilva@mail.com", DateTime.Now.AddYears(-20));
            //Act
            var idade = cliente.Idade();
            //Assert
            Assert.Equal(20, idade);
        }

        [Fact]
        public void Idade_VinteAnoseUMdIA_RetornaVinte()
        {
            //Arrange
            Cliente cliente = new Cliente("jose da silva", "jsilva@mail.com", DateTime.Now.AddYears(-20).AddDays(-1));
            //Act
            var idade = cliente.Idade();
            //Assert
            Assert.Equal(20, idade);
        }
        [Fact]
        public void Idade_VinteAnosE365dias_RetornaVinte()
        {
            //Arrange
            Cliente cliente = new Cliente("jose da silva", "jsilva@mail.com", DateTime.Now.AddYears(-20).AddDays(365));
            //Act
            var idade = cliente.Idade();
            //Assert
            Assert.Equal(20, idade);
        }
        [Theory]
        [InlineData("joao","jogo.gol@email.com", "2010, 05,14")]
        [InlineData("","jogo.gol@email.com", "2010, 05,14")]
        [InlineData("joao","", "2010, 05,14")]
        public void AtualizaDados_AlteraNomeEmailNascimento_RetornaAlterado(string nome, string email, DateTime nascimento)
        {
            //Arrange
            Cliente cliente = new Cliente("Jose da Silva", "jsilva@mail.com", new DateTime(2000, 06, 15));
            //ACT
            cliente.AtualizaDados(nome, email, nascimento);
            //Assert
            Assert.Equal(cliente.Nome, nome); 
            Assert.Equal(cliente.Email, email); 
            Assert.Equal(cliente.Nascimento, nascimento);
        }
    }
}
