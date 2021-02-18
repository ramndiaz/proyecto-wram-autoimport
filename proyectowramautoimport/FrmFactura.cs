using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWramAutoImport
{
    public partial class FrmFactura : Form
    {
        basedatos ManipularDatos = new basedatos();
        Boolean editar;
        string id;
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_EMPLEADOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Close();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            editar = false;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            editar = true;
        }
    }
}
