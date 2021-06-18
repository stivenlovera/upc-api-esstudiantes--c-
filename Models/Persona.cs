using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cumbre_estudiante.Models
{
  
    public class Persona
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correoPeronal { get; set; }
        public string celular { get; set; }
        public string dirrecion { get; set; }
        public string carnet { get; set; }
        public DateTime fechaNac { get; set; }
        public string estado { get; set; }
    }
}
