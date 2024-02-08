using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Explorador_Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView2.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
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
        }

        private void NavegarAUrl(string url)
        {
             if (webView2 != null && webView2.CoreWebView2 != null)
    {
        webView2.CoreWebView2.Navigate(url); 
    }
            try
            {
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    if (EsBusqueda(url))
                    {
                        string busqueda = $"https://www.google.com/search?q={Uri.EscapeDataString(url)}";
                        webView2.CoreWebView2.Navigate(comboBox1.Text);
                        AgregarUrlAlComboBox(busqueda);
                        return;
                    }
                    else
                    {
                        url = "https://" + url;
                    }
                }

                webView2.NavigateToString(url);
                AgregarUrlAlComboBox(url);
            }
            catch (UriFormatException)
            {
                MessageBox.Show("La dirección no es válida.");
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

        private void navegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //este se genero automaticamente y no lo puedo eliminar ya que si lo hago genera errores en form1
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
            string selectedUrl = comboBox1.SelectedItem.ToString();
            NavegarAUrl(selectedUrl);
        }
    }
}
