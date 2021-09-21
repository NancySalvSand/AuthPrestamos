using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthPrestamos.Models
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cantidad es obligatorio")]
        [Display(Name = "Cantidad")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Cantidad { get; set; }


        [Display(Name = "CantidadInteres")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal CantidadInteres { get; set; }

        [Required]
        public string IdUsuario { get; set; }


        public virtual List<Abono> Abonos { get; set; }




    }
}

