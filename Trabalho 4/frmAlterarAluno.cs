using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Trabalho_4 {
    public partial class frmAlterarAluno : Form {
        public frmAlterarAluno() {
            InitializeComponent();
            carregarTabela();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void carregarTabela() {
            MySqlConnection conexao = Session.Instance.conexao;
            conexao.Open();
            try {
                String query = "SELECT * FROM aluno";
                MySqlDataAdapter dadosBD = new MySqlDataAdapter(query, conexao);
                DataTable tabela = new DataTable();
                dadosBD.Fill(tabela);
                dadosAluno.AutoGenerateColumns = false;
                dadosAluno.DataSource = tabela;
                cmbCurso.DisplayMember = "nome";

                String sql = "SELECT codigo,nome FROM curso";
                MySqlDataAdapter dado = new MySqlDataAdapter(sql, conexao);
                DataTable table = new DataTable();
                dado.Fill(table);
                cmbCurso.DataSource = table;

                cmbCurso.ValueMember = "codigo";
                cmbCurso.DisplayMember = "nome";
            } catch {
                MessageBox.Show("Não foi possivel ver");
            }
            conexao.Close();
        }

        private void dadosAluno_MouseDoubleClick(object sender, MouseEventArgs e) {
            editMatricula.Text = dadosAluno.SelectedRows[0].Cells[0].Value.ToString();
            editNome.Text = dadosAluno.SelectedRows[0].Cells[1].Value.ToString();

            if (dadosAluno.SelectedRows[0].Cells[2].Value.Equals("M"))
                cmbSexo.Text = "Masculino";
            else {
                cmbSexo.Text = "Feminino";
            }

            editLogradouro.Text = dadosAluno.SelectedRows[0].Cells[3].Value.ToString();
            editNumero.Text = dadosAluno.SelectedRows[0].Cells[4].Value.ToString();
            editSetor.Text = dadosAluno.SelectedRows[0].Cells[5].Value.ToString();
            editCidade.Text = dadosAluno.SelectedRows[0].Cells[6].Value.ToString();
            cmbEstado.Text = dadosAluno.SelectedRows[0].Cells[7].Value.ToString();
            cmbCurso.DisplayMember = "codigo";
            cmbCurso.Text = dadosAluno.SelectedRows[0].Cells[8].Value.ToString();
            cmbCurso.DisplayMember = "nome";
            editMatricula.ReadOnly = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            MySqlConnection conexao = Session.Instance.conexao;
            conexao.Open();
            try {
                MySqlCommand comando = conexao.CreateCommand();
                String sql = "UPDATE aluno SET nome = @Nome," +
                    " sexo = @Sexo, logradouro = @Logradouro, numero = @Numero," +
                    " setor = @Setor, cidade = @Cidade, uf = @Estado," +
                    " codigo_curso = @Curso WHERE matricula = " + editMatricula.Text;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("Nome", editNome.Text);
                comando.Parameters.AddWithValue("Sexo", cmbSexo.Text.Substring(0,1));
                comando.Parameters.AddWithValue("Logradouro", editLogradouro.Text);
                comando.Parameters.AddWithValue("Setor", editSetor.Text);
                comando.Parameters.AddWithValue("Numero", editNumero.Text);
                comando.Parameters.AddWithValue("Cidade", editCidade.Text);
                comando.Parameters.AddWithValue("Estado", cmbEstado.Text);

                cmbCurso.DisplayMember = "codigo";
                comando.Parameters.AddWithValue("Curso", cmbCurso.Text);
                cmbCurso.DisplayMember = "nome";

                comando.ExecuteNonQuery();
                MessageBox.Show("Atualização de informações realizada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception) {
                MessageBox.Show("Alguma informação inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexao.Close();
            carregarTabela();
        }
    }
}
