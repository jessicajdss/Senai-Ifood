using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class UsuarioPermissaoDomain:BaseDomain
    {

        [ForeignKey("UsuarioId")]
        public UsuarioDomain usuario { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("PermissaoId")]
        public PermissaoDomain permissao { get; set; }
        public int PermissaoId { get; set; }

        public ICollection<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }

    }
}