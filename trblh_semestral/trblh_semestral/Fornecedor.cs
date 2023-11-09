using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trblh_semestral
{
    internal class Fornecedor
    {
        //public Fornecedor() { }
        public int idFornecedor { get; set; }
        public string nomeFornecedor { get; private set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
    }
}
