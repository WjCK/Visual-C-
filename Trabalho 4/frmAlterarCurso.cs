using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Trabalho_4 {
    public partial class frmAlterarCurso : Form {
        public frmAlterarCurso() {
            InitializeComponent();
            carregarTabela();
            MessageBox.Show("Atenção!!!\n\n" +
                "Clique duas vezes na celula anterior ao codigo!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            MySqlConnection conexao = Session.Instance.conexao;
            conexao.Open();
            try {
                MySqlCommand comando = conexao.CreateCommand();
                String sql = "UPDATE curso SET nome = @Nome," +
                    " area = @Area, preco_total = @Preco_total WHERE codigo = " + editCodigoCurso.Text;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("Nome", editNome.Text);
                comando.Parameters.AddWithValue("Area", cmbArea.Text.Substring(0, 1));
                try {
                    comando.Parameters.AddWithValue("Preco_total", Convert.ToDouble(editPreco.Text));
                } catch {
                    MessageBox.Show("Digite um valor numerico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comando.ExecuteNonQuery();
                MessageBox.Show("Atualização de informações realizada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception) {
                MessageBox.Show("Alguma informação inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexao.Close();
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
                MessageBox.Show("Não foi possivel visualizar a tabela");
            }
            conexao.Close();
        }

        private void gridCurso_MouseDoubleClick_1(object sender, MouseEventArgs e) {
            editCodigoCurso.Text = gridCurso.SelectedRows[0].Cells[0].Value.ToString();
            editNome.Text = gridCurso.SelectedRows[0].Cells[1].Value.ToString();
            if (gridCurso.SelectedRows[0].Cells[2].Value.Equals("E")) {
                cmbArea.Text = "Exatas";
            } else if (gridCurso.SelectedRows[0].Cells[2].Value.Equals("H")) {
                cmbArea.Text = "Humanas";
            } else {
                cmbArea.Text = "Biológicas";
            }
            cmbArea.Text = gridCurso.SelectedRows[0].Cells[2].Value.ToString();
            editPreco.Text = gridCurso.SelectedRows[0].Cells[3].Value.ToString();
            editCodigoCurso.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }
    }

}

