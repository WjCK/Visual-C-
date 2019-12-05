using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trabalho_4 {
    public partial class frmExcluirCurso : Form {
        public frmExcluirCurso() {
            InitializeComponent();
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e) {
            try {
                Session.Instance.conexao.Open();
                MySqlCommand comando = Session.Instance.conexao.CreateCommand();
                String sql = "DELETE FROM curso WHERE codigo = @codigo";
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("codigo", Convert.ToInt32(editExcluirCurso.Text));
                comando.ExecuteNonQuery();
                Session.Instance.conexao.Close();
            } catch (Exception) {
                MessageBox.Show("Erro ao excluir curso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
