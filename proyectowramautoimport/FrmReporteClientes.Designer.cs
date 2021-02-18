namespace ProyectoWramAutoImport
{
    partial class FrmReporteClientes
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
            this.dataSetReporteClientes1 = new ProyectoWramAutoImport.DataSetReporteClientes();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteClientes1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetReporteClientes1
            // 
            this.dataSetReporteClientes1.DataSetName = "DataSetReporteClientes";
            this.dataSetReporteClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 584);
            this.Name = "FrmReporteClientes";
            this.Text = "FrmReporteClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteClientes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetReporteClientes dataSetReporteClientes1;
    }
}