
namespace PruebaConsumo
{
    partial class FormCrearCate
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
            this.optAvailable = new System.Windows.Forms.RadioButton();
            this.optUnavailable = new System.Windows.Forms.RadioButton();
            this.txtCateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearCate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearCate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCateName);
            this.groupBox1.Controls.Add(this.optUnavailable);
            this.groupBox1.Controls.Add(this.optAvailable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Crear Categoría: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // optAvailable
            // 
            this.optAvailable.AutoSize = true;
            this.optAvailable.Location = new System.Drawing.Point(102, 223);
            this.optAvailable.Name = "optAvailable";
            this.optAvailable.Size = new System.Drawing.Size(95, 21);
            this.optAvailable.TabIndex = 1;
            this.optAvailable.TabStop = true;
            this.optAvailable.Text = "Disponible";
            this.optAvailable.UseVisualStyleBackColor = true;
            // 
            // optUnavailable
            // 
            this.optUnavailable.AutoSize = true;
            this.optUnavailable.Location = new System.Drawing.Point(102, 270);
            this.optUnavailable.Name = "optUnavailable";
            this.optUnavailable.Size = new System.Drawing.Size(82, 21);
            this.optUnavailable.TabIndex = 2;
            this.optUnavailable.TabStop = true;
            this.optUnavailable.Text = "Agotado";
            this.optUnavailable.UseVisualStyleBackColor = true;
            // 
            // txtCateName
            // 
            this.txtCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCateName.Location = new System.Drawing.Point(102, 82);
            this.txtCateName.Multiline = true;
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(189, 34);
            this.txtCateName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado:";
            // 
            // btnCrearCate
            // 
            this.btnCrearCate.Location = new System.Drawing.Point(102, 348);
            this.btnCrearCate.Name = "btnCrearCate";
            this.btnCrearCate.Size = new System.Drawing.Size(189, 38);
            this.btnCrearCate.TabIndex = 5;
            this.btnCrearCate.Text = "Crear";
            this.btnCrearCate.UseVisualStyleBackColor = true;
            this.btnCrearCate.Click += new System.EventHandler(this.btnCrearCate_Click);
            // 
            // FormCrearCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 433);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearCate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Categoría";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrearCate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCateName;
        private System.Windows.Forms.RadioButton optUnavailable;
        private System.Windows.Forms.RadioButton optAvailable;
        private System.Windows.Forms.Label label1;
    }
}