using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClinica.Models
{
    public class Habitacion
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        [Required]
        public string Estado { get; set; }

        public string Descripcion { get; set;}
    }
}
