using Projeto01CasaDoCodigo.Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01CasaDoCodigo.Modelo.Cadastros
{
    public class Produto
    {
        
        public long? ProdutoId { get; set; }

       
        public string Nome { get; set; }

        [DisplayName("Categoria")]
        public long? CategoriaId { get; set; }

        [DisplayName("Fabricante")]
        public long? FabricanteId { get; set; }


        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
}
