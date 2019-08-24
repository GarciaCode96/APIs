using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Practica.Models
{
    public class CreatePersonaModel
    {
        [Required]
        [StringLength(150)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(100)]
        public string ApellidoPaterno { get; set; }
        [StringLength(100)]
        public string ApellidoMaterno { get; set; }
    }
}
