
namespace Ficheros
{
    partial class FrmAbrirCarpeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCargar = new System.Windows.Forms.TextBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.ListaCarpeta = new System.Windows.Forms.ListBox();
            this.ListaArchivo = new System.Windows.Forms.ListBox();
            this.ListaTexto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar carpeta";
            // 
            // TxtCargar
            // 
            this.TxtCargar.Location = new System.Drawing.Point(170, 60);
            this.TxtCargar.Name = "TxtCargar";
            this.TxtCargar.Size = new System.Drawing.Size(285, 20);
            this.TxtCargar.TabIndex = 1;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(478, 49);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(83, 41);
            this.BtnCargar.TabIndex = 2;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // ListaCarpeta
            // 
            this.ListaCarpeta.FormattingEnabled = true;
            this.ListaCarpeta.Location = new System.Drawing.Point(15, 117);
            this.ListaCarpeta.Name = "ListaCarpeta";
            this.ListaCarpeta.Size = new System.Drawing.Size(180, 225);
            this.ListaCarpeta.TabIndex = 3;
            this.ListaCarpeta.SelectedIndexChanged += new System.EventHandler(this.ListaCarpeta_SelectedIndexChanged);
            // 
            // ListaArchivo
            // 
            this.ListaArchivo.FormattingEnabled = true;
            this.ListaArchivo.Location = new System.Drawing.Point(213, 117);
            this.ListaArchivo.Name = "ListaArchivo";
            this.ListaArchivo.Size = new System.Drawing.Size(180, 225);
            this.ListaArchivo.TabIndex = 4;
            this.ListaArchivo.SelectedIndexChanged += new System.EventHandler(this.ListaArchivo_SelectedIndexChanged);
            // 
            // ListaTexto
            // 
            this.ListaTexto.FormattingEnabled = true;
            this.ListaTexto.Location = new System.Drawing.Point(416, 117);
            this.ListaTexto.Name = "ListaTexto";
            this.ListaTexto.Size = new System.Drawing.Size(191, 225);
            this.ListaTexto.TabIndex = 5;
            // 
            // FrmAbrirCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaTexto);
            this.Controls.Add(this.ListaArchivo);
            this.Controls.Add(this.ListaCarpeta);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TxtCargar);
            this.Controls.Add(this.label1);
            this.Name = "FrmAbrirCarpeta";
            this.Text = "FrmAbrirCarpeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCargar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.ListBox ListaCarpeta;
        private System.Windows.Forms.ListBox ListaArchivo;
        private System.Windows.Forms.ListBox ListaTexto;
    }
}