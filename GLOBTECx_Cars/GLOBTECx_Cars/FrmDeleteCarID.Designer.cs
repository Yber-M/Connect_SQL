namespace GLOBTECx_Cars
{
    partial class FrmDeleteCarID
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
            this.btnBuscarCar = new System.Windows.Forms.Button();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarCar
            // 
            this.btnBuscarCar.Font = new System.Drawing.Font("mononoki", 10F);
            this.btnBuscarCar.Location = new System.Drawing.Point(312, 70);
            this.btnBuscarCar.Name = "btnBuscarCar";
            this.btnBuscarCar.Size = new System.Drawing.Size(216, 55);
            this.btnBuscarCar.TabIndex = 25;
            this.btnBuscarCar.Text = "Buscar";
            this.btnBuscarCar.UseVisualStyleBackColor = true;
            this.btnBuscarCar.Click += new System.EventHandler(this.btnBuscarCar_Click);
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(200, 77);
            this.tbxID.MaxLength = 6;
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(106, 38);
            this.tbxID.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 31);
            this.label10.TabIndex = 23;
            this.label10.Text = "Buscar ID ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mononoki", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(522, 42);
            this.label5.TabIndex = 22;
            this.label5.Text = "Eliminar un Carro por ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("mononoki", 12F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Location = new System.Drawing.Point(12, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(318, 22);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Busca un carro para eliminar";
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Enabled = false;
            this.tbxPlaca.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxPlaca.Location = new System.Drawing.Point(212, 196);
            this.tbxPlaca.MaxLength = 6;
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(262, 42);
            this.tbxPlaca.TabIndex = 27;
            // 
            // tbxMarca
            // 
            this.tbxMarca.Enabled = false;
            this.tbxMarca.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxMarca.Location = new System.Drawing.Point(212, 257);
            this.tbxMarca.MaxLength = 6;
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(262, 42);
            this.tbxMarca.TabIndex = 28;
            // 
            // tbxModelo
            // 
            this.tbxModelo.Enabled = false;
            this.tbxModelo.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxModelo.Location = new System.Drawing.Point(212, 320);
            this.tbxModelo.MaxLength = 6;
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(262, 42);
            this.tbxModelo.TabIndex = 29;
            // 
            // tbxColor
            // 
            this.tbxColor.Enabled = false;
            this.tbxColor.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxColor.Location = new System.Drawing.Point(212, 389);
            this.tbxColor.MaxLength = 6;
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(262, 42);
            this.tbxColor.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Marca : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "Modelo : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "Color : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 31);
            this.label6.TabIndex = 31;
            this.label6.Text = "Placa : ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("mononoki", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(377, 442);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 50);
            this.btnCerrar.TabIndex = 35;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("mononoki", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(22, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(349, 50);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar Carro del Registro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmDeleteCarID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 512);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBuscarCar);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Name = "FrmDeleteCarID";
            this.Text = "Eliminar un Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCar;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
    }
}