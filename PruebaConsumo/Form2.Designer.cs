
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizarCate);
            this.Controls.Add(this.btnCrearCate);
            this.Controls.Add(this.dtgCategories);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategories;
        private System.Windows.Forms.Button btnCrearCate;
        private System.Windows.Forms.Button btnActualizarCate;
        private System.Windows.Forms.Button btnSalir;
    }
}