using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthPrestamos.Models
{
    public class Abono
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cantidad Abono")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal CantidadAbono { get; set; }

        [Required]
        [Display(Name = "Saldo")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Saldo { get; set; }

        [Required]
        [Display(Name = "Fecha Abono")]
        public DateTime Fecha { get; set; }


        [Required]
        public int PrestamoId { get; set; }


        public virtual Prestamo Prestamo { get; set; }

    }
}
