using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Trabalho_4 {
    public partial class frmIncluirAluno : Form {
        public frmIncluirAluno() {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            foreach (Control c in Controls) {
                if (c is TextBox || c is ComboBox) {
                    c.Text = "";
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                MySqlCommand comando = Session.Instance.conexao.CreateCommand();
                comando.CommandText = "Insert into aluno (nome,sexo,logradouro,numero,setor,cidade,uf,codigo_curso)" +
                    "values (@nome,@sexo,@logradouro,@numero,@setor,@cidade,@uf,@codigo_curso)";
                comando.Parameters.AddWithValue("nome", txtNome.Text);
                comando.Parameters.AddWithValue("sexo", cmbSexo.Text.Substring(0,1));
                comando.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
                comando.Parameters.AddWithValue("numero", Convert.ToInt32(txtNumero.Text));
                comando.Parameters.AddWithValue("setor", txtSetor.Text);
                comando.Parameters.AddWithValue("cidade", txtCidade.Text);
                comando.Parameters.AddWithValue("uf", cmbEstado.Text);
                comando.Parameters.AddWithValue("codigo_curso", cmbCurso.Text);
                comando.ExecuteNonQuery();
            } catch (MySqlException) {
                MessageBox.Show("Alguma informação invalida");
            }
        }
    }
}
