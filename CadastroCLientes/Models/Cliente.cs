using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCLientes.Models
{
    public class Cliente
    {
        public Cliente(string nome, string email, DateTime nascimento)
        {
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
        }

        public int Id { get; private set; }
        [Required(ErrorMessage = "Nome Obrigatório!")]
        public string Nome { get; private set; }
        [Required(ErrorMessage ="Email Obrigatório!")]
        public string Email { get; private set; }
        [Required(ErrorMessage ="Data de Nascimento Obrigatório!")]
        public DateTime Nascimento { get; private set; }
        public int Idade()
        {
            int idade = DateTime.Now.Year - Nascimento.Year;
            if (DateTime.Now.DayOfYear < Nascimento.DayOfYear)
                idade--;
            return idade;
        }
        public void AtualizaDados(string nome, string email, DateTime nascimento)
        {
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
           
        }
    }
}
