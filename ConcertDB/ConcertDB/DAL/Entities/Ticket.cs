using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Ticket
    {
        [Display(Name = "Código")]
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de Uso")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Disponibilidad de la Boleta")]
        public Boolean IsUsed { get; set; }

        [Display(Name = "Porteria de Ingreso")]
        public String? EntranceGate { get; set; }    

    }
}
