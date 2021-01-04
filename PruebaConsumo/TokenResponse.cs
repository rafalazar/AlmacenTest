using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsumo
{
    public class TokenResponse
    {
        private String ok;
        private String message;
        private String token;

        public string Ok { get => ok; set => ok = value; }
        public string Message { get => message; set => message = value; }
        public string Token { get => token; set => token = value; }
    }
}
