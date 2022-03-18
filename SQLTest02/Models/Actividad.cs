using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTest02.Models
{
    public class Actividad
    {
        [Key]
        public int Actividad_id { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1024)]
        public string Detalles { get; set; }
        [Display(Name = "Actividad resulta")]
        public bool Resuelto { get; set; }
        [Required]
        public string Estado_id { get; set; }

        [ForeignKey("Estado_id")]
        public Estado Estado { get; set; }
    }
}
