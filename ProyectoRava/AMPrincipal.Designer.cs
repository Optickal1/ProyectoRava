namespace ProyectoRava
{
    partial class AMPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMPrincipal));
            this.btnInventarioA = new System.Windows.Forms.Button();
            this.btnVentasA = new System.Windows.Forms.Button();
            this.btnCajaA = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnAddUsser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventarioA
            // 
            this.btnInventarioA.BackColor = System.Drawing.Color.White;
            this.btnInventarioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarioA.Location = new System.Drawing.Point(108, 158);
            this.btnInventarioA.Name = "btnInventarioA";
            this.btnInventarioA.Size = new System.Drawing.Size(147, 79);
            this.btnInventarioA.TabIndex = 2;
            this.btnInventarioA.Text = "Inventario";
            this.btnInventarioA.UseVisualStyleBackColor = false;
            this.btnInventarioA.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVentasA
            // 
            this.btnVentasA.BackColor = System.Drawing.Color.White;
            this.btnVentasA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasA.Location = new System.Drawing.Point(317, 158);
            this.btnVentasA.Name = "btnVentasA";
            this.btnVentasA.Size = new System.Drawing.Size(144, 79);
            this.btnVentasA.TabIndex = 3;
            this.btnVentasA.Text = "Ventas";
            this.btnVentasA.UseVisualStyleBackColor = false;
            // 
            // btnCajaA
            // 
            this.btnCajaA.BackColor = System.Drawing.Color.White;
            this.btnCajaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajaA.Location = new System.Drawing.Point(508, 158);
            this.btnCajaA.Name = "btnCajaA";
            this.btnCajaA.Size = new System.Drawing.Size(162, 79);
            this.btnCajaA.TabIndex = 4;
            this.btnCajaA.Text = "Caja";
            this.btnCajaA.UseVisualStyleBackColor = false;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.White;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(639, 405);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(149, 33);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnAddUsser
            // 
            this.btnAddUsser.BackColor = System.Drawing.Color.White;
            this.btnAddUsser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsser.Location = new System.Drawing.Point(317, 260);
            this.btnAddUsser.Name = "btnAddUsser";
            this.btnAddUsser.Size = new System.Drawing.Size(144, 79);
            this.btnAddUsser.TabIndex = 6;
            this.btnAddUsser.Text = "Gestión Personal";
            this.btnAddUsser.UseVisualStyleBackColor = false;
            this.btnAddUsser.Click += new System.EventHandler(this.btnAddUsser_Click);
            // 
            // AMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddUsser);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnCajaA);
            this.Controls.Add(this.btnVentasA);
            this.Controls.Add(this.btnInventarioA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AMPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInventarioA;
        private System.Windows.Forms.Button btnVentasA;
        private System.Windows.Forms.Button btnCajaA;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnAddUsser;
    }
}