using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Explorador_Web
{
    public partial class Form1 : Form
    {
        private readonly List<string> historial = new List<string>();
        private Dictionary<string, Tuple<int, DateTime>> contadorHistorial = new Dictionary<string, Tuple<int, DateTime>>();
        private readonly Dictionary<string, DateTime> ultimaVisita = new Dictionary<string, DateTime>();
        public event EventHandler HistorialActualizado;


        public static class HistorialManager
        {
            public static List<string> Historial { get; } = new List<string>();
            public static Dictionary<string, DateTime> UltimaVisita { get; } = new Dictionary<string, DateTime>();
        }

        public Form1()
        {
            InitializeComponent();
            webView2.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
            CargarHistorial();
        }

        private void GuardarH(string fileName, string texto)
        {
            if (!File.ReadAllLines(fileName).Contains(texto))
            {
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine(texto);
                }
            }
        }

        private void WebView2_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webView2.CoreWebView2.Navigate("https://www.mesoamericana.edu.gt/");
        }

        private void buttonNavegar_Click(object sender, EventArgs e)
        {

            string input = comboBox1.Text;

            if (Uri.IsWellFormedUriString(input, UriKind.Absolute))
            {
                NavegarAUrl(input);
            }
            else
            {
                if (EsBusqueda(input))
                {
                    string busqueda = $"https://www.google.com/search?q={Uri.EscapeDataString(input)}";
                    webView2.CoreWebView2.Navigate(busqueda);
                    AgregarUrlAlComboBox(busqueda);
                }
                else
                {
                    string urlCompleta = "https://" + input;
                    webView2.CoreWebView2.Navigate(urlCompleta);
                    AgregarUrlAlComboBox(urlCompleta);
                }
            }
            string selectedUrl = comboBox1.Text;
            if (!HistorialManager.Historial.Contains(selectedUrl))
            {
                HistorialManager.Historial.Add(selectedUrl);
            }
            HistorialManager.UltimaVisita[selectedUrl] = DateTime.Now;

            GuardarH("Historial.txt", selectedUrl);

            OrdenarHistorial();

        }

        private void NavegarAUrl(string url)
        {
            try
            {
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "https://" + url;
                }

                if (webView2 != null && webView2.CoreWebView2 != null)
                {
                    webView2.CoreWebView2.Navigate(url);
                    AgregarUrlAlComboBox(url);
                }
                else
                {
                    MessageBox.Show("El control WebView2 no está inicializado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al navegar a la dirección: {ex.Message}");
            }
        }

        private bool EsBusqueda(string url)
        {
            return !url.Contains(".") && !url.StartsWith("http://") && !url.StartsWith("https://");
        }

        private void AgregarUrlAlComboBox(string url)
        {
            if (!comboBox1.Items.Contains(url))
            {
                comboBox1.Items.Add(url);
            }
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string urlInicio = "https://www.mesoamericana.edu.gt/";
            webView2.CoreWebView2.Navigate(urlInicio);
        }

        private void haciaAtrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (webView2.CanGoBack)
            {
                webView2.GoBack();
                comboBox1.Text = webView2.ToString();
            }
        }

        private void haciaAdelanteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (webView2.CanGoForward)
            {
                webView2.GoForward();
                comboBox1.Text = webView2.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedUrl = comboBox1.SelectedItem.ToString();
                NavegarAUrl(selectedUrl);

                if (!HistorialManager.Historial.Contains(selectedUrl))
                {
                    HistorialManager.Historial.Add(selectedUrl);
                    HistorialManager.UltimaVisita[selectedUrl] = DateTime.Now;
                    if (HistorialManager.Historial.Count > 10)
                    {
                        HistorialManager.Historial.RemoveAt(0);
                    }
                }
                else
                {
                    HistorialManager.UltimaVisita[selectedUrl] = DateTime.Now;
                }

                OrdenarHistorial();
                OnHistorialActualizado();
            }
        }

        protected virtual void OnHistorialActualizado()
        {
            HistorialActualizado?.Invoke(this, EventArgs.Empty);
        }



        private void GuardarHistorial()
{
    using (StreamWriter writer = new StreamWriter("Historial.txt"))
    {
        foreach (var url in historial)
        {
            writer.WriteLine($"{url}|{ultimaVisita[url]}");
        }
    }
}


        private void CargarHistorial()
        {
            if (File.Exists("Historial.txt"))
            {
                var lines = File.ReadAllLines("Historial.txt");
                foreach (string line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        historial.Add(parts[0]);
                        ultimaVisita[parts[0]] = DateTime.Parse(parts[1]);
                        comboBox1.Items.Add(parts[0]);
                    }
                }
            }
        }


        private void OrdenarHistorial()
        {
            var historialOrdenado = historial.OrderByDescending(url => contadorHistorial.ContainsKey(url) ? contadorHistorial[url].Item2 : DateTime.MinValue);

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(historialOrdenado.ToArray());
        }


        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenarHistorial();
        }

        
        private void AgregarUrlAlHistorial(string url)
        {
            if (contadorHistorial.ContainsKey(url))
            {
                var contadorFecha = contadorHistorial[url];
                contadorHistorial[url] = Tuple.Create(contadorFecha.Item1 + 1, DateTime.Now); 
            }
            else
            {
                contadorHistorial[url] = Tuple.Create(1, DateTime.Now); 
            }
        }

        private void navegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //este se genero automaticamente y no lo puedo eliminar ya que si lo hago genera errores en form1
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FormH formH = new FormH(HistorialManager.Historial);

            formH.Show();

            this.Hide();
        }


    }
}
