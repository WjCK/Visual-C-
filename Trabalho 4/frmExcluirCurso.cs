using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Trabalho_4 {
    public partial class frmExcluirCurso : Form {
        public frmExcluirCurso() {
            InitializeComponent();
            carregarTabela();
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e) {
            Session.Instance.conexao.Open();
            if (editExcluirCurso.Text == "") {
                MessageBox.Show("O campo está vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try {
                MySqlCommand comando = Session.Instance.conexao.CreateCommand();
                String sql = "DELETE FROM curso WHERE codigo = @codigo";
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("codigo", Convert.ToInt32(editExcluirCurso.Text));
                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão de curso realizada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception) {
                MessageBox.Show("Erro ao excluir curso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Session.Instance.conexao.Close();
            carregarTabela();
        }

        private void carregarTabela() {
            MySqlConnection conexao = Session.Instance.conexao;
            conexao.Open();
            try {
                String query = "SELECT * FROM curso";
                MySqlDataAdapter dadosBD = new MySqlDataAdapter(query, conexao);
                DataTable tabela = new DataTable();
                dadosBD.Fill(tabela);
                gridCurso.AutoGenerateColumns = false;
                gridCurso.DataSource = tabela;
            } catch {
                MessageBox.Show("Não foi possivel ver a tabela");
            }
            conexao.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
