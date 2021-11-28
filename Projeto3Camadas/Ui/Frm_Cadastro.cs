using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Cadastro : Form
    {

        //Criação dos objetos que acessam a camada de negócio
        UsuarioBLL medbll = new UsuarioBLL();
        UsuarioDTO meddto = new UsuarioDTO();


        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Nome = txtNome.Text;
            meddto.Senha = txtTelefone.Text;
            meddto.CPF = txtCPF.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Cadastrado com sucesso!", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpeza dos componentes
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //Preenchimento do objeto
            meddto.Id = int.Parse(txtId.Text);
            meddto.Nome = txtNome.Text;
            meddto.Senha = txtTelefone.Text;

            //Envio do dto preenchido para o método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        { 
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtId.Text);
         
            //Envio do dto preenchido para o método editar
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCPF.Clear();
            txtPaís.Clear();
        }

        private void Frm_Medicamentos_Load(object sender, EventArgs e) => dgvProdutos.DataSource = medbll.Listar();

        private void dgvMedicamentos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Quando o usuário clicar em um registro da lista, os dados serão preenchidos
            txtId.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRua.Text = dgvProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumero.Text = dgvProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text = dgvProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCidade.Text = dgvProdutos.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEstado.Text = dgvProdutos.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPais.Text = dgvProdutos.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCPF.Text = dgvProdutos.Rows[e.RowIndex].Cells[9].Value.ToString();
            dtpData.Text = dgvProdutos.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtPaís.Text = dgvProdutos.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
