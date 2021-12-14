
namespace Ficheros
{
    partial class FrmLectura
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtArchivo = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnLeer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre del archivo:";
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Location = new System.Drawing.Point(222, 34);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(261, 20);
            this.TxtArchivo.TabIndex = 1;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(15, 124);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultado.Size = new System.Drawing.Size(575, 146);
            this.TxtResultado.TabIndex = 2;
            // 
            // BtnLeer
            // 
            this.BtnLeer.Location = new System.Drawing.Point(15, 80);
            this.BtnLeer.Name = "BtnLeer";
            this.BtnLeer.Size = new System.Drawing.Size(103, 38);
            this.BtnLeer.TabIndex = 3;
            this.BtnLeer.Text = "Calcular Archivo";
            this.BtnLeer.UseVisualStyleBackColor = true;
            this.BtnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.Location = new System.Drawing.Point(515, 27);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(75, 37);
            this.BtnAbrir.TabIndex = 4;
            this.BtnAbrir.Text = "......";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // FrmLectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.BtnLeer);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtArchivo);
            this.Controls.Add(this.label1);
            this.Name = "FrmLectura";
            this.Text = "Lectura de un archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtArchivo;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnLeer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnAbrir;
    }
}

