using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace APIJuego.Models
{
    public class Juego
    {
        [Key]
        public int IdJuego { get; set; }
        [Required]
        public DateTime fechaganada { get; set; }

        
    }

}
