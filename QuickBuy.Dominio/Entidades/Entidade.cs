using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        protected List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        public void AdicionarCritica(string mensagem)
            => mensagemValidacao.Add(mensagem);

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
        //Se nao tiver nenhuma mensagem de validacao que foi violada entao a classe é considerada como valida.



    }
}
