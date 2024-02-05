using System;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Explorador_Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNavegar_Click(object sender, EventArgs e)
        {
            NavegarAUrl(comboBox1.Text);
        }

        private void NavegarAUrl(string url)
        {
            if (!(url.StartsWith("https://") || url.StartsWith("http://")))
            {
                url = "https://" + url;
            }

            try
            {
                webBrowser1.Navigate(new Uri(url));
                AgregarUrlAlComboBox(url);
            }
            catch (UriFormatException)
            {
                MessageBox.Show("La dirección no es válida.");
            }
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
            
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NavegarAUrl("https://www.mesoamericana.edu.gt/");
        }

        private void haciaAtrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
                comboBox1.Text = webBrowser1.Url.ToString();
            }
        }

        private void haciaAdelanteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
                comboBox1.Text = webBrowser1.Url.ToString();
            }
        }

    }
}
