using System;
using System.Collections.Generic;
using System.Linq;
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

        private void buttonOrdenV_Click(object sender, EventArgs e)
        {
            OrdenarHistorialPorVisitas();
        }

        private void OrdenarHistorialPorVisitas()
        {
            var historialOrdenado = HistorialManager.Historial.OrderByDescending(url => {
                if (HistorialManager.ContadorHistorial.TryGetValue(url, out int count))
                {
                    return count;
                }
                return 0;
            }).ToList();

            listBox1.BeginUpdate();
            listBox1.Items.AddRange(historialOrdenado.ToArray());
            listBox1.EndUpdate();
        }

        private IEnumerable<string> ObtenerHistorialOrdenadoPorVisitas()
        {
            var contadorHistorial = HistorialManager.ContadorHistorial;
            return HistorialManager.Historial.OrderByDescending(url => contadorHistorial.ContainsKey(url) ? contadorHistorial[url] : 0);
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
                    Form1.EliminarUrlDelHistorial(itemSeleccionado);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            public static Dictionary<string, int> ContadorHistorial { get; } = new Dictionary<string, int>();
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
            // Lógica para manejar el evento de selección de elementos en el ListBox
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();

            form1.Show();
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            var historial = HistorialManager.Historial;

            historial.Sort((url1, url2) => {
                DateTime fecha1 = HistorialManager.UltimaVisita.TryGetValue(url1, out DateTime lastVisit1) ? lastVisit1 : DateTime.MinValue;
                DateTime fecha2 = HistorialManager.UltimaVisita.TryGetValue(url2, out DateTime lastVisit2) ? lastVisit2 : DateTime.MinValue;
                return fecha2.CompareTo(fecha1);
            });
            listBox1.BeginUpdate();
            listBox1.Items.AddRange(historial.ToArray());
        }

    }
}
