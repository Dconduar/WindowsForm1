namespace CalculadoradeViajes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia en km";
            // 
            // txtDistancia
            // 
            this.txtDistancia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDistancia.Location = new System.Drawing.Point(425, 143);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(132, 22);
            this.txtDistancia.TabIndex = 1;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtVelocidad.Location = new System.Drawing.Point(425, 229);
            this.txtVelocidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(132, 22);
            this.txtVelocidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocidad Km/h";
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncalc.Location = new System.Drawing.Point(425, 306);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(131, 60);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calculadora de Viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalc;
    }
}
