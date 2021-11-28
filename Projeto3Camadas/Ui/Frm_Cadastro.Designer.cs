
namespace Projeto3Camadas.Ui
{
    partial class Frm_Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Rg = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Rua = new System.Windows.Forms.Label();
            this.txtPaís = new System.Windows.Forms.TextBox();
            this.lbl_país = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(11, 24);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 5;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(9, 9);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "ID";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(105, 9);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(39, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "NOME";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(229, 24);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(84, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(226, 9);
            this.lbl_Telefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(63, 13);
            this.lbl_Telefone.TabIndex = 8;
            this.lbl_Telefone.Text = "TELEFONE";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 24);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(80, 20);
            this.txtNome.TabIndex = 11;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(139, 109);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(163, 26);
            this.btn_Cadastrar.TabIndex = 12;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(333, 109);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 26);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(529, 109);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(163, 26);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(35, 159);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 62;
            this.dgvProdutos.RowTemplate.Height = 28;
            this.dgvProdutos.Size = new System.Drawing.Size(777, 177);
            this.dgvProdutos.TabIndex = 15;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellClick_1);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(286, 74);
            this.txtRg.Margin = new System.Windows.Forms.Padding(2);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(127, 20);
            this.txtRg.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "DATA DE NASCIMENTO";
            // 
            // lbl_Rg
            // 
            this.lbl_Rg.AutoSize = true;
            this.lbl_Rg.Location = new System.Drawing.Point(284, 59);
            this.lbl_Rg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rg.Name = "lbl_Rg";
            this.lbl_Rg.Size = new System.Drawing.Size(23, 13);
            this.lbl_Rg.TabIndex = 18;
            this.lbl_Rg.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(139, 73);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(122, 20);
            this.txtCPF.TabIndex = 17;
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(137, 58);
            this.lbl_CPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.lbl_CPF.TabIndex = 16;
            this.lbl_CPF.Text = "CPF";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(333, 24);
            this.txtRua.Margin = new System.Windows.Forms.Padding(2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(80, 20);
            this.txtRua.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(636, 24);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(86, 20);
            this.txtCidade.TabIndex = 24;
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(633, 9);
            this.lbl_Cidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(47, 13);
            this.lbl_Cidade.TabIndex = 23;
            this.lbl_Cidade.Text = "CIDADE";
            // 
            // lbl_Rua
            // 
            this.lbl_Rua.AutoSize = true;
            this.lbl_Rua.Location = new System.Drawing.Point(331, 9);
            this.lbl_Rua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rua.Name = "lbl_Rua";
            this.lbl_Rua.Size = new System.Drawing.Size(30, 13);
            this.lbl_Rua.TabIndex = 22;
            this.lbl_Rua.Text = "RUA";
            // 
            // txtPaís
            // 
            this.txtPaís.Location = new System.Drawing.Point(732, 74);
            this.txtPaís.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaís.Name = "txtPaís";
            this.txtPaís.Size = new System.Drawing.Size(80, 20);
            this.txtPaís.TabIndex = 29;
            // 
            // lbl_país
            // 
            this.lbl_país.AutoSize = true;
            this.lbl_país.Location = new System.Drawing.Point(735, 58);
            this.lbl_país.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_país.Name = "lbl_país";
            this.lbl_país.Size = new System.Drawing.Size(31, 13);
            this.lbl_país.TabIndex = 26;
            this.lbl_país.Text = "PAÍS";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(738, 24);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(74, 20);
            this.txtEstado.TabIndex = 31;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(735, 9);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(51, 13);
            this.lbl_Estado.TabIndex = 30;
            this.lbl_Estado.Text = "ESTADO";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(12, 73);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(91, 20);
            this.txtPais.TabIndex = 33;
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Location = new System.Drawing.Point(9, 58);
            this.lbl_Pais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(31, 13);
            this.lbl_Pais.TabIndex = 32;
            this.lbl_Pais.Text = "PAIS";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(458, 74);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(222, 20);
            this.dtpData.TabIndex = 34;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(434, 24);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(84, 20);
            this.txtNumero.TabIndex = 36;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(431, 9);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 13);
            this.lblNumero.TabIndex = 35;
            this.lblNumero.Text = "NUMERO";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(534, 24);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(80, 20);
            this.txtBairro.TabIndex = 38;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(531, 9);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 13);
            this.lblBairro.TabIndex = 37;
            this.lblBairro.Text = "BAIRRO";
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 347);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lbl_Pais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.txtPaís);
            this.Controls.Add(this.lbl_país);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Rua);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Rg);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbl_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Cadastro";
            this.Text = "Cadastro de Usuarios";
            this.Load += new System.EventHandler(this.Frm_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Rg;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Rua;
        private System.Windows.Forms.TextBox txtPaís;
        private System.Windows.Forms.Label lbl_país;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lbl_Pais;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
    }
}