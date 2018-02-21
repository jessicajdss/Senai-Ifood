using System.Collections.Generic;
using System;

namespace senai.ifood.domain.Entities
{
    public class ClienteDomain:BaseDomain
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public UsuarioDomain usuario { get; set; }

        public int UsuarioId { get; set; }


    }
}