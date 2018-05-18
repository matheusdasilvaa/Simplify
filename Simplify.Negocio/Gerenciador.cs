using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplify.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        public Validacao AdicionarCliente(Cliente clienteAdicionado)
        {
            Validacao validacao = new Validacao();

            // CPF deve conter exatamente 11 NÚMEROS //
            if (clienteAdicionado.CPF = 11)
            {
                validacao.Mensagens.Add("CPF", "O CPF deve conter 11 números");
            }

            // Verifica existência do usuário no sistema //
            if(this.banco.Clientes.Where(c => c.CPF == clienteAdicionado.CPF).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("CPF", "Cliente já cadastrado no sistema");
            }

            // Campo nome é obrigatório //
            if(String.IsNullOrEmpty(clienteAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O campo nome é obrigatório");
            }

            // //
            if(String.IsNullOrEmpty(clienteAdicionado.Email))
            {
                validacao.Mensagens.Add("Email", "O campo email é obrigatório");
            }

            if(!clienteAdicionado.Email.Contains("@") && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Email", "Email inválido");
            }
        }
    }
}
