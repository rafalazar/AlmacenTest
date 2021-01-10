
namespace PruebaConsumo
{
    partial class FormActualizarCate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optAvailable = new System.Windows.Forms.RadioButton();
            this.optUnavailable = new System.Windows.Forms.RadioButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.optUnavailable);
            this.groupBox1.Controls.Add(this.optAvailable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreCate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Actualizar Categoría: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreCate
            // 
            this.txtNombreCate.Location = new System.Drawing.Point(107, 72);
            this.txtNombreCate.Multiline = true;
            this.txtNombreCate.Name = "txtNombreCate";
            this.txtNombreCate.Size = new System.Drawing.Size(186, 29);
            this.txtNombreCate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // optAvailable
            // 
            this.optAvailable.AutoSize = true;
            this.optAvailable.Location = new System.Drawing.Point(103, 178);
            this.optAvailable.Name = "optAvailable";
            this.optAvailable.Size = new System.Drawing.Size(95, 21);
            this.optAvailable.TabIndex = 3;
            this.optAvailable.TabStop = true;
            this.optAvailable.Text = "Disponible";
            this.optAvailable.UseVisualStyleBackColor = true;
            // 
            // optUnavailable
            // 
            this.optUnavailable.AutoSize = true;
            this.optUnavailable.Location = new System.Drawing.Point(103, 228);
            this.optUnavailable.Name = "optUnavailable";
            this.optUnavailable.Size = new System.Drawing.Size(82, 21);
            this.optUnavailable.TabIndex = 4;
            this.optUnavailable.TabStop = true;
            this.optUnavailable.Text = "Agotado";
            this.optUnavailable.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(103, 312);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(186, 39);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormActualizarCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 390);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActualizarCate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormActualizarCate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCate;
        private System.Windows.Forms.RadioButton optUnavailable;
        private System.Windows.Forms.RadioButton optAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
    }
}