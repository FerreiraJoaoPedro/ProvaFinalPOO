using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ControleLojasRede.Code.DAL;
using ControleLojasRede.Code.DTO;

namespace ControleLojasRede.Code.BLL
{
    class ProdutoBLL
    {
        Conexao conect = new Conexao();
        string tabela = "produto";

        public void Inserir(ProdutoDTO prodDTO)
        {
            string inserir = $"insert into {tabela} values(null, '{prodDTO.Nome}', '{prodDTO.Categoria}', '{prodDTO.Preco}')";
            conect.ExecutarComando(inserir);
        }

        public void Alterar(ProdutoDTO prodDTO)
        {
            string alterar = $@"update {tabela} set nome = '{prodDTO.Nome}',
                                categoria ='{prodDTO.Categoria}',
                                preco ='{prodDTO.Preco}' where id ='{prodDTO.Id}';";
            conect.ExecutarComando(alterar);
        }

        public void Excluir(ProdutoDTO prodDTO)
        {
            string excluir = $"delete from {tabela} where id = {prodDTO.Id}";
            conect.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by id";
            return conect.ExecutarConsulta(listar);
        }
    }
}
