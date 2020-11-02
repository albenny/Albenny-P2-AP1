using System;
using System.Collections.Generic;
using System.Text;
//Using agregados
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Albenny_P2_AP1.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int ProyectosDetalleId { get; set; }
        public int ProyectoId { get; set; }
        public int TareaId { get; set; }
        public string Requerimiento { get; set; }
        public double Tiempo { get; set; }

        //———————————————————————————[ ForeingKeys ]———————————————————————————
        [ForeignKey("TareaId")]
        public BLL.TiposTareas tiposTareas { get; set; } = new BLL.TiposTareas();
    }
}