namespace Banda_transportadora
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
            this.btnPE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnP = new System.Windows.Forms.Button();
            this.btnArranque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPE
            // 
            this.btnPE.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPE.Location = new System.Drawing.Point(23, 101);
            this.btnPE.Name = "btnPE";
            this.btnPE.Size = new System.Drawing.Size(200, 123);
            this.btnPE.TabIndex = 0;
            this.btnPE.Text = "Paro de Emergencia";
            this.btnPE.UseVisualStyleBackColor = true;
            this.btnPE.Click += new System.EventHandler(this.btnPE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banda transportadora";
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(287, 101);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(200, 123);
            this.btnP.TabIndex = 2;
            this.btnP.Text = "Paro";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnArranque
            // 
            this.btnArranque.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArranque.Location = new System.Drawing.Point(553, 101);
            this.btnArranque.Name = "btnArranque";
            this.btnArranque.Size = new System.Drawing.Size(200, 123);
            this.btnArranque.TabIndex = 3;
            this.btnArranque.Text = "Arranque";
            this.btnArranque.UseVisualStyleBackColor = true;
            this.btnArranque.Click += new System.EventHandler(this.btnArranque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(309, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // btnDireccion
            // 
            this.btnDireccion.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDireccion.Location = new System.Drawing.Point(287, 303);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(200, 123);
            this.btnDireccion.TabIndex = 5;
            this.btnDireccion.Text = "Direccion";
            this.btnDireccion.UseVisualStyleBackColor = true;
            this.btnDireccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnArranque);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnArranque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDireccion;
    }
}

