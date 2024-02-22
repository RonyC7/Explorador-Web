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

        private void MostrarHistorial()
        {
            listBox1.Items.Clear();
            foreach (var kvp in HistorialManager.UltimaVisita)
            {
                listBox1.Items.Add($"{kvp.Key} - Última visita: {kvp.Value}");
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
    }
}
