using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albenny_P2_AP1.Entidades
{
    public class TiposTareas
    {
        [Key]
        public int TipoTareasId { get; set; }
        public string TipoTarea { get; set; }
    }
}