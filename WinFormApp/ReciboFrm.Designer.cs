namespace WinFormApp
{
    partial class ReciboFrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.iNumerorecibo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.iFecharecibo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.iClienteId = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.iPerfilId = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.iImporte = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnGrabar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.iClienteId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPerfilId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(34, 33);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "N° Recibo";
            // 
            // iNumerorecibo
            // 
            this.iNumerorecibo.Location = new System.Drawing.Point(119, 30);
            this.iNumerorecibo.Name = "iNumerorecibo";
            this.iNumerorecibo.Size = new System.Drawing.Size(108, 27);
            this.iNumerorecibo.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(34, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 24);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Fecha";
            // 
            // iFecharecibo
            // 
            this.iFecharecibo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.iFecharecibo.Location = new System.Drawing.Point(119, 63);
            this.iFecharecibo.Name = "iFecharecibo";
            this.iFecharecibo.Size = new System.Drawing.Size(108, 25);
            this.iFecharecibo.TabIndex = 3;
            // 
            // iClienteId
            // 
            this.iClienteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iClienteId.DropDownWidth = 345;
            this.iClienteId.Location = new System.Drawing.Point(119, 92);
            this.iClienteId.Name = "iClienteId";
            this.iClienteId.Size = new System.Drawing.Size(345, 25);
            this.iClienteId.TabIndex = 5;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(34, 93);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(59, 24);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Cliente";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(34, 124);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(46, 24);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Perfil";
            // 
            // iPerfilId
            // 
            this.iPerfilId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iPerfilId.DropDownWidth = 345;
            this.iPerfilId.Location = new System.Drawing.Point(119, 123);
            this.iPerfilId.Name = "iPerfilId";
            this.iPerfilId.Size = new System.Drawing.Size(345, 25);
            this.iPerfilId.TabIndex = 7;
            // 
            // iImporte
            // 
            this.iImporte.Location = new System.Drawing.Point(119, 154);
            this.iImporte.Name = "iImporte";
            this.iImporte.Size = new System.Drawing.Size(108, 27);
            this.iImporte.TabIndex = 9;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(34, 157);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(66, 24);
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Importe";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(119, 198);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(140, 39);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Values.Text = "Grabar recibo";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(265, 198);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(140, 39);
            this.kryptonButton1.TabIndex = 11;
            this.kryptonButton1.Values.Text = "Cargar recibos";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeight = 28;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(119, 256);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(663, 286);
            this.kryptonDataGridView1.TabIndex = 12;
            // 
            // ReciboFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 559);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.iImporte);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.iPerfilId);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.iClienteId);
            this.Controls.Add(this.iFecharecibo);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.iNumerorecibo);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "ReciboFrm";
            this.Text = "Ingresar recibo de pago";
            this.Load += new System.EventHandler(this.ReciboFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iClienteId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPerfilId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox iNumerorecibo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker iFecharecibo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox iClienteId;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox iPerfilId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox iImporte;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGrabar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}

