using System.Data;

//Importação da camada de negócio e da camada de acesso a dados
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.Code.DAL; //nomeProjeto.nomeDaPasta.nomeDaPasta
using System;

namespace Projeto3Camadas.Code.BLL
{
    class UsuarioBLL
    {

        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Login";

        public bool RealizarLogin(UsuarioDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;            
            else
                return false;
        }

        internal void Inserir(UsuarioDTO meddto)
        {
            throw new NotImplementedException();
        }

        public string RetornarSenha(UsuarioDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }

        internal void Editar(UsuarioDTO meddto)
        {
            throw new NotImplementedException();
        }

        internal void Listar()
        {
            throw new NotImplementedException();
        }

        internal void Excluir(UsuarioDTO meddto)
        {
            throw new NotImplementedException();
        }
    }
}
