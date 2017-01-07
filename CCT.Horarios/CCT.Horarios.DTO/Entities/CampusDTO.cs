using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CCT.Horarios.DTO.Entities
{
    public class CampusDTO
    {
        [Display(Name = "Identificador")]
        public int id { get; set; }
        [Display(Name="Nome do Campus")]
        public string nome { get; set; }
        [Display(Name = "Sigla do Campus")]
        public string sigla { get; set; }
    }
}
