using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ficheros
{
    public partial class FrmLectura : Form
    {
        public FrmLectura()
        {
            InitializeComponent();
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            // apertura del archivo
            try
            {
                string file = this.TxtArchivo.Text;
                FileStream archivo = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(archivo);

                //Lectura de la primera linea del archivo
                string cad, aux = "";
                cad = sr.ReadLine();
                while (cad != null)
                {
                    aux += cad;
                    cad = sr.ReadLine();
                }
                this.TxtResultado.Text = aux;
                //Crear el flujo
                sr.Close();
            }catch(IOException e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }
            
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lectura de archivo Texto";
            openFileDialog1.InitialDirectory = @"c:\ tmp";
            openFileDialog1.Filter = "txt files(*.txt |*,txt";

            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                this.TxtArchivo.Text = openFileDialog1.FileName;
            }
            else
            {
                this.TxtArchivo.Text = "";
            }
        }
    }
}
