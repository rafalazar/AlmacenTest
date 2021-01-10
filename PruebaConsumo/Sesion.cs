using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace PruebaConsumo
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        RestAPI rest = new RestAPI();
        public AuthResponse response { get; set; }


        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            var clientResponse = this.response;
            User userData = clientResponse.User;

            Console.WriteLine(clientResponse.Token);

            DateTime tokenDate = DateTime.Parse(clientResponse.Date);
            int expiresIn = Int32.Parse(clientResponse.Expires_in);

            Boolean tokenIsValid = rest.ValidateToken(tokenDate, expiresIn);

            if (tokenIsValid == true)
            {
                Console.WriteLine("TOKEN valid!");
                Form2 frmCate = new Form2();
                frmCate.token = clientResponse.Token;
                frmCate.Show();
            }
            else
            {
                Console.WriteLine("TOKEN Invalid!");

                TokenResponse newToken = rest.RefreshToken(clientResponse.Token, userData.User_id);
                
                if(bool.Parse(newToken.Ok) == true)
                {
                    Console.WriteLine("TOKEN valid!");
                    Form2 frmCate = new Form2();
                    frmCate.token = newToken.Token;
                    frmCate.Show();
                }
                else
                {
                    Console.WriteLine("Error: ", newToken.Message);
                    MessageBox.Show("Error: ", newToken.Message);
                }
            }
        }

    }
}
