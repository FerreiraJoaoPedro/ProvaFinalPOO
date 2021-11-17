using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleLojasRede.Code.DTO
{
    class ProdutoDTO
    {
        private int _id;
        private string _nome;
        private string _categoria;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
