using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsumo
{
    public class CrearCategoriaResponse
    {
        private String ok;
        private String message;

        public string Ok { get => ok; set => ok = value; }
        public string Message { get => message; set => message = value; }
    }
}
