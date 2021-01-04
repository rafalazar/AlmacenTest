using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsumo
{
    public class User
    {
        private String user_id;
        private String role_id;
        private String token_id;
        private String username;
        private String state;
        private String role_name;
        private String first_name;
        private String last_name;

        public string User_id { get => user_id; set => user_id = value; }
        public string Role_id { get => role_id; set => role_id = value; }
        public string Token_id { get => token_id; set => token_id = value; }
        public string Username { get => username; set => username = value; }
        public string State { get => state; set => state = value; }
        public string Role_name { get => role_name; set => role_name = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
    }
}
