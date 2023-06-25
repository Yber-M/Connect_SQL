namespace GLOBTECx_Cars
{
    partial class FrmVerTodosCar
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbxVerCars = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mononoki", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(648, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Visualizar Registros de Carros";
            // 
            // tbxVerCars
            // 
            this.tbxVerCars.Location = new System.Drawing.Point(33, 124);
            this.tbxVerCars.Multiline = true;
            this.tbxVerCars.Name = "tbxVerCars";
            this.tbxVerCars.Size = new System.Drawing.Size(723, 319);
            this.tbxVerCars.TabIndex = 11;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(33, 74);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(591, 44);
            this.btnRecuperar.TabIndex = 12;
            this.btnRecuperar.Text = "Recuperar Productos";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(630, 74);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 44);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmVerTodosCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 463);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.tbxVerCars);
            this.Controls.Add(this.label5);
            this.Name = "FrmVerTodosCar";
            this.Text = "frmVerTodosCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxVerCars;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnClose;
    }
}