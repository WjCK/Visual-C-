using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                "Versão: 0.4\n\n" +
                "Desenvolvido em: 11/2019" + MessageBoxButtons.OK + MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
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
    }
}
