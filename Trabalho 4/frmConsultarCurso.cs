using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Trabalho_4 {
    public partial class frmConsultarCurso : Form {
        public frmConsultarCurso() {
            InitializeComponent();
            carregarTabela();
        }

        private void btnPesquisarCurso_Click(object sender, EventArgs e) {
            carregarTabela();
        }
        private void carregarTabela() {
            MySqlConnection conexao = Session.Instance.conexao;
            try {
                String query;
                if (cmbFiltrarArea.Text.Length != 0) {
                    query = "SELECT * FROM curso where nome like '%" + editFiltrarCurso.Text + "%' and " +
                    "area like '%" + cmbFiltrarArea.Text.Substring(0,1) + "%'";
                } else
                    query = "SELECT * FROM curso where nome like '%" + editFiltrarCurso.Text + "%'";
                
                MySqlDataAdapter dadosBD = new MySqlDataAdapter(query, conexao);
                DataTable tabela = new DataTable();
                dadosBD.Fill(tabela);
                gridCurso.AutoGenerateColumns = false;
                gridCurso.DataSource = tabela;
            } catch {
                MessageBox.Show("Não foi possivel ver a tabela");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            foreach (Control c in Controls) {
                if (c is MetroSet_UI.Controls.MetroSetTextBox) {
                    c.Text = "";
                }
                if (c is MetroSet_UI.Controls.MetroSetComboBox) {
                    cmbFiltrarArea.SelectedIndex = -1;
                }
            }
        }
    }
}
