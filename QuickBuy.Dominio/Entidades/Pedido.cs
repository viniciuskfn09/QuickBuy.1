using QuickBuy.Dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido: Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NomeEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        //Pedido deve ter pelo menos um item de pedido ou varios itens de pedidos.
        public ICollection<ItemPedido> ItensPedidos { get; set; }


        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedidos.Any())
                mensagemValidacao.Add("Critica-Pedido nao pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
            {
                mensagemValidacao.Add("CEP - CEP deve ser preeenchido");
            }
              

        }
    }
}
