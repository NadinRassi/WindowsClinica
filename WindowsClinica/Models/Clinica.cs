using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WindowsClinica.Models
{
    public class Clinica
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        public string Nombre { get; set; }

        public DateTime FechaInicioActividades { get; set; }
    }
}
