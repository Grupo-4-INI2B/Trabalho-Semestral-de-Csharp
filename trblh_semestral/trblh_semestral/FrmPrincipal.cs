using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trblh_semestral
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            FrmPesquisa frmPesquisa = new FrmPesquisa();
            frmPesquisa.ShowDialog();
        }
        private void BtnCadProd_Click(object sender, EventArgs e)
        {
            FrmCadProd frmCadProd = new FrmCadProd();
            frmCadProd.ShowDialog();
        }

        private void BtnCadFor_Click(object sender, EventArgs e) //cadastro fornecedor
        {
            FrmCadFor frmCadFor = new FrmCadFor();
            frmCadFor.ShowDialog();
        }

        private void BtnInformacoes_Click(object sender, EventArgs e)
        {
            FrmInformacoes frmInformacoes = new FrmInformacoes();
            frmInformacoes.ShowDialog();
        }

        private void LblOqDeseja_Click(object sender, EventArgs e)
        {

        }

    }
}
