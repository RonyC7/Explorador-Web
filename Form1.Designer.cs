namespace Explorador_Web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonNavegar = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAdelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 52);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(921, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonNavegar
            // 
            this.buttonNavegar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonNavegar.Location = new System.Drawing.Point(979, 31);
            this.buttonNavegar.Name = "buttonNavegar";
            this.buttonNavegar.Size = new System.Drawing.Size(118, 24);
            this.buttonNavegar.TabIndex = 3;
            this.buttonNavegar.Text = "Ir";
            this.buttonNavegar.UseVisualStyleBackColor = false;
            this.buttonNavegar.Click += new System.EventHandler(this.buttonNavegar_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.haciaAtrasToolStripMenuItem,
            this.haciaAdelanteToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.navegarToolStripMenuItem.Text = "Navegar";
            this.navegarToolStripMenuItem.Click += new System.EventHandler(this.navegarToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click_1);
            // 
            // haciaAtrasToolStripMenuItem
            // 
            this.haciaAtrasToolStripMenuItem.Name = "haciaAtrasToolStripMenuItem";
            this.haciaAtrasToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.haciaAtrasToolStripMenuItem.Text = "Hacia atras";
            this.haciaAtrasToolStripMenuItem.Click += new System.EventHandler(this.haciaAtrasToolStripMenuItem_Click_1);
            // 
            // haciaAdelanteToolStripMenuItem
            // 
            this.haciaAdelanteToolStripMenuItem.Name = "haciaAdelanteToolStripMenuItem";
            this.haciaAdelanteToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.haciaAdelanteToolStripMenuItem.Text = "Hacia adelante";
            this.haciaAdelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaAdelanteToolStripMenuItem_Click_1);
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(12, 93);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(1085, 423);
            this.webView2.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webView2.TabIndex = 6;
            this.webView2.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 528);
            this.Controls.Add(this.webView2);
            this.Controls.Add(this.buttonNavegar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Navegador";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonNavegar;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAdelanteToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    }
}

