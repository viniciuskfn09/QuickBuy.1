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
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NomeEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }


        //Pedido deve ter pelo menos um item de pedido ou varios itens de pedidos.
        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }


        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedidos.Any())
                AdicionarCritica("Critica-Pedido nao pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("CEP - CEP deve ser preeenchido");
            }
              

        }
    }
}
