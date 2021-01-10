using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsumo
{
    public class Result
    {
        private String category_id;
        private String category_name;
        private String state;

        public string Category_id { get => category_id; set => category_id = value; }
        public string Category_name { get => category_name; set => category_name = value; }
        public string State { get => state; set => state = value; }
    }
}
