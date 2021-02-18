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
    public partial class FrmAcceso : Form
    {
        basedatos ManipularDatos = new basedatos();
        Boolean editar;
        string id;
        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarAcceso();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            //FrmMenu frm = new FrmMenu();
            //frm.Show();
            this.Close();
        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            basedatos DB = new basedatos();
            DB.ActualizarGridAcceso(this.dataGridView1, "select * from acceso");
            //editar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void bbtnguardar_Click(object sender, EventArgs e)
        {
            //esta condicion me permite saber si el usuario ha hecho clic en el boton actualizar

            if (editar)
            {
                ManipularDatos.Conectar();
                string Query = "update acceso set usuario = '" + txtnombre.Text + "',clave = '" + txtclave.Text + "',id_empleado ='" + txtid_empleado.Text + "' where id ='" + id  + "'; ";
                ManipularDatos.EjecutarSql(Query);
                ManipularDatos.ActualizarGridAcceso(this.dataGridView1, "select * from acceso;");
                ManipularDatos.Desconectar();
                limpiarAcceso();
                editar = false;
            }
            else
            {
                //1. validar campos
                if (txtclave.Text == txtconfirmar.Text)
                {

                    if (txtid.Text == "" || txtnombre.Text == "" || txtclave.Text == "" || txtconfirmar.Text == "" || txtid_empleado.Text == "")
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
                            string Query = ("insert into acceso (id, usuario, clave, id_empleado) values ('" + txtid.Text + "','" + txtnombre.Text + "','" + txtclave.Text + "','" + txtid_empleado.Text + "');");

                            //4. ejecutar query
                            ManipularDatos.EjecutarSql(Query);

                            //5. actualizar datagrid
                            ManipularDatos.ActualizarGridAcceso(this.dataGridView1, "select * from acceso;");

                            //6. desconectarnos de la base de datos
                            ManipularDatos.Desconectar();

                            //7. limpiar formulario
                            limpiarAcceso();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("las contraseñas no coinciden");
                }
            }
        }
        public void limpiarAcceso()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtclave.Clear();
            txtconfirmar.Clear();
            txtid_empleado.Clear();
            txtbuscar.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            editar = true;
            // 1. capturar los datos de la datagrid y asignarlos a las cajas de texto
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtclave.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtid_empleado.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ManipularDatos.ActualizarGridAcceso(dataGridView1,"select * from acceso where usuario like '" + txtbuscar.Text +"%';");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            // capturar el id del usuario
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            //preguntar al usuario si esta seguro de borrar
            var resultado = MessageBox.Show("desea eliminar este registro?","confirme el borrado",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //proceder a evaluar el resultado
            if (resultado == DialogResult.Yes)
            {
                //procedo a hecer el borrado

                //1. me conecto a la base de datos
                ManipularDatos.Conectar();

                //2. armar la query
                string Query = "delete from acceso where id = '" + id + "';";

                //3. ejecutar query
                ManipularDatos.EjecutarSql(Query);

                //4. actualizar grid
                ManipularDatos.ActualizarGridAcceso(dataGridView1, "select * from acceso");

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
