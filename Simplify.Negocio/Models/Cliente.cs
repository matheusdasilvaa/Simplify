using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplify.Negocio.Models
{
    [Table(name: "Clientes")]
    public class Cliente
    {
        /*Dados Pessoais
        public long Id { get; set; }
        public String Nome_dados { get; set; }
        public String Indicacao_dados { get; set; }
        public DateTime Nascimento_dados { get; set; }
        public long CPF_dados { get; set; }
        public long RG_dados { get; set; }
        public String Profissao_dados { get; set; }
        public char Sexo_dados { get; set; }
        public String EstadoCivil_dados { get; set; }
        //Endereço1
        public String Endereco_endereco1 { get; set; }
        public String Rua_endereco1 { get; set; }
        public Int32 Num_endereco1 { get; set; }
        public String Complemento_endereco1 { get; set; }
        public Int32 CEP_endereco1 { get; set; }
        public String Bairro_endereco1 { get; set; }
        public String Cidade_endereco1 { get; set; }
        //Endereço2
        public String Endereco_endereco2 { get; set; }
        public String Rua_endereco2 { get; set; }
        public Int32 Num_endereco2 { get; set; }
        public String Complemento_endereco2 { get; set; }
        public Int32 CEP_endereco2 { get; set; }
        public String Bairro_endereco2 { get; set; }
        public String Cidade_endereco2 { get; set; }
        //Contato
        public Int32 Residencial_contato { get; set; }
        public Int32 Celular1_contato { get; set; }
        public Int32 Celular2_contato { get; set; }
        public Int32 TelTrabalho_contato { get; set; }
        public String Email_contato { get; set; }
        public String Facebook_contato { get; set; }
        public String NomeRecado_contato { get; set; }
        public Int32 TelefoneRecado_contato { get; set; }
        //Ocorrencia
        public DateTime Data_ocorrencia { get; set; }
        public String Local_ocorrencia { get; set; }
        public String Veiculo_ocorrencia { get; set; }
        public String Tipo_ocorrencia { get; set; }
        public String INSS_ocorrencia { get; set; }
        public DateTime Horario_ocorrencia { get; set; }
        public String Lesao_ocorrencia { get; set; }
        public String Socorrista_ocorrencia { get; set; }
        public String Hospital_ocorrencia { get; set; }
        public String Observacao_ocorrencia { get; set; }
        //Observaçoes
        public String Observacao_observacao { get; set; }
        
        */
        //Dados Pessoais
        public String Id { get; set; }
        public String Nome_dados { get; set; }
        public String Indicacao_dados { get; set; }
        public String Nascimento_dados { get; set; }
        public String CPF_dados { get; set; }
        public String RG_dados { get; set; }
        public String Profissao_dados { get; set; }
        public String Sexo_dados { get; set; }
        public String EstadoCivil_dados { get; set; }
        //Endereço1
        public String Endereco_endereco1 { get; set; }
        public String Rua_endereco1 { get; set; }
        public String Num_endereco1 { get; set; }
        public String Complemento_endereco1 { get; set; }
        public String CEP_endereco1 { get; set; }
        public String Bairro_endereco1 { get; set; }
        public String Cidade_endereco1 { get; set; }
        //Endereço2
        public String Endereco_endereco2 { get; set; }
        public String Rua_endereco2 { get; set; }
        public String Num_endereco2 { get; set; }
        public String Complemento_endereco2 { get; set; }
        public String CEP_endereco2 { get; set; }
        public String Bairro_endereco2 { get; set; }
        public String Cidade_endereco2 { get; set; }
        //Contato
        public String Residencial_contato { get; set; }
        public String Celular1_contato { get; set; }
        public String Celular2_contato { get; set; }
        public String TelTrabalho_contato { get; set; }
        public String Email_contato { get; set; }
        public String Facebook_contato { get; set; }
        public String NomeRecado_contato { get; set; }
        public String TelefoneRecado_contato { get; set; }
        //Ocorrencia
        public String Data_ocorrencia { get; set; }
        public String Local_ocorrencia { get; set; }
        public String Veiculo_ocorrencia { get; set; }
        public String Tipo_ocorrencia { get; set; }
        public String INSS_ocorrencia { get; set; }
        public String Horario_ocorrencia { get; set; }
        public String Lesao_ocorrencia { get; set; }
        public String Socorrista_ocorrencia { get; set; }
        public String Hospital_ocorrencia { get; set; }
        public String Observacao_ocorrencia { get; set; }
        //Observaçoes
        public String Observacao_observacao { get; set; }

        [NotMapped]
        public String Descricao
        {
            get
            {
                return this.CPF_dados + " - " + this.Nome_dados;
            }
        }

        public String Descrever()
        {
            return String.Format($"{this.Id} - {this.CPF_dados} - {this.Nome_dados} - {this.Email_contato}");
        }
    }

}
