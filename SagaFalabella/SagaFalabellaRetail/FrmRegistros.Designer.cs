namespace SagaFalabellaRetail
{
    partial class FrmRegistros
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrabajador = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.Location = new System.Drawing.Point(84, 220);
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Size = new System.Drawing.Size(113, 66);
            this.btnTrabajador.TabIndex = 1;
            this.btnTrabajador.Text = "Trabajadores";
            this.btnTrabajador.UseVisualStyleBackColor = true;
            this.btnTrabajador.Click += new System.EventHandler(this.btnTrabajador_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(84, 133);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(113, 64);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Usuarios";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 372);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnTrabajador);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistros";
            this.Text = "FrmRegistros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrabajador;
        private System.Windows.Forms.Button btnUser;
    }
}