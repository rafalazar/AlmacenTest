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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text.Trim();
            String pass = txtPassword.Text.Trim();

            AuthResponse clientResponse = rest.SignIn(user, pass);
            
            User userData = clientResponse.User;

            if(bool.Parse(clientResponse.Ok) == true)
            {
                Console.WriteLine(clientResponse.Token);
                LogInSuccesfull(userData, clientResponse);
            }
            else
            {
                MessageBox.Show("Ocurrió un error: "+clientResponse.Message);
            }

            

            
        }

        public void LogInSuccesfull(User userData, AuthResponse clientResponse)
        {
           
            MessageBox.Show("Bienvenid@ " + userData.First_name + " " + userData.Last_name);
            this.Hide();
            Sesion frmSesion = new Sesion();
            frmSesion.response = clientResponse;
            frmSesion.ShowDialog();
            
        }
    }
}
