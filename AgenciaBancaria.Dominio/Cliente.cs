using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente //Conceito de emcapsulamento
    {
        public Cliente(string nome, string cpf, string rg, Endereco endereco)
        {
            /*if(string.IsNullOrWhiteSpace(nome)) Verifica se a string nome está vazia.
            {                                  se válido, execulta uma excessão.
                throw new Exception("Campo *Nome* deve está preenchido corretamente. ");
            }*/

            Nome = nome.ValidaStringVazia();
            CPF = cpf.ValidaStringVazia();
            RG = rg.ValidaStringVazia();
            Endereco = endereco ?? throw new Exception("Endereço deve ser informado. ");
        }

        public string Nome { get; private set; } //Propriedade pode ser usada como variável.
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco Endereco { get; private set; }
        
        
    }
}
