namespace GLOBTECx_Cars
{
    partial class FrmUpdateDtsCars
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarCar
            // 
            this.btnBuscarCar.Font = new System.Drawing.Font("mononoki", 10F);
            this.btnBuscarCar.Location = new System.Drawing.Point(324, 71);
            this.btnBuscarCar.Name = "btnBuscarCar";
            this.btnBuscarCar.Size = new System.Drawing.Size(317, 55);
            this.btnBuscarCar.TabIndex = 29;
            this.btnBuscarCar.Text = "Buscar";
            this.btnBuscarCar.UseVisualStyleBackColor = true;
            this.btnBuscarCar.Click += new System.EventHandler(this.btnBuscarCar_Click);
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(212, 78);
            this.tbxID.MaxLength = 350;
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(106, 38);
            this.tbxID.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 31);
            this.label10.TabIndex = 27;
            this.label10.Text = "Buscar ID ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mononoki", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 42);
            this.label5.TabIndex = 26;
            this.label5.Text = "Actualizar Registro de Carros";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("mononoki", 10F);
            this.btnActualizar.Location = new System.Drawing.Point(45, 452);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(430, 50);
            this.btnActualizar.TabIndex = 47;
            this.btnActualizar.Text = "Actualizar el Registro";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("mononoki", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(481, 452);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 50);
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Marca : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "Modelo : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "Color : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("mononoki", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 31);
            this.label6.TabIndex = 42;
            this.label6.Text = "Placa : ";
            // 
            // tbxColor
            // 
            this.tbxColor.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxColor.Location = new System.Drawing.Point(241, 399);
            this.tbxColor.MaxLength = 20;
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(325, 42);
            this.tbxColor.TabIndex = 41;
            // 
            // tbxModelo
            // 
            this.tbxModelo.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxModelo.Location = new System.Drawing.Point(241, 330);
            this.tbxModelo.MaxLength = 20;
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(325, 42);
            this.tbxModelo.TabIndex = 40;
            // 
            // tbxMarca
            // 
            this.tbxMarca.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxMarca.Location = new System.Drawing.Point(241, 267);
            this.tbxMarca.MaxLength = 20;
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(325, 42);
            this.tbxMarca.TabIndex = 39;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Font = new System.Drawing.Font("mononoki", 18.2F);
            this.tbxPlaca.Location = new System.Drawing.Point(241, 206);
            this.tbxPlaca.MaxLength = 6;
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(325, 42);
            this.tbxPlaca.TabIndex = 38;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("mononoki", 12F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Location = new System.Drawing.Point(41, 155);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(439, 22);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Buscar un carro para actualizar cambios";
            // 
            // FrmUpdateDtsCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 518);
            this.Controls.Add(this.btnActualizar);
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
            this.Name = "FrmUpdateDtsCars";
            this.Text = "FrmUpdateDtsCars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCar;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Label lblStatus;
    }
}