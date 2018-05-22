using System;
using Simplify.Negocio.Models;
using Simplify.Negocio.Persistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplify.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        // ADICIONAR CLIENTE //
        public Validacao AdicionarCliente(Cliente clienteAdicionado)
        {
            
            Validacao validacao = new Validacao();

            if (String.IsNullOrEmpty(clienteAdicionado.Nome_dados))
            {
                validacao.Mensagens.Add("Nome_dados", "O nome não pode ser nulo ou vazio");
            }

            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }
                
            return validacao;
            
        }
        
        // ALTERAR CLIENTE //
        public Validacao AlterarCliente(Cliente clienteAlterado)
        {
            Validacao validacao = new Validacao();

            return validacao;
        }

        // REMOVER CLIENTE//
        public Validacao RemoverCliente(Cliente cliente)
        {
            Validacao validacao = new Validacao();
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();

            return validacao;
        }
    }
}
