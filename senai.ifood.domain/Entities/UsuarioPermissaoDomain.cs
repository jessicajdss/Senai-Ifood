using System.Collections.Generic;

namespace senai.ifood.domain.Entities
{
    public class UsuarioPermissaoDomain:BaseDomain
    {
        public UsuarioDomain usuario { get; set; }

        public int UsuarioId { get; set; }

        public PermissaoDomain permissao { get; set; }

        public int PermissaoId { get; set; }

        public ICollection<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }

    }
}