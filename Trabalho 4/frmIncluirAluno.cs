using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

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
                if (c is TextBox) {
                    c.Text = "";
                }
            }
            cmbSexo.Text = String.Empty;
            cmbEstado.Text = String.Empty;
            cmbCurso.Text = String.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {

        }
    }
}
