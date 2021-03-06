﻿using System;
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
    public partial class FormActualizarCate : Form
    {
        public FormActualizarCate()
        {
            InitializeComponent();
        }

        RestAPI_Category rest = new RestAPI_Category();
        public String token { get; set; }
        public String idCate { get; set; }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(idCate);
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

            bool isUpdate = rest.UpdateCategory(token, cateName, state, idCategory);

            if (isUpdate == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, verifique los datos");
            }
        }

        private void FormActualizarCate_Load(object sender, EventArgs e)
        {

            CategoriasResponse response = rest.GetCategoryById(token, Int32.Parse(idCate));

            List<Result> category = response.Result;

            foreach(Result i in category)
            {
                txtCateName.Text = i.Category_name;

                if(Int32.Parse(i.State) == 1)
                {
                    optAvailable.Checked = true;
                }
                else
                {
                    optUnavailable.Checked = true;
                }
            }
        }
    }
}
