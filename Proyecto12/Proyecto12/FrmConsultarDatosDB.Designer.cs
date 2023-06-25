namespace Proyecto12
{
    partial class FrmConsultarDatosDB
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
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.tbxProductos = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(172, 12);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(299, 55);
            this.btnRecuperar.TabIndex = 0;
            this.btnRecuperar.Text = "Recuperar Productos";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // tbxProductos
            // 
            this.tbxProductos.Location = new System.Drawing.Point(28, 87);
            this.tbxProductos.Multiline = true;
            this.tbxProductos.Name = "tbxProductos";
            this.tbxProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxProductos.Size = new System.Drawing.Size(585, 268);
            this.tbxProductos.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmConsultarDatosDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxProductos);
            this.Controls.Add(this.btnRecuperar);
            this.Name = "FrmConsultarDatosDB";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox tbxProductos;
        private System.Windows.Forms.Button btnClose;
    }
}