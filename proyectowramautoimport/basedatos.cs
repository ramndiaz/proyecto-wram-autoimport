using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoWramAutoImport
{
    class basedatos
    {
        SqlConnection MiConexion;
        SqlDataReader LectorDatos;
        

        public void Conectar()
        {
            MiConexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Toshiba\documents\visual studio 2015\Projects\ProyectoWramAutoImport\ProyectoWramAutoImport\DBProyectoWran.mdf;Integrated Security=True");
            MiConexion.Open();
        }
        public void Desconectar()
        {
            MiConexion.Close();
        }
        public void EjecutarSql(string Query)
        {
            SqlCommand MiComando = new SqlCommand(Query, this.MiConexion);
            int FilasAfectadas = MiComando.ExecuteNonQuery();

            if (FilasAfectadas > 0)
            {
                MessageBox.Show("Operacion realizada con exito", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void llenarItems(ComboBox cb, String Query)
        {
            this.Conectar();
            EjecutarSql(Query);
            this.Desconectar();
        }

       

        public void ActualizarGridAcceso(DataGridView dg, string Query)
        {
            //conectarnos a la base de dato s
            this.Conectar();

            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            //crear adaptador de datos
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query, MiConexion);


            //llenar DataSet
            MiDataAdapter.Fill(MiDataSet, "acceso");

            //asignarle el valor adecuado a las propiedades del DataGrid

            dg.DataSource = MiDataSet;
            dg.DataMember = "acceso";

            //nos desconectamos de la base de datos
            this.Desconectar();
        }
        public void ActualizarGridCliente(DataGridView dg, string Query)
        {
            //conectarnos a la base de datos
            this.Conectar();

            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            //crear adaptador de datos
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query, MiConexion);


            //llenar DataSet
            MiDataAdapter.Fill(MiDataSet, "cliente");

            //asignarle el valor adecuado a las propiedades del DataGrid

            dg.DataSource = MiDataSet;
            dg.DataMember = "cliente";

            //nos desconectamos de la base de datos
            this.Desconectar();
        }
        public void ActualizarGridEmpleado(DataGridView dg, string Query)
        {
            //conectarnos a la base de datos
            this.Conectar();

            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            //crear adaptador de datos
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query, MiConexion);


            //llenar DataSet
            MiDataAdapter.Fill(MiDataSet, "empleado");

            //asignarle el valor adecuado a las propiedades del DataGrid

            dg.DataSource = MiDataSet;
            dg.DataMember = "empleado";

            //nos desconectamos de la base de datos
            this.Desconectar();
        }
        public void ActualizarGridFactura(DataGridView dg, string Query)
        {
            //conectarnos a la base de datos
            this.Conectar();

            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            //crear adaptador de datos
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query, MiConexion);


            //llenar DataSet
            MiDataAdapter.Fill(MiDataSet, "factura");

            //asignarle el valor adecuado a las propiedades del DataGrid

            dg.DataSource = MiDataSet;
            dg.DataMember = "factura";

            //nos desconectamos de la base de datos
            this.Desconectar();
        }
        public void ActualizarGridVehiculo(DataGridView dg, string Query)
        {
            //conectarnos a la base de datos
            this.Conectar();

            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            //crear adaptador de datos
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query, MiConexion);


            //llenar DataSet
            MiDataAdapter.Fill(MiDataSet, "vehiculo");

            //asignarle el valor adecuado a las propiedades del DataGrid

            dg.DataSource = MiDataSet;
            dg.DataMember = "vehiculo";

            //nos desconectamos de la base de datos
            this.Desconectar();
        }
        //metodo para validar si los valores son numericos
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
    }
}
