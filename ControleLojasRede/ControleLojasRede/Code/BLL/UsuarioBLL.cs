using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleLojasRede.Code.DAL;
using ControleLojasRede.Code.DTO;
using System.Data;

namespace ControleLojasRede.Code.BLL
{
    class UsuarioBLL
    {
        Conexao conect = new Conexao();
        string tabela = "usuario";

        public bool RealizarLogin(UsuarioDTO login)
        {
            string sql = $"select * from {tabela} where email ='{login.Email}' and senha ='{login.Senha}'";
            DataTable dt = conect.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
