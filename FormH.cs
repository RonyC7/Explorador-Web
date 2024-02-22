using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorador_Web
{
    public partial class FormH : Form
    {
        public FormH(List<string> historial)
        {
            InitializeComponent();

            foreach (string url in historial)
            {
                listBox1.Items.Add(url);
            }
        }

        private void Form1_HistorialActualizado(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        public static class HistorialManager
        {
            public static List<string> Historial { get; } = new List<string>();
            public static Dictionary<string, DateTime> UltimaVisita { get; } = new Dictionary<string, DateTime>();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();

            form1.Show();
        }

        public void MostrarHistorial(Dictionary<string, DateTime> historial)
        {
            foreach (var kvp in historial)
            {
                listBox1.Items.Add($"{kvp.Key}   {kvp.Value.ToShortDateString()}");
            }
        }

        private void ActualizarListBox()
        {
            listBox1.Items.Clear(); 

            foreach (string url in HistorialManager.Historial)
            {
                listBox1.Items.Add(url);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string itemSeleccionado = listBox1.SelectedItem.ToString();

                DialogResult resultado = MessageBox.Show($"¿Seguro que desea eliminar '{itemSeleccionado}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    listBox1.Items.Remove(itemSeleccionado);

                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
