﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario: Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        //Um usuario pode ter um ou varios pedidos.

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email nao foi informado");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha nao foi informada");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome nao foi informado");
            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("Sobrenome nao foi informado");


        }
    }
}
