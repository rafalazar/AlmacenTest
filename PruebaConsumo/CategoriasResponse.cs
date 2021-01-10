using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsumo
{
    public class CategoriasResponse
    {
        private String ok;
        private String message;
        private List<Result> result;

        public string Ok { get => ok; set => ok = value; }
        public string Message { get => message; set => message = value; }
        public List<Result> Result { get => result; set => result = value; }
    }
}
