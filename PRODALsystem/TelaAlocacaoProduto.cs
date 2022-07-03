using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRODALsystem
{
    public partial class TelaAlocacaoProduto : Form
    {
        public TelaAlocacaoProduto()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja sair da consulta de alocação?", "MENSAGEM GERADA PELO SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        private void cbBoxFiltraBuscaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}