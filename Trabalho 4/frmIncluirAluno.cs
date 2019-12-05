using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace Trabalho_4 {
    public partial class frmIncluirAluno : Form {

        public frmIncluirAluno() {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            foreach (Control c in Controls) {
                if (c is MetroSet_UI.Controls.MetroSetTextBox) {
                    c.Text = "";
                }
                if (c is MetroSet_UI.Controls.MetroSetComboBox) {
                    cmbEstado.SelectedIndex = -1;
                    cmbSexo.SelectedIndex = -1;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (editNome.Text == "") {
                MessageBox.Show("O campo NOME está vazio");
            } else if (cmbSexo.Text == "") {
                MessageBox.Show("Por favor escolha um sexo");
            } else if (editLogradouro.Text == "") {
                MessageBox.Show("O campo LOGRADOURO está vazio");
            } else if (editNumero.Text == "") {
                MessageBox.Show("O campo NÚMERO está vazio");
            } else if (editSetor.Text == "") {
                MessageBox.Show("O campo SETOR está vazio");
            } else if (editCidade.Text == "") {
                MessageBox.Show("O campo CIDADE está vazio");
            } else if (cmbEstado.Text == "") {
                MessageBox.Show("Selecione um Estado");
            } else {

                try {
                    MySqlCommand comando = Session.Instance.conexao.CreateCommand();
                    comando.CommandText = "INSERT INTO aluno (nome, sexo, logradouro, numero, setor, cidade, uf, codigo_curso)" +
                        " VALUES (@nome, @sexo, @logradouro, @numero, @setor, @cidade, @uf, @codigo_curso);";
                    comando.Parameters.AddWithValue("nome", editNome.Text);
                    comando.Parameters.AddWithValue("sexo", cmbSexo.Text.Substring(0,1));
                    comando.Parameters.AddWithValue("logradouro", editLogradouro.Text);
                    comando.Parameters.AddWithValue("numero", Convert.ToInt32(editNumero.Text));
                    comando.Parameters.AddWithValue("setor", editSetor.Text);
                    comando.Parameters.AddWithValue("cidade", editCidade.Text);
                    comando.Parameters.AddWithValue("uf", cmbEstado.Text);
                    cmbCurso.DisplayMember = "codigo";
                    comando.Parameters.AddWithValue("codigo_curso", cmbCurso.Text);
                    cmbCurso.DisplayMember = "nome";
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Inserção realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    editNome.Text = "";
                    cmbSexo.Text = "";
                    editLogradouro.Text = "";
                    editNumero.Text = "";
                    editSetor.Text = "";
                    editCidade.Text = "";
                    cmbEstado.Text = "";
                    cmbCurso.SelectedIndex = -1;
                    Session.Instance.conexao.Close();
                } catch (MySqlException) {
                    MessageBox.Show("Alguma informação invalida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmIncluirAluno_Load(object sender, EventArgs e) {
            DataTable table = new DataTable();
            MySqlConnection conexao = Session.Instance.conexao;
            conexao.Open();
            try {

            
            String sql = "SELECT codigo,nome FROM curso";
            MySqlDataAdapter dado = new MySqlDataAdapter(sql, conexao);
            dado.Fill(table);
            cmbCurso.DataSource = table;

            cmbCurso.ValueMember = "codigo";
            cmbCurso.DisplayMember = "nome";
            
            } catch {

            }
        }
    }
}
