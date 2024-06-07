using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS.Models
{
    [Table("Tb_Cliente_GS")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Id")]
        [Key]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        [Required]
        public string CPF { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        [Required]
         public int CEP { get; set; }

        [Column("Celular")]
        [Display(Name = "Celular")]
        [Required]
        public string Celular { get; set; }

    }
}
