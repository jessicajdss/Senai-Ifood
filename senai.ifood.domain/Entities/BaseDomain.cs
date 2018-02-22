using System;
using System.ComponentModel.DataAnnotations;

namespace senai.ifood.domain.Entities
{
    public class BaseDomain
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}