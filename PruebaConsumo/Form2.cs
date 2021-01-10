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

        RestAPI rest = new RestAPI();

        public String token { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            lstbCategory.Items.Clear();

            CategoriasResponse response = rest.GetAllCategories(token);

            List<Result> categories = response.Result;

            foreach(Result item in categories)
            {
                lstbCategory.Items.Add(String.Format("{0}".ToUpper(), item.Category_name));
                //obtener el id en una variable de cada categoría
            }
        }

        public void FillListBoxCategory()
        {

        }
    }
}
