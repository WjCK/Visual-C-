using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trabalho_4 {
    public partial class frmIncluirCurso : Form {
        public frmIncluirCurso() {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            foreach(Control c in Controls) {
                if(c is MetroSet_UI.Controls.MetroSetTextBox) {
                    c.Text = "";
                }
            }
        }

        private void btnSalvarCurso_Click(object sender, EventArgs e) {
            MySqlCommand comando = Session.Instance.conexao.CreateCommand();
            comando.CommandText = "Insert into curso (nome,area,preco_total)" +
                "values (@nome,@area,@preco_total)";
            comando.Parameters.AddWithValue("nome", txtNomeCurso.Text);
            comando.Parameters.AddWithValue("area", cmbArea.Text.Substring(0,1));
            comando.Parameters.AddWithValue("preco_total",Convert.ToDecimal(txtPrecoCurso.Text));
            comando.ExecuteNonQuery();
        }
    }
}
