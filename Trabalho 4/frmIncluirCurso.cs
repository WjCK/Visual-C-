using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroSet_UI.Forms;

namespace Trabalho_4 {
    public partial class frmIncluirCurso : Form {
        public frmIncluirCurso() {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            limpar();
        }

        private void btnSalvarCurso_Click(object sender, EventArgs e) {
            try {
                MySqlCommand comando = Session.Instance.conexao.CreateCommand();
                comando.CommandText = "Insert into curso (nome,area,preco_total)" +
                    "values (@nome,@area,@preco_total)";
                comando.Parameters.AddWithValue("nome", Convert.ToString(txtNomeCurso.Text));
                comando.Parameters.AddWithValue("area", cmbArea.Text.Substring(0, 1));
                comando.Parameters.AddWithValue("preco_total", Convert.ToDecimal(txtPrecoCurso.Text));
                comando.ExecuteNonQuery();
                limpar();
            } catch (Exception) {
                MessageBox.Show("Erro ao inserir curso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpar() {
            foreach (Control c in Controls) {
                if (c is MetroSet_UI.Controls.MetroSetTextBox || c is MetroSet_UI.Controls.MetroSetComboBox) {
                    c.Text = "";
                }
            }
            cmbArea.SelectedIndex = -1;
        }
    }
}
