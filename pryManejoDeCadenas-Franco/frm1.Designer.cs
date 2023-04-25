namespace pryManejoDeCadenas_Franco
{
    partial class frm1
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
            this.lblTextoA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnRemplazo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConver = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.lblCantA = new System.Windows.Forms.Label();
            this.lblCantB = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextoA
            // 
            this.lblTextoA.AutoSize = true;
            this.lblTextoA.Location = new System.Drawing.Point(77, 40);
            this.lblTextoA.Name = "lblTextoA";
            this.lblTextoA.Size = new System.Drawing.Size(44, 13);
            this.lblTextoA.TabIndex = 0;
            this.lblTextoA.Text = "Texto A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(152, 40);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(80, 169);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "comparar ";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnRemplazo
            // 
            this.btnRemplazo.Location = new System.Drawing.Point(208, 169);
            this.btnRemplazo.Name = "btnRemplazo";
            this.btnRemplazo.Size = new System.Drawing.Size(75, 23);
            this.btnRemplazo.TabIndex = 3;
            this.btnRemplazo.Text = "Reemplazar";
            this.btnRemplazo.UseVisualStyleBackColor = true;
            this.btnRemplazo.Click += new System.EventHandler(this.btnRemplazo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(347, 169);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConver
            // 
            this.btnConver.Location = new System.Drawing.Point(80, 228);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(75, 23);
            this.btnConver.TabIndex = 5;
            this.btnConver.Text = "Convertir";
            this.btnConver.UseVisualStyleBackColor = true;
            this.btnConver.Click += new System.EventHandler(this.btnConver_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(419, 40);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 6;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Location = new System.Drawing.Point(344, 40);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(44, 13);
            this.lblTextoB.TabIndex = 7;
            this.lblTextoB.Text = "Texto B";
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Location = new System.Drawing.Point(77, 110);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(40, 13);
            this.lblFecha1.TabIndex = 8;
            this.lblFecha1.Text = "Fecha ";
            // 
            // DTPicker
            // 
            this.DTPicker.Location = new System.Drawing.Point(152, 104);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(202, 20);
            this.DTPicker.TabIndex = 9;
            // 
            // lblCantA
            // 
            this.lblCantA.AutoSize = true;
            this.lblCantA.Location = new System.Drawing.Point(281, 43);
            this.lblCantA.Name = "lblCantA";
            this.lblCantA.Size = new System.Drawing.Size(13, 13);
            this.lblCantA.TabIndex = 10;
            this.lblCantA.Text = "0";
            // 
            // lblCantB
            // 
            this.lblCantB.AutoSize = true;
            this.lblCantB.Location = new System.Drawing.Point(543, 43);
            this.lblCantB.Name = "lblCantB";
            this.lblCantB.Size = new System.Drawing.Size(13, 13);
            this.lblCantB.TabIndex = 11;
            this.lblCantB.Text = "0";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(456, 172);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 12;
            this.txtBusqueda.Visible = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(205, 233);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(579, 263);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblCantB);
            this.Controls.Add(this.lblCantA);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.lblTextoB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnConver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRemplazo);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblTextoA);
            this.Name = "Form1";
            this.Text = ":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::" +
    ":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnRemplazo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConver;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.Label lblCantA;
        private System.Windows.Forms.Label lblCantB;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblFecha;
    }
}

