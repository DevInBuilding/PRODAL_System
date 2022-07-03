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
    public partial class TelaConsultaClientes : Form
    {
        private Usuario objUsuario = new Usuario();
        //private Cliente objCliente = new Cliente();
        private Administrador objAdmin = new Administrador();
        private ToolTip toolTipMessage = new ToolTip();

        public TelaConsultaClientes()
        {
            InitializeComponent();

            this.CreateColumssGridClientes();
            this.LoadRowsGridClientes();            
        }

        //MENU
        private void toolStripMenuItemFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja fechar a guia de consultas?", "ENCERRAMENTO DE CONSULTAS DO SISTEMA", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        //LISTA DE CLIENTES
        private void cbBoxFiltroConsulta_MouseEnter(object sender, EventArgs e)
        {
            toolTipMessage.SetToolTip(this.cbBoxFiltroConsulta, "Escolha um tipo de filtro");
        }

        private void txtBoxBuscaCliente_MouseEnter(object sender, EventArgs e)
        {
            toolTipMessage.SetToolTip(this.txtBoxBuscaCliente, "Digite o ID ou o nome do cliente, de acordo com o filtro selecionado");
        }

        private void SearchClients_DGVListaClientes(string searchClient)
        {
            DGVListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow row in DGVListaClientes.Rows)
            {
                bool findClient = false;

                for (int count = 0; count < row.Cells.Count; count++)
                {
                    if (row.Cells[count].Value != null && (row.Cells[count].Value.ToString().Equals(searchClient) ||
                        row.Cells[count].Value.ToString().Trim().ToUpper().Equals(searchClient.Trim().ToUpper()) ||
                        row.Cells[count].Value.ToString().Replace(".", "").Replace("-", "").Equals(searchClient.Trim())))
                    {
                        DGVListaClientes.Rows[row.Index].Selected = true;
                        findClient = true;
                        return;
                    }
                }
                if (!findClient)
                {
                    MessageBox.Show("Não foi possível encontrar o cliente na lista.");
                    return;
                }
            }
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscaCliente.Text))
            {
                MessageBox.Show(this, "Preencha o campo de busca corretamente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string valBusca = txtBoxBuscaCliente.Text;
                DGVListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                bool resultado = false;
                foreach (DataGridViewRow row in DGVListaClientes.Rows)
                {
                    DGVListaClientes.Rows[row.Index].Selected = false;
                    for (int i = 0; i < 3; i++)
                    {
                        if (row.Cells[i].Value != null && (row.Cells[i].Value.ToString().Replace(".", "").Replace("-","").Equals(valBusca) ||
                             row.Cells[i].Value.ToString().ToUpper().Replace(" ", "").Equals(valBusca.ToUpper().Replace(" ", ""))))
                        {
                            DGVListaClientes.Rows[row.Index].Selected = true;
                            //BUG na posição 2: corrigir [  ]
                            objUsuario = (Usuario)DGVListaClientes.Rows[row.Index].DataBoundItem;
                            LoadDataClientDescription();
                            resultado = true;
                            break;
                        }
                    }
                }
                if (!resultado)
                {
                    MessageBox.Show("Não foi possível localizar o cliente procurado.");
                    return;
                }
            }
        }

        //SESSAO: LISTA DE CLIENTES
        private void CreateColumssGridClientes()
        {
            DGVListaClientes.AutoGenerateColumns = false;
            DGVListaClientes.AllowUserToAddRows = false;
            DGVListaClientes.Columns.Clear();

            AddColumn("Id", "Nº Cadastro", "Id");
            AddColumn("Nome", "Nome do Cliente", "Nome");
            AddColumn("Cpf", "CPF", "Cpf");
            AddColumn("Status", "Status", "Status");
            AddColumn("Email", "Email", "Email");
        }

        public void AddColumn(string propertyName, string headerText, string columnName)
        {
            DGVListaClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = propertyName,
                HeaderText = headerText,
                Name = columnName,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void LoadRowsGridClientes()
        {
            DGVListaClientes.DataSource = Listas.ListaUsuarios;
        }

        private void DGVListaClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVListaClientes.CurrentRow != null && DGVListaClientes.CurrentRow.DataBoundItem != null)
            {
                objUsuario = (Usuario)DGVListaClientes.CurrentRow.DataBoundItem;
                LoadDataClientDescription();
            }
        }

        private void LoadDataClientDescription()
        {
            int idade = DateTime.Today.Year - objUsuario.Nascimento.Year;

            txtBoxIdCliente.Text = objUsuario.Id.ToString();
            txtBoxStatusCliente.Text = objUsuario.Status.ToString();
            txtBoxNomeCliente.Text = objUsuario.Nome.ToString();
            txtBoxCpfCliente.Text = objUsuario.Cpf.ToString();
            txtBoxIdadeCliente.Text = idade.ToString();
            txtBoxEmailCliente.Text = objUsuario.Email.ToString();
        }

        private void btnAtivarInativarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Você está prestes a inativar o cadastro de um cliente, o que não permitirá que ele possa realizar futuras alocações no sistema.", "INATIVAÇÃO DE CADASTRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (objUsuario == null || objUsuario.Id == 0)
                {
                    MessageBox.Show("OBS.: Nenhum cliente selecionado.");
                    return;
                }
                if (objUsuario.Status.Equals(EnumStatus.Inativo.ToString()))
                {
                    if (MessageBox.Show(this, "OBS.: O cliente já se encontra inativo no sistema. Deseja reativá-lo?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //objUsuario.AtivarCliente(objCliente);
                        //Confirmação da senha do administrador deve ser requerida [ ] 
                        return;
                    }
                }

                //Confirmação da senha do administrador deve ser requerida [ ]

                //objAdmin.InativarCliente(objUsuario);
                this.RefreshRowsGrid();
                MessageBox.Show($"Cliente de Nº {objUsuario.Id} inativado com sucesso.");
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            //Inserir senha
            //if (objLogin.Senha.Equals(objAdmin.Senha))
            //{

            //}
        }

        private void RefreshRowsGrid()
        {
            DGVListaClientes.Refresh();
            this.LoadDataClientDescription();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            TelaEdicaoDadosCadastrais.IdUsuario = objUsuario.Id;
            TelaEdicaoDadosCadastrais formEdicaoCliente = new TelaEdicaoDadosCadastrais();
            formEdicaoCliente.Show();
        }

        
    }
}