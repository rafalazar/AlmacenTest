using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsumo
{
    public class AuthResponse
    {
        private String ok;
        private String message;
        private User user;
        private String token;
        private String expires_in;
        private String date;

        public string Ok { get => ok; set => ok = value; }
        public string Message { get => message; set => message = value; }
        public User User { get => user; set => user = value; }
        public string Token { get => token; set => token = value; }
        public string Expires_in { get => expires_in; set => expires_in = value; }
        public string Date { get => date; set => date = value; }
    }
}
