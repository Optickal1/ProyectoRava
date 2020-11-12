namespace ProyectoRava
{
    partial class AInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AInventario));
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.dGV_Inventario = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnIngresoPA = new System.Windows.Forms.Button();
            this.btnConsumoPA = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnAgregarPA = new System.Windows.Forms.Button();
            this.btnEliminarPA = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVentas.BackColor = System.Drawing.Color.White;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(12, 26);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(95, 33);
            this.btnVentas.TabIndex = 7;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnCaja
            // 
            this.btnCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCaja.BackColor = System.Drawing.Color.White;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(113, 26);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(95, 33);
            this.btnCaja.TabIndex = 8;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = false;
            // 
            // dGV_Inventario
            // 
            this.dGV_Inventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGV_Inventario.BackgroundColor = System.Drawing.Color.White;
            this.dGV_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Inventario.Location = new System.Drawing.Point(12, 65);
            this.dGV_Inventario.Name = "dGV_Inventario";
            this.dGV_Inventario.Size = new System.Drawing.Size(621, 314);
            this.dGV_Inventario.TabIndex = 9;
            this.dGV_Inventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Inventario_CellContentClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(12, 405);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(95, 33);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnIngresoPA
            // 
            this.btnIngresoPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresoPA.BackColor = System.Drawing.Color.Snow;
            this.btnIngresoPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoPA.Location = new System.Drawing.Point(639, 225);
            this.btnIngresoPA.Name = "btnIngresoPA";
            this.btnIngresoPA.Size = new System.Drawing.Size(149, 74);
            this.btnIngresoPA.TabIndex = 11;
            this.btnIngresoPA.Text = "Ingreso";
            this.btnIngresoPA.UseVisualStyleBackColor = false;
            this.btnIngresoPA.Click += new System.EventHandler(this.btnIngresoPA_Click);
            // 
            // btnConsumoPA
            // 
            this.btnConsumoPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsumoPA.BackColor = System.Drawing.Color.Snow;
            this.btnConsumoPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumoPA.Location = new System.Drawing.Point(639, 305);
            this.btnConsumoPA.Name = "btnConsumoPA";
            this.btnConsumoPA.Size = new System.Drawing.Size(149, 74);
            this.btnConsumoPA.TabIndex = 12;
            this.btnConsumoPA.Text = "Consumo";
            this.btnConsumoPA.UseVisualStyleBackColor = false;
            this.btnConsumoPA.Click += new System.EventHandler(this.btnConsumoPA_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesconectar.BackColor = System.Drawing.Color.Snow;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(639, 405);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(149, 33);
            this.btnDesconectar.TabIndex = 13;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnAgregarPA
            // 
            this.btnAgregarPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarPA.BackColor = System.Drawing.Color.Snow;
            this.btnAgregarPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarPA.Location = new System.Drawing.Point(639, 65);
            this.btnAgregarPA.Name = "btnAgregarPA";
            this.btnAgregarPA.Size = new System.Drawing.Size(149, 74);
            this.btnAgregarPA.TabIndex = 14;
            this.btnAgregarPA.Text = "Agregar Producto";
            this.btnAgregarPA.UseVisualStyleBackColor = false;
            this.btnAgregarPA.Click += new System.EventHandler(this.btnAgregarPA_Click);
            // 
            // btnEliminarPA
            // 
            this.btnEliminarPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarPA.BackColor = System.Drawing.Color.Snow;
            this.btnEliminarPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPA.Location = new System.Drawing.Point(639, 145);
            this.btnEliminarPA.Name = "btnEliminarPA";
            this.btnEliminarPA.Size = new System.Drawing.Size(149, 74);
            this.btnEliminarPA.TabIndex = 15;
            this.btnEliminarPA.Text = "Eliminar Producto";
            this.btnEliminarPA.UseVisualStyleBackColor = false;
            this.btnEliminarPA.Click += new System.EventHandler(this.btnEliminarPA_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(683, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 33);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEliminarPA);
            this.Controls.Add(this.btnAgregarPA);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConsumoPA);
            this.Controls.Add(this.btnIngresoPA);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dGV_Inventario);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.AInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.DataGridView dGV_Inventario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnIngresoPA;
        private System.Windows.Forms.Button btnConsumoPA;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnAgregarPA;
        private System.Windows.Forms.Button btnEliminarPA;
        private System.Windows.Forms.Button btnUpdate;
    }
}