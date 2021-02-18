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
    public partial class FrmFacturaComplicada : Form
    {
        basedatos ManipularDatos = new basedatos();
        Boolean editar;
        string id;
        public FrmFacturaComplicada()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            //FrmMenu frm = new FrmMenu();
            //frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarfactura();
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

        public void limpiarfactura()
        {
            txtbuscarckiente.Clear();
            txtbuscarempleado.Clear();
            txtbuscarfactura.Clear();
            txtbuscarvehiculo.Clear();
            txtcosto.Clear();
            txtidcliente.Clear();
            txtidempleado.Clear();
            txtidfactura.Clear();
            txtidvehiculo.Clear();
            txtimpuesto.Clear();
            txtvalorfactura.Clear();
        }

        private void txtbuscarckiente_KeyUp(object sender, KeyEventArgs e)
        {
            ManipularDatos.ActualizarGridCliente(dataGridViewCliente, "select id, nombre, apellido, cedula from cliente where nombre like '" + txtbuscarckiente.Text + "%';");
        }

        private void txtbuscarvehiculo_KeyUp(object sender, KeyEventArgs e)
        {
            ManipularDatos.ActualizarGridVehiculo(dataGridViewVehiculo, "select id, placa, marca from vehiculo where placa like '" + txtbuscarvehiculo.Text + "%';");
        }

        private void txtbuscarempleado_KeyUp(object sender, KeyEventArgs e)
        {
            ManipularDatos.ActualizarGridEmpleado(dataGridViewEmpleado, "select id, nombre, apellido, posicion from empleado where nombre like '" + txtbuscarempleado.Text + "%';");
        }

        private void txtbuscarfactura_KeyUp(object sender, KeyEventArgs e)
        {
            ManipularDatos.ActualizarGridFactura(dataGridView1, "select * from factura where id like '" + txtbuscarfactura.Text + "%';");
        }

        private void FrmFacturaComplicada_Load(object sender, EventArgs e)
        {
            basedatos DB = new basedatos();
            DB.ActualizarGridFactura(this.dataGridView1, "select * from factura");
            DB.ActualizarGridCliente(this.dataGridViewCliente, "select id, nombre, apellido, cedula from cliente");
            DB.ActualizarGridVehiculo(this.dataGridViewVehiculo, "select id, placa, marca from vehiculo");
            DB.ActualizarGridEmpleado(this.dataGridViewEmpleado, "select id, nombre, apellido, posicion from empleado");
            editar = false;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            editar = true;
            // 1. capturar los datos de la datagrid y asignarlos a las cajas de texto
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtidempleado.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtidcliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtidvehiculo.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //dateTimePicker1.Value.Date = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtvalorfactura.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //esta condicion me permite saber si el usuario ha hecho clic en el boton actualizar

            if (editar)
            {
                ManipularDatos.Conectar();
                string Query = "update factura set id_empleado = '" + txtidempleado.Text + "',id_cliente = '" + txtidcliente.Text + "',id_vehiculo ='" + txtidvehiculo.Text + "',valor = '" + txtvalorfactura.Text + "' where id ='" + id + "'; ";
                ManipularDatos.EjecutarSql(Query);
                ManipularDatos.ActualizarGridFactura(this.dataGridView1, "select * from factura;");
                ManipularDatos.Desconectar();
                limpiarfactura();
                editar = false;
            }
            else
            {
                //1. validar campos

                if (txtidfactura.Text == "" || txtidempleado.Text == "" || txtidcliente.Text == "" || txtidvehiculo.Text == "" || txtcosto.Text == "" )
                {
                    MessageBox.Show("Debes de llenar todos los campos");
                }
                else
                {
                    //si los valores ingresados no son numericos muestra mensaje de error
                    if (!IsNumeric(txtidfactura.Text))
                    {

                        MessageBox.Show("Debe Ingresar Valores Numericos en campo id");
                    }
                    //si no entonces realizo la multiplicacion
                    else
                    {
                        //2. conectarse a la base de datos
                        ManipularDatos.Conectar();

                        //3. armar query
                        string Query = ("insert into factura (id, id_empleado, id_cliente, id_vehiculo, fecha, valor) values ('" + txtidfactura.Text + "','" + txtidempleado.Text + "','" + txtidcliente.Text + "','" + txtidvehiculo.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "','" + txtvalorfactura.Text + "');");

                        //4. ejecutar query
                        ManipularDatos.EjecutarSql(Query);

                        //5. actualizar datagrid
                        ManipularDatos.ActualizarGridFactura(this.dataGridView1, "select * from factura;");

                        //6. desconectarnos de la base de datos
                        ManipularDatos.Desconectar();

                        //7. limpiar formulario
                        limpiarfactura();
                    }
                }
            }
            }

        private void txtcosto_KeyUp(object sender, KeyEventArgs e)
        {

            //si los valores ingresados no son numericos muestra mensaje de error
            if (!IsNumeric(txtcosto.Text))
            {
                
                MessageBox.Show("Debe Ingresar Valores Numericos");
            }
            //si no entonces realizo la multiplicacion
            else
            {
                double costo, impuesto, valor;
                costo = double.Parse(txtcosto.Text);

                costo = double.Parse(txtcosto.Text);
                impuesto = costo * .18;
                valor = impuesto + costo;
                txtimpuesto.Text = impuesto.ToString();
                txtvalorfactura.Text = valor.ToString();
            }
               
        }

        private void btnUsarCliente_Click(object sender, EventArgs e)
        {
            // 1. captura el campo id de la datagrid cliente y lo asigna a la caja de texto id_cliente
            
            txtidcliente.Text = this.dataGridViewCliente.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnUsarVehiculo_Click(object sender, EventArgs e)
        {
            // 1. captura el campo id de la datagrid cliente y lo asigna a la caja de texto id_cliente

            txtidvehiculo.Text = this.dataGridViewVehiculo.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnUsarEmpleado_Click(object sender, EventArgs e)
        {
            // 1. captura el campo id de la datagrid cliente y lo asigna a la caja de texto id_cliente

            txtidempleado.Text = this.dataGridViewEmpleado.CurrentRow.Cells[0].Value.ToString();
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
                string Query = "delete from factura where id = '" + id + "';";

                //3. ejecutar query
                ManipularDatos.EjecutarSql(Query);

                //4. actualizar grid
                ManipularDatos.ActualizarGridFactura(dataGridView1, "select * from factura");

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
