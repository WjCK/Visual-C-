using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Trabalho_4 {
    public partial class frmExcluirAluno : Form {
        public frmExcluirAluno() {
            InitializeComponent();
            carregarTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
                Session.Instance.conexao.Open();
            try {
                MySqlCommand comando = Session.Instance.conexao.CreateCommand();
                String sql = "DELETE FROM aluno WHERE matricula = @matricula";
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("matricula", Convert.ToInt32(editExcluir.Text));
                int resp = comando.ExecuteNonQuery();
                if (resp >= 1) {
                    MessageBox.Show("Excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            } catch (Exception) {
                MessageBox.Show("Falha ao excluir aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Session.Instance.conexao.Close();
            carregarTabela();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void carregarTabela() {
            MySqlConnection conexao = Session.Instance.conexao;
            conexao.Open();
            try {
                string sql = "SELECT * FROM aluno";
                MySqlDataAdapter dadosBD = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                dadosBD.Fill(tabela);
                tabelaAluno.AutoGenerateColumns = false;
                tabelaAluno.DataSource = tabela;
            } catch {
                MessageBox.Show("Falha ao visualizar tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexao.Close();
        }
    }
}
