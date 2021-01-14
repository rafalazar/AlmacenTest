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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        RestAPI_Category rest = new RestAPI_Category();

        public String token { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            
        }

        public void LoadData()
        {
            CategoriasResponse response = rest.GetAllCategories(token);

            List<Result> categories = response.Result;

            categories.Reverse();

            dtgCategories.DataSource = categories;
            lblTotalCate.Text = dtgCategories.Rows.Count.ToString();
        }

        private void btnCrearCate_Click(object sender, EventArgs e)
        {
            FormCrearCate frmCrearCate = new FormCrearCate();
            frmCrearCate.token = token;
            frmCrearCate.ShowDialog();
            LoadData();
        }

        private void btnActualizarCate_Click(object sender, EventArgs e)
        {
            FormActualizarCate frmActualizarCate = new FormActualizarCate();
            frmActualizarCate.idCate = dtgCategories.CurrentRow.Cells[0].Value.ToString();
            frmActualizarCate.token = token;
            frmActualizarCate.ShowDialog();
            LoadData();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dtgCategories.DataSource = rest.FiltrarCategory(txtFiltro.Text.Trim());
            lblTotalCate.Text = dtgCategories.Rows.Count.ToString();
        }
    }
}
