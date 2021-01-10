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

        }
    }
}
