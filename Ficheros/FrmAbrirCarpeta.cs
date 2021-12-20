using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficheros
{
    public partial class FrmAbrirCarpeta : Form
    {
        public FrmAbrirCarpeta()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
                string Carpeta = this.TxtCargar.Text;
                DirectoryInfo di = new DirectoryInfo(Carpeta);

                //recorre la lista y almacena en lisbox
                this.ListaCarpeta.Items.Clear();
                foreach (var archivo in di.GetDirectories())
                {
                    this.ListaCarpeta.Items.Add(archivo);
                }
        }

        private void ListaCarpeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Carpeta = this.TxtCargar.Text + ListaArchivo.SelectedItem.ToString();
            DirectoryInfo di = new DirectoryInfo(Carpeta);
            this.ListaArchivo.Items.Clear();
            foreach (var archivo in di.GetFiles())
            {

                this.ListaArchivo.Items.Add(archivo);
            }

        }

        private void ListaArchivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string file = this.TxtCargar.Text + ListaCarpeta.SelectedItem.ToString() + ListaArchivo.SelectedItem.ToString();
                FileStream archivo = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(archivo);
                string cad, aux = "";
                cad = sr.ReadLine();
                while (cad != null)
                {
                    aux += cad + Environment.NewLine;
                    cad = sr.ReadLine();
                }
                this.ListaTexto.Text = aux;
                sr.Close();

            }
            catch (IOException e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }


        }
    }
}
