using System;
using System.Collections.Generic;
using System.Text;
//Using agregados
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albenny_P2_AP1.BLL
{
    public class TiposTareas
    {
        [Key]
        public int TareaId { get; set; }
        public string TipoTarea { get; set; }
    }
}