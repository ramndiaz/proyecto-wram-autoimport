using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoWramAutoImport
{
    public partial class FrmLogin : Form
    {
        basedatos ManipularDatos = new basedatos();
        Boolean editar;
        string id;
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "";
            txtClaveUsuario.Text = "";
            editar = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //1. nos conectamos a la base de datos
            SqlConnection Conexion2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Toshiba\documents\visual studio 2015\Projects\ProyectoWramAutoImport\ProyectoWramAutoImport\DBProyectoWran.mdf;Integrated Security=True");

            //2. nos conectamos
            Conexion2.Open();

            //3. armar la query
            string Query = "select usuario, clave from acceso where usuario = '" + txtNombreUsuario.Text + "' and clave = '" + txtClaveUsuario.Text + "' ;";

            //4. crear objeto comando
            SqlCommand Comando2 = new SqlCommand(Query, Conexion2);

            //5. declarar una variable de tipo reader
            SqlDataReader LectorDatos;

            //.6 ejecutar query
            LectorDatos = Comando2.ExecuteReader();

            //.7 validar si el lector de datos tiene registros
            Boolean ExistenciaRegistros = LectorDatos.HasRows;

            //8. validamos entrada usuario al sistema
            if (ExistenciaRegistros)
            {

                //MessageBox.Show("Bienvenido al sistema");
                //9. cargar el formulario de menu
                
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                //10. en caso que no este registrado
                MessageBox.Show("su usuario o clave no coinciden o no se encuentra registrado");
                limpiarlogin();
                return;
            }

            //.11 desconectarnos de la base de datos
            Conexion2.Close();

            //.12 limpiar formulario
            limpiarlogin();
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpiarlogin()
        {
            txtClaveUsuario.Clear();
            txtNombreUsuario.Clear();
        }

    }
}
