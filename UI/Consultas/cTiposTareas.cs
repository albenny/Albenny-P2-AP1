using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Albenny_P2_AP1.BLL;
using Albenny_P2_AP1.Entidades;
using static Albenny_P2_AP1.UI.Registros.rProyectos;

namespace Albenny_P2_AP1.UI.Consultas
{
    public partial class cTiposTareas : Window
    {
        public cTiposTareas()
        {
            InitializeComponent();
            ////—————————————————————————————————————[ VALORES DEL ComboBox ]—————————————————————————————————————
            //FiltroComboBox.SelectedValuePath = "TareaId";
            //FiltroComboBox.DisplayMemberPath = "TipoTarea";
            //FiltroComboBox.ItemsSource = TiposTareasBLL.GetList();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            List<Proyectos> listado = new List<Proyectos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = ProyectosBLL.GetList(p => p.ProyectoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = ProyectosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text, StringComparison.OrdinalIgnoreCase));
                        break;
                }
            }
            else
            {
                listado = ProyectosBLL.GetList(c => true);
            }
            if (DesdeDatePicker.SelectedDate != null)
                listado = (List<Proyectos>)ProyectosBLL.GetList(p => p.Fecha.Date >= DesdeDatePicker.SelectedDate);
            if (HastaDatePicker.SelectedDate != null)
                listado = (List<Proyectos>)ProyectosBLL.GetList(p => p.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}