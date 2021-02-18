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
    public partial class FrmVehiculo : Form
    {
        basedatos ManipularDatos = new basedatos();
        Boolean editar;
        string id;
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            //FrmMenu frm = new FrmMenu();
            //frm.Show();
            this.Close();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            basedatos DB = new basedatos();
            DB.ActualizarGridVehiculo(this.dataGridView1, "select * from vehiculo");
            //editar = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //esta condicion me permite saber si el usuario ha hecho clic en el boton actualizar

            if (editar)
            {
                ManipularDatos.Conectar();
                string Query = "update vehiculo set marca = '" + txtmarca.Text + "',modelo = '" + txtmodelo.Text + "',year ='" + txtano.Text + "',color = '" + txtcolor.Text + "',placa = '" + txtplaca.Text + "',matricula = '" + txtmatricula.Text + "',id_cliente = '" + txtid_cliente.Text + "' where id ='" + id + "'; ";
                ManipularDatos.EjecutarSql(Query);
                ManipularDatos.ActualizarGridAcceso(this.dataGridView1, "select * from vehiculo;");
                ManipularDatos.Desconectar();
                limpiarVehiculo();
                editar = false;
            }
            else
            {
                //1. validar campos

                if (txtid.Text == "" || txtmarca.Text == "" || txtmodelo.Text == "" || txtano.Text == "" || txtcolor.Text == "" || txtplaca.Text == "" || txtmatricula.Text == "" || txtid_cliente.Text == "")
                {
                    MessageBox.Show("Debes de llenar todos los campos");
                }
                else
                {
                    //si los valores ingresados no son numericos muestra mensaje de error
                    if (!IsNumeric(txtid.Text))
                    {

                        MessageBox.Show("Debe Ingresar Valores Numericos en campo id");
                    }
                    //si no entonces realizo la multiplicacion
                    else
                    {
                        //2. conectarse a la base de datos
                        ManipularDatos.Conectar();

                        //3. armar query
                        string Query = ("insert into vehiculo (id, marca, modelo, year, color, placa, matricula, id_cliente) values ('" + txtid.Text + "','" + txtmarca.Text + "','" + txtmodelo.Text + "','" + txtano.Text + "','" + txtcolor.Text + "','" + txtplaca.Text + "','" + txtmatricula.Text + "','" + txtid_cliente.Text + "');");

                        //4. ejecutar query
                        ManipularDatos.EjecutarSql(Query);

                        //5. actualizar datagrid
                        ManipularDatos.ActualizarGridVehiculo(this.dataGridView1, "select * from vehiculo;");

                        //6. desconectarnos de la base de datos
                        ManipularDatos.Desconectar();

                        //7. limpiar formulario
                        limpiarVehiculo();
                    }
                }
            }
        }
        public void limpiarVehiculo()
        {
            txtid.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            txtano.Clear();
            txtcolor.Clear();
            txtplaca.Clear();
            txtmatricula.Clear();
            txtid_cliente.Clear();
        }

        public bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            editar = true;
            // 1. capturar los datos de la datagrid y asignarlos a las cajas de texto
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtmarca.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
           txtmodelo.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtano.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtcolor.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtplaca.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtmatricula.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtid_cliente.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarVehiculo();
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ManipularDatos.ActualizarGridAcceso(dataGridView1, "select * from vehiculo where placa like '" + txtbuscar.Text + "%';");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            // capturar el id del usuario
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            //preguntar al usuario si esta seguro de borrar
            var resultado = MessageBox.Show("desea eliminar este registro?", "confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //proceder a evaluar el resultado
            if (resultado == DialogResult.Yes)
            {
                //procedo a hecer el borrado

                //1. me conecto a la base de datos
                ManipularDatos.Conectar();

                //2. armar la query
                string Query = "delete from vehiculo where id = '" + id + "';";

                //3. ejecutar query
                ManipularDatos.EjecutarSql(Query);

                //4. actualizar grid
                ManipularDatos.ActualizarGridAcceso(dataGridView1, "select * from vehiculo");

                //5. desconectarnos de la base de datos
                ManipularDatos.Desconectar();
            }
            else
            {
                //no pasa nada
                return;
            }
        }
    }
}
