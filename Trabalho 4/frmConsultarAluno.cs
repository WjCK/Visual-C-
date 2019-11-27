using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Trabalho_4 {
    public partial class frmConsultarAluno : Form {
        String path = "server = localhost; database = academico; uid = root; pwd = drug1";
        public frmConsultarAluno() {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            if (editFiltrarNome.Text.Equals("") && editFiltrarSetor.Text.Equals("")
                && editFiltrarCurso.Text.Equals("") && editFiltrarSexo.Text.Equals("")) {
                MessageBox.Show("Todos os filtros estão vazios");
            }


        }

        private void fazerConsulta(String consulta, String dados) {
            try {
                MySqlConnection conexao = new MySqlConnection(path);
                conexao.Open();

                try {
                    String sql = "SELECT * FROM aluno";
                    MySqlDataAdapter dadosBD = new MySqlDataAdapter(sql, conexao);

                    DataTable tabela = new DataTable();
                    dadosBD.Fill(tabela);
                    dadosAluno.AutoGenerateColumns = false;
                    dadosAluno.DataSource = tabela;
                } catch (Exception) {
                    MessageBox.Show("Erro ao consultar no banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception) {
                MessageBox.Show("Erro ao conectar no banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
