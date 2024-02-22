namespace Explorador_Web
{
    partial class FormH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormH));
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonOrdenV = new System.Windows.Forms.Button();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegresar.Location = new System.Drawing.Point(40, 26);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(90, 27);
            this.buttonRegresar.TabIndex = 0;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(656, 26);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(98, 27);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(40, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(714, 308);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonOrdenV
            // 
            this.buttonOrdenV.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonOrdenV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdenV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrdenV.Location = new System.Drawing.Point(188, 25);
            this.buttonOrdenV.Name = "buttonOrdenV";
            this.buttonOrdenV.Size = new System.Drawing.Size(153, 28);
            this.buttonOrdenV.TabIndex = 3;
            this.buttonOrdenV.Text = "Orden visitada";
            this.buttonOrdenV.UseVisualStyleBackColor = false;
            this.buttonOrdenV.Click += new System.EventHandler(this.buttonOrdenV_Click);
            // 
            // buttonFecha
            // 
            this.buttonFecha.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFecha.Location = new System.Drawing.Point(434, 26);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(152, 28);
            this.buttonFecha.TabIndex = 4;
            this.buttonFecha.Text = "Orden Fecha";
            this.buttonFecha.UseVisualStyleBackColor = false;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // FormH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.buttonFecha);
            this.Controls.Add(this.buttonOrdenV);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormH";
            this.Text = "Historial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonOrdenV;
        private System.Windows.Forms.Button buttonFecha;
    }
}