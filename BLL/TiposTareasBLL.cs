using System;
using System.Collections.Generic;
using System.Text;
//Using agregados
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Albenny_P2_AP1.DAL;
using Albenny_P2_AP1.Entidades;

namespace Albenny_P2_AP1.BLL
{
    public class TiposTareasBLL
    {
        public static List<TiposTareas> GetTiposTareas()
        {
            List<TiposTareas> tiposTareas = new List<TiposTareas>();
            Contexto contexto = new Contexto();

            try
            {
                tiposTareas = contexto.TiposTareas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tiposTareas;
        }
    }
}