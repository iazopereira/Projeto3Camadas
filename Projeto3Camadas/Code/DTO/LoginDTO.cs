using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class UsuarioDTO
    {
        private int _id;
        private string _CPF;
        private string _email;
        private string _senha;

        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string CPF { get => _CPF; set => _CPF = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Nome { get; internal set; }
    }
}
