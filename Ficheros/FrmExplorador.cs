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
    public partial class FrmExplorador : Form
    {
        public FrmExplorador()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            string carpeta = this.TxtCarpeta.Text;
            DirectoryInfo di = new DirectoryInfo(carpeta);

            //recorro la lista de archivo y lo almaceno en la Listabox
            this.ListaArchivo.Items.Clear();
            foreach(var archivo in di.GetFiles())
            {
                this.ListaArchivo.Items.Add(archivo);
            }
        }
    }
}
