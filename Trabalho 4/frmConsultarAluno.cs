using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Trabalho_4 {
    public partial class frmConsultarAluno : Form {
    
        public frmConsultarAluno() {
            InitializeComponent();
            fazerConsulta();
            carregarCursos("nome");
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            fazerConsulta();
        }

        private void fazerConsulta() {
            MySqlConnection conexao = Session.Instance.conexao;
            conexao.Open();
            try {
                String query = "select * from aluno ";
                if (rbNome.Checked) {
                    query += "where nome like '%" + editFiltrarNome.Text + "%'";
                }else if (rbCurso.Checked) {
                    carregarCursos("codigo");
                    query += "where codigo_curso like '%" + cmbFiltrarCurso.Text + "%'";
                    carregarCursos("nome");
                }else if (rbSetor.Checked) {
                    query += "where setor like '%" + editFiltrarSetor.Text + "%'";
                }else if (rbSexo.Checked) {
                    if (cmbFiltrarSexo.Text.Length != 0)
                        query += "where sexo like '%" + cmbFiltrarSexo.Text.Substring(0, 1) + "%'";
                    else
                        MessageBox.Show("Selecione um Sexo");
                } else {

                }
                MySqlDataAdapter dadosBD = new MySqlDataAdapter(query, conexao);
                DataTable tabela = new DataTable();
                dadosBD.Fill(tabela);
                dadosAluno.AutoGenerateColumns = false;
                dadosAluno.DataSource = tabela;
            } catch (Exception) {
                MessageBox.Show("Algum valor invalido");
            }
            conexao.Close();
        }

        private void carregarCursos(String member) {
            String sql = "SELECT codigo,nome FROM curso";
            MySqlDataAdapter dado = new MySqlDataAdapter(sql,Session.Instance.conexao);
            DataTable table = new DataTable();
            dado.Fill(table);
            cmbFiltrarCurso.DataSource = table;

            cmbFiltrarCurso.ValueMember = "codigo";
            cmbFiltrarCurso.DisplayMember = member;
        }

    }
}
