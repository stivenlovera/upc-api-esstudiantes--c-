using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace cumbre_estudiante.Models
{
    public class Estudiante
    {
        [Key]
        public int id { get; set; }
        public int PersonalId { get; set; }
        public int carreraId { get; set; }
        public string matricula { get; set; }
        public bool estado { get; set; }
    }
}
