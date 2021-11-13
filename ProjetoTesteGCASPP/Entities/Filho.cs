using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTesteGCASPP.Entities
{
   public class Filho
    {
        [Key]
        public int FilhoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int FuncionarioId { get; set; }

        [ForeignKey("FuncionarioId")]
        public virtual Funcionario Funcionario { get; set; }
    }
}
