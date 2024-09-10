using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public Categoria() {
            this.produtos= new HashSet<Produto>(); //instanciei no construtor, dps falar no contexto On
                                                   //modelCriate
        }
        public int id { get; set; }
        public String descricao { get; set; } = "";

        public virtual ICollection<Produto> produtos { get; set; }
    }
}
