namespace Archivos
{
    partial class CambiaNombre
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
            this.tBNuevoNombre = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lbNuevoNombreBD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBNuevoNombre
            // 
            this.tBNuevoNombre.Location = new System.Drawing.Point(82, 66);
            this.tBNuevoNombre.Name = "tBNuevoNombre";
            this.tBNuevoNombre.Size = new System.Drawing.Size(286, 22);
            this.tBNuevoNombre.TabIndex = 0;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.Black;
            this.btAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAceptar.Location = new System.Drawing.Point(163, 111);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(117, 29);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lbNuevoNombreBD
            // 
            this.lbNuevoNombreBD.AutoSize = true;
            this.lbNuevoNombreBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoNombreBD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNuevoNombreBD.Location = new System.Drawing.Point(139, 28);
            this.lbNuevoNombreBD.Name = "lbNuevoNombreBD";
            this.lbNuevoNombreBD.Size = new System.Drawing.Size(182, 20);
            this.lbNuevoNombreBD.TabIndex = 2;
            this.lbNuevoNombreBD.Text = "NUEVO NOMBRE BD:";
            // 
            // CambiaNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(437, 205);
            this.Controls.Add(this.lbNuevoNombreBD);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tBNuevoNombre);
            this.Name = "CambiaNombre";
            this.Text = "CambiaNombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBNuevoNombre;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lbNuevoNombreBD;
    }
}