
namespace PruebaConsumo
{
    partial class Form2
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
            this.dtgCategories = new System.Windows.Forms.DataGridView();
            this.btnCrearCate = new System.Windows.Forms.Button();
            this.btnActualizarCate = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCate = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCategories
            // 
            this.dtgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategories.Location = new System.Drawing.Point(12, 80);
            this.dtgCategories.Name = "dtgCategories";
            this.dtgCategories.RowHeadersWidth = 51;
            this.dtgCategories.RowTemplate.Height = 24;
            this.dtgCategories.Size = new System.Drawing.Size(776, 298);
            this.dtgCategories.TabIndex = 0;
            // 
            // btnCrearCate
            // 
            this.btnCrearCate.Location = new System.Drawing.Point(375, 398);
            this.btnCrearCate.Name = "btnCrearCate";
            this.btnCrearCate.Size = new System.Drawing.Size(114, 40);
            this.btnCrearCate.TabIndex = 1;
            this.btnCrearCate.Text = "Nuevo";
            this.btnCrearCate.UseVisualStyleBackColor = true;
            this.btnCrearCate.Click += new System.EventHandler(this.btnCrearCate_Click);
            // 
            // btnActualizarCate
            // 
            this.btnActualizarCate.Location = new System.Drawing.Point(495, 398);
            this.btnActualizarCate.Name = "btnActualizarCate";
            this.btnActualizarCate.Size = new System.Drawing.Size(114, 40);
            this.btnActualizarCate.TabIndex = 2;
            this.btnActualizarCate.Text = "Actualizar";
            this.btnActualizarCate.UseVisualStyleBackColor = true;
            this.btnActualizarCate.Click += new System.EventHandler(this.btnActualizarCate_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(674, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(2, 407);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalCate
            // 
            this.lblTotalCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCate.Location = new System.Drawing.Point(59, 398);
            this.lblTotalCate.Name = "lblTotalCate";
            this.lblTotalCate.Size = new System.Drawing.Size(94, 40);
            this.lblTotalCate.TabIndex = 6;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(92, 36);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(402, 30);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(13, 46);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(68, 20);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Buscar:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblTotalCate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizarCate);
            this.Controls.Add(this.btnCrearCate);
            this.Controls.Add(this.dtgCategories);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategories;
        private System.Windows.Forms.Button btnCrearCate;
        private System.Windows.Forms.Button btnActualizarCate;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCate;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
    }
}