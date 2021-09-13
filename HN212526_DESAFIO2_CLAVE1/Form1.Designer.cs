
namespace HN212526_DESAFIO2_CLAVE1
{
    partial class logeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logeo));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumeroDUI = new System.Windows.Forms.TextBox();
            this.dui = new System.Windows.Forms.Label();
            this.labelsaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCuentaID = new System.Windows.Forms.TextBox();
            this.btnSacardinero = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbta = new System.Windows.Forms.Label();
            this.lbTransactions = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BESTO BANCO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(215, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Siempre a tu lado";
            // 
            // txtnumeroDUI
            // 
            this.txtnumeroDUI.Location = new System.Drawing.Point(184, 121);
            this.txtnumeroDUI.Name = "txtnumeroDUI";
            this.txtnumeroDUI.Size = new System.Drawing.Size(182, 20);
            this.txtnumeroDUI.TabIndex = 3;
            // 
            // dui
            // 
            this.dui.AutoSize = true;
            this.dui.Location = new System.Drawing.Point(181, 105);
            this.dui.Name = "dui";
            this.dui.Size = new System.Drawing.Size(83, 13);
            this.dui.TabIndex = 5;
            this.dui.Text = "DUI  del usuario";
            this.dui.Click += new System.EventHandler(this.dui_Click);
            // 
            // labelsaldo
            // 
            this.labelsaldo.AutoSize = true;
            this.labelsaldo.Location = new System.Drawing.Point(184, 147);
            this.labelsaldo.Name = "labelsaldo";
            this.labelsaldo.Size = new System.Drawing.Size(76, 13);
            this.labelsaldo.TabIndex = 6;
            this.labelsaldo.Text = "Saldo de inicio";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(184, 163);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(182, 20);
            this.txtSaldo.TabIndex = 8;
            // 
            // txtInteres
            // 
            this.txtInteres.Enabled = false;
            this.txtInteres.Location = new System.Drawing.Point(22, 279);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(179, 20);
            this.txtInteres.TabIndex = 9;
            this.txtInteres.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Interes de la cuenta";
            this.label4.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(47, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID de la cuenta";
            this.label5.Visible = false;
            // 
            // txtCuentaID
            // 
            this.txtCuentaID.Enabled = false;
            this.txtCuentaID.Location = new System.Drawing.Point(22, 230);
            this.txtCuentaID.Name = "txtCuentaID";
            this.txtCuentaID.Size = new System.Drawing.Size(179, 20);
            this.txtCuentaID.TabIndex = 12;
            this.txtCuentaID.Visible = false;
            // 
            // btnSacardinero
            // 
            this.btnSacardinero.Location = new System.Drawing.Point(47, 305);
            this.btnSacardinero.Name = "btnSacardinero";
            this.btnSacardinero.Size = new System.Drawing.Size(127, 23);
            this.btnSacardinero.TabIndex = 14;
            this.btnSacardinero.Text = "Retirar efectivo";
            this.btnSacardinero.UseVisualStyleBackColor = true;
            this.btnSacardinero.Visible = false;
            this.btnSacardinero.Click += new System.EventHandler(this.btnSacardinero_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(47, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar efectivo";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(235, 192);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbta
            // 
            this.lbta.AutoSize = true;
            this.lbta.Location = new System.Drawing.Point(265, 230);
            this.lbta.Name = "lbta";
            this.lbta.Size = new System.Drawing.Size(77, 13);
            this.lbta.TabIndex = 16;
            this.lbta.Text = "Transacciones";
            this.lbta.Visible = false;
            // 
            // lbTransactions
            // 
            this.lbTransactions.FormattingEnabled = true;
            this.lbTransactions.Location = new System.Drawing.Point(268, 246);
            this.lbTransactions.Name = "lbTransactions";
            this.lbTransactions.Size = new System.Drawing.Size(220, 186);
            this.lbTransactions.TabIndex = 17;
            this.lbTransactions.Visible = false;
            // 
            // logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.lbTransactions);
            this.Controls.Add(this.lbta);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSacardinero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCuentaID);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelsaldo);
            this.Controls.Add(this.dui);
            this.Controls.Add(this.txtnumeroDUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "logeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logeo |  Besto Banco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumeroDUI;
        private System.Windows.Forms.Label dui;
        private System.Windows.Forms.Label labelsaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuentaID;
        private System.Windows.Forms.Button btnSacardinero;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lbta;
        private System.Windows.Forms.ListBox lbTransactions;
    }
}

