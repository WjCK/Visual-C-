using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Trabalho_4 {
    public partial class frmConsultarAluno : Form {
    
        public frmConsultarAluno() {
            InitializeComponent();
            fazerConsulta();
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            if (editFiltrarNome.Text.Equals("") && editFiltrarSetor.Text.Equals("")
                && editFiltrarCurso.Text.Equals("") && editFiltrarSexo.Text.Equals("")) {
                MessageBox.Show("Todos os filtros estão vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fazerConsulta() {
            try {
                MySqlConnection conexao = Session.Instance.conexao;
                conexao.Close();
                conexao.Open();

                try {
                    String sql = "SELECT * FROM aluno where nome like %" + editFiltrarNome.Text + "% and" +
                        "curso like %" + editFiltrarCurso.Text + "% and " +
                        "setor like %" + editFiltrarSetor.Text + "% and " +
                        "sexo like %" + editFiltrarSexo.Text + "%;";
                    MySqlDataAdapter dadosBD = new MySqlDataAdapter(sql, conexao);

                    DataTable tabela = new DataTable();
                    dadosBD.Fill(tabela);
                    dadosAluno.AutoGenerateColumns = false;
                    dadosAluno.DataSource = tabela;
                } catch (Exception) {
                   
                }

            } catch (Exception) {
                MessageBox.Show("Erro ao conectar no banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
