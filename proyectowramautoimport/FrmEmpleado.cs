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
    public partial class FrmEmpleado : Form
    {
        basedatos ManipularDatos = new basedatos();
        Boolean editar;
        string id;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblbuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            basedatos DB = new basedatos();
            DB.ActualizarGridEmpleado(this.dataGridView1, "select * from empleado");
            editar = false;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            //FrmMenu frm = new FrmMenu();
           // frm.Show();
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //esta condicion me permite saber si el usuario ha hecho clic en el boton actualizar

            if (editar)
            {
                ManipularDatos.Conectar();
                string Query = "update empleado set nombre = '" + txtnombre.Text + "',apellido = '" + txtapellido.Text + "',cedula ='" + txtcedula.Text + "',direccion = '" + txtdireccion.Text + "',telefono = '" + txttelefono.Text + "',mail = '" + txtemail.Text + "',posicion = '" + txtposicion.Text + "' where id ='" + id + "'; ";
                ManipularDatos.EjecutarSql(Query);
                ManipularDatos.ActualizarGridAcceso(this.dataGridView1, "select * from empleado;");
                ManipularDatos.Desconectar();
                limpiarEmpleado();
                editar = false;
            }
            else
            {
                //1. validar campos

                if (txtid.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtcedula.Text == "" || txtdireccion.Text == "" || txttelefono.Text == "" || txtemail.Text == "" || txtposicion.Text == "")
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
                        string Query = ("insert into empleado (id, nombre, apellido, cedula, direccion, telefono, mail, posicion) values ('" + txtid.Text + "','" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtcedula.Text + "','" + txtdireccion.Text + "','" + txttelefono.Text + "','" + txtemail.Text + "','" + txtposicion.Text + "');");

                        //4. ejecutar query
                        ManipularDatos.EjecutarSql(Query);

                        //5. actualizar datagrid
                        ManipularDatos.ActualizarGridEmpleado(this.dataGridView1, "select * from empleado;");

                        //6. desconectarnos de la base de datos
                        ManipularDatos.Desconectar();

                        //7. limpiar formulario
                        limpiarEmpleado();
                    }
                }
            }
        }
        public void limpiarEmpleado()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtposicion.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            
            editar = true;
            // 1. capturar los datos de la datagrid y asignarlos a las cajas de texto
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcedula.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdireccion.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txttelefono.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtposicion.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarEmpleado();
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

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ManipularDatos.ActualizarGridAcceso(dataGridView1, "select * from empleado where nombre like '" + txtbuscar.Text + "%';");
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
                string Query = "delete from empleado where id = '" + id + "';";

                //3. ejecutar query
                ManipularDatos.EjecutarSql(Query);

                //4. actualizar grid
                ManipularDatos.ActualizarGridAcceso(dataGridView1, "select * from empleado");

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
