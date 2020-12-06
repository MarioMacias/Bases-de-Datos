using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class CambiaNombre : Form
    {
        public CambiaNombre()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string regresaNuevoNombre()
        {
            string modificaDB = "";
            modificaDB = tBNuevoNombre.Text;
            return modificaDB;
        }
    }
}
