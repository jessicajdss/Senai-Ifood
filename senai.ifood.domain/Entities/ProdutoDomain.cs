using System;
using System.Collections.Generic;

namespace senai.ifood.domain.Entities
{
    public class ProdutoDomain:BaseDomain
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public Boolean Ativo { get; set; }

        public RestauranteDomain Restaurante { get; set; }

        public int RestauranteId { get; set; }

        public ICollection<RestauranteDomain> Restaurantes { get; set; }

    }
}