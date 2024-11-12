using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Endereco
    {
        public int id { get; set; }
        public String Rua { get; set; } = String.Empty;
        public String Cidade { get; set; } = String.Empty;

        public int? idCliente { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}
