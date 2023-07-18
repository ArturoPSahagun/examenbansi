using apiexamen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            string msj = CLSExamen.AgregarExamen(AgregarNombreInput.Text, AgregarDescripcionInput.Text);
            MessageBox.Show(msj);
            AgregarNombreInput.Text = "";
            AgregarDescripcionInput.Text = "";
        }

        private void ActualizarBoton_Click(object sender, EventArgs e)
        {
            string msj = CLSExamen.ActualizarExamen(ActualizarIdInput.Text, ActualizarNombreInput.Text, ActualizarDescripcionInput.Text);
            MessageBox.Show(msj);
            ActualizarIdInput.Text = "";
            ActualizarNombreInput.Text = "";
            ActualizarDescripcionInput.Text = "";
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            string msj = CLSExamen.EliminarExamen(EliminarIdInput.Text);
            MessageBox.Show(msj);
            EliminarIdInput.Text = "";
        }

        private void ConsultarBoton_Click(object sender, EventArgs e)
        {
            List<Examen> data = CLSExamen.ConsultarExamen(ConsultarNombreInput.Text, ConsultarDescripcionInput.Text);
            ConsultarGrid.Rows.Clear();
            foreach (var item in data)
            {
                ConsultarGrid.Rows.Add(item.Id, item.Nombre, item.Descripcion);
            }



        }
    }
}
