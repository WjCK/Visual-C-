using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trabalho_4 {
    public partial class frmExcluirAluno : Form {
        public frmExcluirAluno() {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
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
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
