namespace ProyectoRava
{
    partial class InventarioConsumo
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
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxInventario = new System.Windows.Forms.ComboBox();
            this.NUPInventario = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUPInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Consumo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione producto a actualizar";
            // 
            // cBoxInventario
            // 
            this.cBoxInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxInventario.FormattingEnabled = true;
            this.cBoxInventario.Location = new System.Drawing.Point(12, 161);
            this.cBoxInventario.Name = "cBoxInventario";
            this.cBoxInventario.Size = new System.Drawing.Size(182, 21);
            this.cBoxInventario.TabIndex = 3;
            this.cBoxInventario.SelectedIndexChanged += new System.EventHandler(this.cBoxInventario_SelectedIndexChanged);
            // 
            // NUPInventario
            // 
            this.NUPInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NUPInventario.Location = new System.Drawing.Point(214, 162);
            this.NUPInventario.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUPInventario.Name = "NUPInventario";
            this.NUPInventario.Size = new System.Drawing.Size(120, 20);
            this.NUPInventario.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(258, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 27);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnConsumo
            // 
            this.btnConsumo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.Location = new System.Drawing.Point(258, 188);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(76, 27);
            this.btnConsumo.TabIndex = 8;
            this.btnConsumo.Text = "Consumo";
            this.btnConsumo.UseVisualStyleBackColor = true;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // InventarioConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(346, 398);
            this.Controls.Add(this.btnConsumo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.NUPInventario);
            this.Controls.Add(this.cBoxInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventarioConsumo";
            this.Text = "Consumo";
            this.Load += new System.EventHandler(this.InventarioConsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUPInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxInventario;
        private System.Windows.Forms.NumericUpDown NUPInventario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnConsumo;
    }
}