
namespace PruebaConsumo
{
    partial class Sesion
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
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Location = new System.Drawing.Point(84, 97);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(180, 56);
            this.btnGetCategories.TabIndex = 0;
            this.btnGetCategories.Text = "Get Categories";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 272);
            this.Controls.Add(this.btnGetCategories);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCategories;
    }
}