using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class ProdutoDTO
    {
        //Properiedades privadas
        private int _id;
        private string _usuario;
        private string _senha;

        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string usuario { get => _usuario; set => _usuario = value; }
        public string senha { get => _senha; set => _senha= value; }
    }
}
