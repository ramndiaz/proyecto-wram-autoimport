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
    public partial class FrmFacturaSencilla : Form
    {
        public FrmFacturaSencilla()
        {
            InitializeComponent();
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBProyectoWranDataSet);

        }

        private void FrmFacturaSencilla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoWranDataSet.factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.dBProyectoWranDataSet.factura);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Close();
        }
    }
}
