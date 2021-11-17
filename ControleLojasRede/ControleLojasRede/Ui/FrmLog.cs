using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleLojasRede.Code.BLL;
using ControleLojasRede.Code.DTO;

namespace ControleLojasRede.Ui
{
    public partial class FrmLog : Form
    {
        UsuarioBLL loginBLL = new UsuarioBLL();
        UsuarioDTO loginDTO = new UsuarioDTO();
        public FrmLog()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                FrmProd frmProd = new FrmProd();
                frmProd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }
    }
}
