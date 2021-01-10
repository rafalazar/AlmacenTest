using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConsumo
{
    public partial class FormCrearCate : Form
    {
        public FormCrearCate()
        {
            InitializeComponent();
        }

        RestAPI_Category rest = new RestAPI_Category();
        public String token { get; set; }

        private void btnCrearCate_Click(object sender, EventArgs e)
        {
            String cateName = txtCateName.Text.Trim();
            int state = 1;

            if (optAvailable.Checked)
            {
                state = 1;
            } 
            else
            {
                state = 0;
            }

            bool isCreate = rest.CreateCategory(token, cateName, state);

            if(isCreate == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, verifique los datos");
            }

        }
    }
}
