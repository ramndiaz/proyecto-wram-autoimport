namespace ProyectoWramAutoImport
{
    partial class FrmVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblid_cliente = new System.Windows.Forms.Label();
            this.txtid_cliente = new System.Windows.Forms.TextBox();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(525, 279);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(114, 17);
            this.lblbuscar.TabIndex = 56;
            this.lblbuscar.Text = "buscar por placa";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(683, 276);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(269, 22);
            this.txtbuscar.TabIndex = 55;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 314);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 347);
            this.dataGridView1.TabIndex = 54;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(261, 84);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(691, 22);
            this.txtmodelo.TabIndex = 53;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(261, 20);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(691, 22);
            this.txtid.TabIndex = 52;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(261, 116);
            this.txtano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(691, 22);
            this.txtano.TabIndex = 51;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(261, 148);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(691, 22);
            this.txtcolor.TabIndex = 50;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(261, 180);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(691, 22);
            this.txtplaca.TabIndex = 49;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(261, 212);
            this.txtmatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(691, 22);
            this.txtmatricula.TabIndex = 48;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(261, 52);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(691, 22);
            this.txtmarca.TabIndex = 47;
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Location = new System.Drawing.Point(16, 215);
            this.lblmatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(65, 17);
            this.lblmatricula.TabIndex = 46;
            this.lblmatricula.Text = "Matricula";
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(16, 183);
            this.lblplaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(43, 17);
            this.lblplaca.TabIndex = 45;
            this.lblplaca.Text = "Placa";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(16, 151);
            this.lblcolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(41, 17);
            this.lblcolor.TabIndex = 44;
            this.lblcolor.Text = "Color";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(16, 119);
            this.lblano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(33, 17);
            this.lblano.TabIndex = 43;
            this.lblano.Text = "Ano";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(16, 87);
            this.lblmodelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(54, 17);
            this.lblmodelo.TabIndex = 42;
            this.lblmodelo.Text = "Modelo";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(16, 23);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(79, 17);
            this.lblid.TabIndex = 41;
            this.lblid.Text = "id_vehiculo";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(16, 55);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(47, 17);
            this.lblmarca.TabIndex = 40;
            this.lblmarca.Text = "Marca";
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(1080, 118);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 28);
            this.btnvolver.TabIndex = 39;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(1080, 82);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 38;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(1080, 11);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiar.TabIndex = 37;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(1080, 47);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 36;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblid_cliente
            // 
            this.lblid_cliente.AutoSize = true;
            this.lblid_cliente.Location = new System.Drawing.Point(16, 247);
            this.lblid_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid_cliente.Name = "lblid_cliente";
            this.lblid_cliente.Size = new System.Drawing.Size(68, 17);
            this.lblid_cliente.TabIndex = 57;
            this.lblid_cliente.Text = "id_cliente";
            // 
            // txtid_cliente
            // 
            this.txtid_cliente.Location = new System.Drawing.Point(261, 244);
            this.txtid_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid_cliente.Name = "txtid_cliente";
            this.txtid_cliente.Size = new System.Drawing.Size(691, 22);
            this.txtid_cliente.TabIndex = 58;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(1080, 154);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(100, 28);
            this.btnborrar.TabIndex = 60;
            this.btnborrar.Text = "borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 665);
            this.ControlBox = false;
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.txtid_cliente);
            this.Controls.Add(this.lblid_cliente);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmatricula);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblid_cliente;
        private System.Windows.Forms.TextBox txtid_cliente;
        private System.Windows.Forms.Button btnborrar;
    }
}