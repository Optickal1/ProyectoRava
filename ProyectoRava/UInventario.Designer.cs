namespace ProyectoRava
{
    partial class UInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UInventario));
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnIngresoPU = new System.Windows.Forms.Button();
            this.btnConsumoPU = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.dGV_Inventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(12, 405);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(95, 33);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(639, 405);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(149, 33);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngresoPU
            // 
            this.btnIngresoPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoPU.Location = new System.Drawing.Point(639, 225);
            this.btnIngresoPU.Name = "btnIngresoPU";
            this.btnIngresoPU.Size = new System.Drawing.Size(149, 74);
            this.btnIngresoPU.TabIndex = 4;
            this.btnIngresoPU.Text = "Ingreso";
            this.btnIngresoPU.UseVisualStyleBackColor = true;
            this.btnIngresoPU.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnConsumoPU
            // 
            this.btnConsumoPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumoPU.Location = new System.Drawing.Point(639, 305);
            this.btnConsumoPU.Name = "btnConsumoPU";
            this.btnConsumoPU.Size = new System.Drawing.Size(149, 74);
            this.btnConsumoPU.TabIndex = 5;
            this.btnConsumoPU.Text = "Consumo";
            this.btnConsumoPU.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(12, 26);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(95, 33);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCaja
            // 
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(113, 26);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(95, 33);
            this.btnCaja.TabIndex = 7;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            // 
            // dGV_Inventario
            // 
            this.dGV_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Inventario.Location = new System.Drawing.Point(12, 65);
            this.dGV_Inventario.Name = "dGV_Inventario";
            this.dGV_Inventario.Size = new System.Drawing.Size(621, 314);
            this.dGV_Inventario.TabIndex = 10;
            // 
            // UInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV_Inventario);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnConsumoPU);
            this.Controls.Add(this.btnIngresoPU);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.UInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnIngresoPU;
        private System.Windows.Forms.Button btnConsumoPU;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.DataGridView dGV_Inventario;
    }
}