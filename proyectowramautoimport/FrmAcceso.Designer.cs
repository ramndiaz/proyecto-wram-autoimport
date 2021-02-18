namespace ProyectoWramAutoImport
{
    partial class FrmAcceso
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
            System.Windows.Forms.Label id_USUARIOLabel;
            System.Windows.Forms.Label nOMBRE_USUARIOLabel;
            System.Windows.Forms.Label cLAVE_USUARIOLabel;
            System.Windows.Forms.Label id_EMPLEADOLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.bbtnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtid_empleado = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            id_USUARIOLabel = new System.Windows.Forms.Label();
            nOMBRE_USUARIOLabel = new System.Windows.Forms.Label();
            cLAVE_USUARIOLabel = new System.Windows.Forms.Label();
            id_EMPLEADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_USUARIOLabel
            // 
            id_USUARIOLabel.AutoSize = true;
            id_USUARIOLabel.Location = new System.Drawing.Point(28, 27);
            id_USUARIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_USUARIOLabel.Name = "id_USUARIOLabel";
            id_USUARIOLabel.Size = new System.Drawing.Size(89, 17);
            id_USUARIOLabel.TabIndex = 17;
            id_USUARIOLabel.Text = "Id USUARIO:";
            // 
            // nOMBRE_USUARIOLabel
            // 
            nOMBRE_USUARIOLabel.AutoSize = true;
            nOMBRE_USUARIOLabel.Location = new System.Drawing.Point(28, 59);
            nOMBRE_USUARIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOMBRE_USUARIOLabel.Name = "nOMBRE_USUARIOLabel";
            nOMBRE_USUARIOLabel.Size = new System.Drawing.Size(138, 17);
            nOMBRE_USUARIOLabel.TabIndex = 19;
            nOMBRE_USUARIOLabel.Text = "NOMBRE USUARIO:";
            // 
            // cLAVE_USUARIOLabel
            // 
            cLAVE_USUARIOLabel.AutoSize = true;
            cLAVE_USUARIOLabel.Location = new System.Drawing.Point(28, 91);
            cLAVE_USUARIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLAVE_USUARIOLabel.Name = "cLAVE_USUARIOLabel";
            cLAVE_USUARIOLabel.Size = new System.Drawing.Size(122, 17);
            cLAVE_USUARIOLabel.TabIndex = 21;
            cLAVE_USUARIOLabel.Text = "CLAVE USUARIO:";
            // 
            // id_EMPLEADOLabel
            // 
            id_EMPLEADOLabel.AutoSize = true;
            id_EMPLEADOLabel.Location = new System.Drawing.Point(28, 155);
            id_EMPLEADOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_EMPLEADOLabel.Name = "id_EMPLEADOLabel";
            id_EMPLEADOLabel.Size = new System.Drawing.Size(103, 17);
            id_EMPLEADOLabel.TabIndex = 23;
            id_EMPLEADOLabel.Text = "Id EMPLEADO:";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(621, 158);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(93, 28);
            this.btnborrar.TabIndex = 32;
            this.btnborrar.Text = "borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(621, 50);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(93, 28);
            this.btneditar.TabIndex = 31;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 217);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 287);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(621, 15);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(93, 28);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bbtnguardar
            // 
            this.bbtnguardar.Location = new System.Drawing.Point(621, 86);
            this.bbtnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bbtnguardar.Name = "bbtnguardar";
            this.bbtnguardar.Size = new System.Drawing.Size(93, 28);
            this.bbtnguardar.TabIndex = 28;
            this.bbtnguardar.Text = "Guardar";
            this.bbtnguardar.UseVisualStyleBackColor = true;
            this.bbtnguardar.Click += new System.EventHandler(this.bbtnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "CONFIRMAR CLAVE";
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Location = new System.Drawing.Point(181, 119);
            this.txtconfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(365, 22);
            this.txtconfirmar.TabIndex = 26;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(621, 122);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(93, 28);
            this.btnvolver.TabIndex = 25;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(181, 23);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(365, 22);
            this.txtid.TabIndex = 18;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(181, 55);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(365, 22);
            this.txtnombre.TabIndex = 20;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(181, 87);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(365, 22);
            this.txtclave.TabIndex = 22;
            // 
            // txtid_empleado
            // 
            this.txtid_empleado.Location = new System.Drawing.Point(181, 151);
            this.txtid_empleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid_empleado.Name = "txtid_empleado";
            this.txtid_empleado.Size = new System.Drawing.Size(365, 22);
            this.txtid_empleado.TabIndex = 24;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(205, 187);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(128, 17);
            this.lblbuscar.TabIndex = 33;
            this.lblbuscar.Text = "buscar por nombre";
            this.lblbuscar.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(340, 183);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(207, 22);
            this.txtbuscar.TabIndex = 34;
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyUp);
            // 
            // FrmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(759, 505);
            this.ControlBox = false;
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.bbtnguardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(id_USUARIOLabel);
            this.Controls.Add(this.txtid);
            this.Controls.Add(nOMBRE_USUARIOLabel);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(cLAVE_USUARIOLabel);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(id_EMPLEADOLabel);
            this.Controls.Add(this.txtid_empleado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.FrmAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button bbtnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtid_empleado;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}