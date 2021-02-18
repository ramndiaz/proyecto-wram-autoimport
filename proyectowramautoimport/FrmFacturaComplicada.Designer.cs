namespace ProyectoWramAutoImport
{
    partial class FrmFacturaComplicada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.txtbuscarckiente = new System.Windows.Forms.TextBox();
            this.txtbuscarvehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuscarempleado = new System.Windows.Forms.TextBox();
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.txtimpuesto = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtvalorfactura = new System.Windows.Forms.TextBox();
            this.txtidvehiculo = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidfactura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscarfactura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUsarEmpleado = new System.Windows.Forms.Button();
            this.btnUsarVehiculo = new System.Windows.Forms.Button();
            this.btnUsarCliente = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURACION WRAN AUTO IMPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE CLIENTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCliente.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewCliente.Location = new System.Drawing.Point(16, 71);
            this.dataGridViewCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(388, 150);
            this.dataGridViewCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "PLACA VEHICULO";
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.AllowUserToAddRows = false;
            this.dataGridViewVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVehiculo.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(445, 71);
            this.dataGridViewVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.ReadOnly = true;
            this.dataGridViewVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(368, 150);
            this.dataGridViewVehiculo.TabIndex = 4;
            // 
            // txtbuscarckiente
            // 
            this.txtbuscarckiente.Location = new System.Drawing.Point(163, 39);
            this.txtbuscarckiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscarckiente.Name = "txtbuscarckiente";
            this.txtbuscarckiente.Size = new System.Drawing.Size(240, 22);
            this.txtbuscarckiente.TabIndex = 5;
            this.txtbuscarckiente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarckiente_KeyUp);
            // 
            // txtbuscarvehiculo
            // 
            this.txtbuscarvehiculo.Location = new System.Drawing.Point(580, 39);
            this.txtbuscarvehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscarvehiculo.Name = "txtbuscarvehiculo";
            this.txtbuscarvehiculo.Size = new System.Drawing.Size(232, 22);
            this.txtbuscarvehiculo.TabIndex = 6;
            this.txtbuscarvehiculo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtbuscarvehiculo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarvehiculo_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "NOMBRE EMPLEADO";
            // 
            // txtbuscarempleado
            // 
            this.txtbuscarempleado.Location = new System.Drawing.Point(1013, 39);
            this.txtbuscarempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscarempleado.Name = "txtbuscarempleado";
            this.txtbuscarempleado.Size = new System.Drawing.Size(251, 22);
            this.txtbuscarempleado.TabIndex = 8;
            this.txtbuscarempleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarempleado_KeyUp);
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.AllowUserToAddRows = false;
            this.dataGridViewEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmpleado.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(857, 71);
            this.dataGridViewEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.ReadOnly = true;
            this.dataGridViewEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(408, 150);
            this.dataGridViewEmpleado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "IdFactura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "IdEmpleado";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "IdVehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "IdCliente";
            // 
            // txtidempleado
            // 
            this.txtidempleado.Enabled = false;
            this.txtidempleado.Location = new System.Drawing.Point(147, 386);
            this.txtidempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(132, 22);
            this.txtidempleado.TabIndex = 17;
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Enabled = false;
            this.txtimpuesto.Location = new System.Drawing.Point(475, 354);
            this.txtimpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(132, 22);
            this.txtimpuesto.TabIndex = 19;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(475, 322);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(132, 22);
            this.txtcosto.TabIndex = 21;
            this.txtcosto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcosto_KeyUp);
            // 
            // txtvalorfactura
            // 
            this.txtvalorfactura.Enabled = false;
            this.txtvalorfactura.Location = new System.Drawing.Point(475, 386);
            this.txtvalorfactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvalorfactura.Name = "txtvalorfactura";
            this.txtvalorfactura.Size = new System.Drawing.Size(132, 22);
            this.txtvalorfactura.TabIndex = 23;
            // 
            // txtidvehiculo
            // 
            this.txtidvehiculo.Enabled = false;
            this.txtidvehiculo.Location = new System.Drawing.Point(147, 354);
            this.txtidvehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidvehiculo.Name = "txtidvehiculo";
            this.txtidvehiculo.Size = new System.Drawing.Size(132, 22);
            this.txtidvehiculo.TabIndex = 25;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Enabled = false;
            this.txtidcliente.Location = new System.Drawing.Point(147, 322);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(132, 22);
            this.txtidcliente.TabIndex = 27;
            // 
            // txtidfactura
            // 
            this.txtidfactura.Location = new System.Drawing.Point(147, 290);
            this.txtidfactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidfactura.Name = "txtidfactura";
            this.txtidfactura.Size = new System.Drawing.Size(132, 22);
            this.txtidfactura.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Costo Vehiculo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 390);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Valor Factura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 358);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Impuesto";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(1073, 290);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(100, 28);
            this.btnborrar.TabIndex = 98;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(965, 326);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(100, 28);
            this.btnimprimir.TabIndex = 97;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(965, 290);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 96;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(857, 290);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 95;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(857, 326);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 28);
            this.btnvolver.TabIndex = 94;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Location = new System.Drawing.Point(16, 418);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 277);
            this.dataGridView1.TabIndex = 99;
            // 
            // txtbuscarfactura
            // 
            this.txtbuscarfactura.Location = new System.Drawing.Point(808, 386);
            this.txtbuscarfactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscarfactura.Name = "txtbuscarfactura";
            this.txtbuscarfactura.Size = new System.Drawing.Size(179, 22);
            this.txtbuscarfactura.TabIndex = 100;
            this.txtbuscarfactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarfactura_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(657, 391);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 101;
            this.label12.Text = "buscar por id factura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(853, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 102;
            this.label13.Text = "FECHA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1073, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 104;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsarEmpleado
            // 
            this.btnUsarEmpleado.Location = new System.Drawing.Point(1165, 229);
            this.btnUsarEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsarEmpleado.Name = "btnUsarEmpleado";
            this.btnUsarEmpleado.Size = new System.Drawing.Size(100, 28);
            this.btnUsarEmpleado.TabIndex = 106;
            this.btnUsarEmpleado.Text = "usar";
            this.btnUsarEmpleado.UseVisualStyleBackColor = true;
            this.btnUsarEmpleado.Click += new System.EventHandler(this.btnUsarEmpleado_Click);
            // 
            // btnUsarVehiculo
            // 
            this.btnUsarVehiculo.Location = new System.Drawing.Point(713, 229);
            this.btnUsarVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsarVehiculo.Name = "btnUsarVehiculo";
            this.btnUsarVehiculo.Size = new System.Drawing.Size(100, 28);
            this.btnUsarVehiculo.TabIndex = 108;
            this.btnUsarVehiculo.Text = "usar";
            this.btnUsarVehiculo.UseVisualStyleBackColor = true;
            this.btnUsarVehiculo.Click += new System.EventHandler(this.btnUsarVehiculo_Click);
            // 
            // btnUsarCliente
            // 
            this.btnUsarCliente.Location = new System.Drawing.Point(304, 229);
            this.btnUsarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsarCliente.Name = "btnUsarCliente";
            this.btnUsarCliente.Size = new System.Drawing.Size(100, 28);
            this.btnUsarCliente.TabIndex = 110;
            this.btnUsarCliente.Text = "usar";
            this.btnUsarCliente.UseVisualStyleBackColor = true;
            this.btnUsarCliente.Click += new System.EventHandler(this.btnUsarCliente_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 235);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(252, 17);
            this.label14.TabIndex = 111;
            this.label14.Text = "para seleccionar el cliente presione =>";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(441, 235);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(263, 17);
            this.label15.TabIndex = 112;
            this.label15.Text = "para seleccionar el vehiculo presione =>";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(855, 235);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(273, 17);
            this.label16.TabIndex = 113;
            this.label16.Text = "para seleccionar el empleado presione =>";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(999, 9);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 114;
            // 
            // FrmFacturaComplicada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 703);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnUsarCliente);
            this.Controls.Add(this.btnUsarVehiculo);
            this.Controls.Add(this.btnUsarEmpleado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbuscarfactura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtidfactura);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.txtidvehiculo);
            this.Controls.Add(this.txtvalorfactura);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtimpuesto);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewEmpleado);
            this.Controls.Add(this.txtbuscarempleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbuscarvehiculo);
            this.Controls.Add(this.txtbuscarckiente);
            this.Controls.Add(this.dataGridViewVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFacturaComplicada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmFacturaComplicada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
        private System.Windows.Forms.TextBox txtbuscarckiente;
        private System.Windows.Forms.TextBox txtbuscarvehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbuscarempleado;
        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.TextBox txtimpuesto;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtvalorfactura;
        private System.Windows.Forms.TextBox txtidvehiculo;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtidfactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscarfactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUsarEmpleado;
        private System.Windows.Forms.Button btnUsarVehiculo;
        private System.Windows.Forms.Button btnUsarCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}