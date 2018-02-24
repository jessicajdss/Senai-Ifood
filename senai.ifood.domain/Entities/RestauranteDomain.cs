using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace senai.ifood.domain.Entities
{
    public class RestauranteDomain:BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Responsavel { get; set; }

        [StringLength(150)]
        public string Site { get; set; }

        [StringLength(25)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [ForeignKey("EspecialidadeId")]
        public EspecialidadeDomain Especialidade { get; set; }
        public int EspecialidadeId { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain usuario { get; set; }
        public int UsuarioId { get; set; }

       public ICollection<ProdutoDomain> ProdutosRestaurantes { get; set; }
        
    }
}