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
                if (c is MetroSet_UI.Controls.MetroSetTextBox) {
                    c.Text = "";
                }
                if (c is MetroSet_UI.Controls.MetroSetComboBox) {
                    cmbEstado.SelectedIndex = -1;
                    cmbSexo.SelectedIndex = -1;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (editNome.Text == "") {
                MessageBox.Show("O campo NOME está vazio");
            } else if (cmbSexo.Text == "") {
                MessageBox.Show("Por favor escolha um sexo");
            } else if (editLogradouro.Text == "") {
                MessageBox.Show("O campo LOGRADOURO está vazio");
            } else if (editNumero.Text == "") {
                MessageBox.Show("O campo NÚMERO está vazio");
            } else if (editSetor.Text == "") {
                MessageBox.Show("O campo SETOR está vazio");
            } else if (editCidade.Text == "") {
                MessageBox.Show("O campo CIDADE está vazio");
            } else if (cmbEstado.Text == "") {
                MessageBox.Show("Selecione um Estado");
            } else if (editCodigoCurso.Text == "") {
                MessageBox.Show("O campo CÓDIGO DO CURSO está vazio");
            } else {

                try {
                    MySqlCommand comando = Session.Instance.conexao.CreateCommand();
                    comando.CommandText = "Insert into aluno (nome,sexo,logradouro,numero,setor,cidade,uf,codigo_curso)" +
                        "values (@nome,@sexo,@logradouro,@numero,@setor,@cidade,@uf,@codigo_curso)";
                    comando.Parameters.AddWithValue("nome", Convert.ToString(editNome.Text));
                    comando.Parameters.AddWithValue("sexo", cmbSexo.Text);
                    comando.Parameters.AddWithValue("logradouro", Convert.ToString(editLogradouro.Text));
                    comando.Parameters.AddWithValue("numero", Convert.ToInt32(editNumero.Text));
                    comando.Parameters.AddWithValue("setor", Convert.ToString(editSetor.Text));
                    comando.Parameters.AddWithValue("cidade", Convert.ToString(editCidade.Text));
                    comando.Parameters.AddWithValue("uf", cmbEstado.Text);
                    comando.Parameters.AddWithValue("codigo_curso", Convert.ToInt32(editCodigoCurso.Text));
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Inserção realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    editNome.Text = "";
                    cmbSexo.Text = "";
                    editLogradouro.Text = "";
                    editNumero.Text = "";
                    editSetor.Text = "";
                    editCidade.Text = "";
                    cmbEstado.Text = "";
                    editCodigoCurso.Text = "";

                } catch (MySqlException) {
                    MessageBox.Show("Alguma informação invalida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
