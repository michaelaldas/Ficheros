
namespace Ficheros
{
    partial class FrmExplorador
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
            this.TxtCarpeta = new System.Windows.Forms.TextBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.ListaArchivo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpetas";
            // 
            // TxtCarpeta
            // 
            this.TxtCarpeta.Location = new System.Drawing.Point(29, 70);
            this.TxtCarpeta.Name = "TxtCarpeta";
            this.TxtCarpeta.Size = new System.Drawing.Size(248, 20);
            this.TxtCarpeta.TabIndex = 1;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(305, 57);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(67, 33);
            this.BtnCargar.TabIndex = 2;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // ListaArchivo
            // 
            this.ListaArchivo.FormattingEnabled = true;
            this.ListaArchivo.Location = new System.Drawing.Point(29, 153);
            this.ListaArchivo.Name = "ListaArchivo";
            this.ListaArchivo.Size = new System.Drawing.Size(248, 121);
            this.ListaArchivo.TabIndex = 3;
            // 
            // FrmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaArchivo);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TxtCarpeta);
            this.Controls.Add(this.label1);
            this.Name = "FrmExplorador";
            this.Text = "Mi Explorador de Archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCarpeta;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.ListBox ListaArchivo;
    }
}