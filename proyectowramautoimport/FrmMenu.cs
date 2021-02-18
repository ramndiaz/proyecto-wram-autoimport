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
    public partial class FrmMenu : Form
    {
        basedatos ManipularDatos = new basedatos();
        Boolean editar;
        string id;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcceso frm = new FrmAcceso();
            frm.Show();
            this.Close();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.Show();
            this.Close();
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            frm.Show();
            this.Close();
        }

        private void vEHICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculo frm = new FrmVehiculo();
            frm.Show();
            this.Close();
        }

        private void vERFACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturaComplicada frm = new FrmFacturaComplicada();
            frm.Show();
            this.Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            editar = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fACTURARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturaSencilla frm = new FrmFacturaSencilla();
            frm.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.Show();
            //this.Close();
        }

        private void vEHICULOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmVehiculo frm = new FrmVehiculo();
            frm.Show();
            //this.Close();
        }

        private void eMPLEADOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            frm.Show();
           // this.Close();
        }

        private void pROCESOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturaComplicada frm = new FrmFacturaComplicada();
            frm.Show();
            //this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void aCCESOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcceso frm = new FrmAcceso();
            frm.Show();
            // this.Close();
        }
    }
}
