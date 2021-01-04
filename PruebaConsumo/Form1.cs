using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace PruebaConsumo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        RestAPI rest = new RestAPI();
        
        Boolean tokenIsValid = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text.Trim();
            String pass = txtPassword.Text.Trim();

            AuthResponse clientResponse = rest.SignIn(user, pass);
            
            User userData = clientResponse.User;

            if(bool.Parse(clientResponse.Ok) == true)
            {
                String token = clientResponse.Token;
                DateTime tokenDate = DateTime.Parse(clientResponse.Date);
                int expiresIn = Int32.Parse(clientResponse.Expires_in);

                tokenIsValid = rest.ValidateToken(tokenDate, expiresIn);

                if (tokenIsValid == true)
                {
                    Console.WriteLine("TOKEN valid!");
                    LogInSuccesfull(userData);
                }
                else
                {
                    Console.WriteLine("TOKEN Invalid!");
                    TokenResponse newToken = rest.RefreshToken(token, userData.User_id);
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error: "+clientResponse.Message);
            }

            

            
        }

        public void LogInSuccesfull(User userData)
        {
           
            MessageBox.Show("Bienvenid@ " + userData.First_name + " " + userData.Last_name);
            this.Hide();
            Sesion frmSesion = new Sesion();
            frmSesion.ShowDialog();
           
        }
    }
}
