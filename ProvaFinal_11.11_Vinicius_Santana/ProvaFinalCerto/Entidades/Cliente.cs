using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public Cliente() {
            Enderecos = new HashSet<Endereco>();
        
        }
        public int id { get; set; }
        public String Nome { get; set; } = String.Empty;
        public String Email { get; set; } = String.Empty;

        public virtual ICollection<Endereco> Enderecos { get; set; }


    }
}
