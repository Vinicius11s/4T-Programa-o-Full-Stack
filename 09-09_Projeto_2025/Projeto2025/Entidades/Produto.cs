using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Produto
    {
        public int id { get; set; }
        public String descricao { get; set; } = "";
        public Decimal? valor { get; set; }
        public DateTime datacadastro { get; set; }
        public bool ativo { get; set; }
        public int qtde { get; set; }
        public int idCategoria { get; set; }

        public Categoria categoria { get; set; }

    }
}
//public Decimal? valor { get; set; } "O ? indica que esta propriedade pode aceitar valores nulos"

