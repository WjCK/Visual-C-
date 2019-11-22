using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Trabalho_4 {
    public partial class frmAcademico : Form {
        public frmAcademico() {
            InitializeComponent();
        }
        
        private void incluirToolStripMenuItem_Click_1(object sender, EventArgs e) {
            frmIncluirAluno incluirAluno = new frmIncluirAluno();
            incluirAluno.MdiParent = this;
            incluirAluno.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e) {
            frmExcluirAluno excluirAluno = new frmExcluirAluno();
            excluirAluno.MdiParent = this;
            excluirAluno.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAlterarAluno alterarAluno = new frmAlterarAluno();
            alterarAluno.MdiParent = this;
            alterarAluno.Show();
        }

        private void pesquisarConsultarToolStripMenuItem_Click(object sender, EventArgs e) {
            frmConsultarAluno consultarAluno = new frmConsultarAluno();
            consultarAluno.MdiParent = this;
            consultarAluno.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Nome do programa: Management Students\n\n" +
                "Curso: Análise e Desenvolvimento de Sistemas\n\n" +
                "Disciplina: Ferramentas Visuais de Desenvolvimento de Software\n\n" +
                "Professor: Elias Ferreira\n\n" +
                "Alunos: Welder Novaes e Pedro Soares\n\n" +
                "Versão: 0.5\n\n" +
                "Desenvolvido em: 11/2019","Sobre",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e) {
            frmIncluirCurso incluirCurso = new frmIncluirCurso();
            incluirCurso.MdiParent = this;
            incluirCurso.Show();
        }

        private void alterarCursoToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAlterarCurso alterarCurso = new frmAlterarCurso();
            alterarCurso.MdiParent = this;
            alterarCurso.Show();
        }

        private void excluirCursoToolStripMenuItem_Click(object sender, EventArgs e) {
            frmExcluirCurso excluirCurso = new frmExcluirCurso();
            excluirCurso.MdiParent = this;
            excluirCurso.Show();
        }

        private void pesquisarConsultarCursoToolStripMenuItem_Click(object sender, EventArgs e) {
            frmConsultarCurso consultarCurso = new frmConsultarCurso();
            consultarCurso.MdiParent = this;
            consultarCurso.Show();
        }

        private void metroDefaultSetButton1_Click(object sender, EventArgs e) {
            if (abrirConexao(txtBanco.Text,txtUsuario.Text,txtSenha.Text)) {
                menuPrincipal.Visible = true;
                foreach (Control c in Controls) {
                    if (c is MetroSet_UI.Controls.MetroSetTextBox || c is Label || c is MetroSet_UI.Controls.MetroDefaultSetButton) { 
                        c.Visible = false;
                    }
                }
                MessageBox.Show("Conexão realizada com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Conexão não realizada!");
            }
        }
        private Boolean abrirConexao(String database, String uid, String pwd) {
            String caminho = "server=localhost;" +
                "database=" + database + ";" +
                "uid=" + uid + ";" +
                "pwd=" + pwd + ";";
            Session.Instance.conexao = new MySqlConnection(caminho);
            try {
                Session.Instance.conexao.Open();
                return true;
            } catch (Exception) {
                return false;
            }
        }
    }
}
