using System.Data;

//Importação da camada de negócio e da camada de acesso a dados
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.Code.DAL; //nomeProjeto.nomeDaPasta.nomeDaPasta
using System;

namespace Projeto3Camadas.Code.BLL
{
    class LoginBLL
    {

        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Usuario";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir (UsuarioDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome}','{medDto.Senha}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        internal bool RealizarLogin(UsuarioDTO usuarioDTO)
        {
            throw new NotImplementedException();
        }

        public void Editar(UsuarioDTO medDto)
        {
            string alterar = $"update {tabela} set medicamento = '{medDto.Nome}', composicao = '{medDto.Senha}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(UsuarioDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }

        internal string RetornarSenha(UsuarioDTO usuarioDTO)
        {
            throw new NotImplementedException();
        }
    }
}
