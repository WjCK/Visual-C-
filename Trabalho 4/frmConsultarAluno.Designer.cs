namespace Trabalho_4 {
    partial class frmConsultarAluno {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblFiltrarNome = new System.Windows.Forms.Label();
            this.txtFiltrarNome = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTituloConsultar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFiltrarCurso = new System.Windows.Forms.Label();
            this.txtFiltrarCurso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnPesquisar = new MetroSet_UI.Controls.MetroSetButton();
            this.btnFechar = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrarNome
            // 
            this.lblFiltrarNome.AutoSize = true;
            this.lblFiltrarNome.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarNome.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarNome.Location = new System.Drawing.Point(188, 79);
            this.lblFiltrarNome.Name = "lblFiltrarNome";
            this.lblFiltrarNome.Size = new System.Drawing.Size(139, 24);
            this.lblFiltrarNome.TabIndex = 0;
            this.lblFiltrarNome.Text = "Filtrar por nome:";
            // 
            // txtFiltrarNome
            // 
            this.txtFiltrarNome.AutoCompleteCustomSource = null;
            this.txtFiltrarNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFiltrarNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFiltrarNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtFiltrarNome.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtFiltrarNome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarNome.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFiltrarNome.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtFiltrarNome.Image = null;
            this.txtFiltrarNome.Lines = null;
            this.txtFiltrarNome.Location = new System.Drawing.Point(333, 79);
            this.txtFiltrarNome.MaxLength = 32767;
            this.txtFiltrarNome.Multiline = false;
            this.txtFiltrarNome.Name = "txtFiltrarNome";
            this.txtFiltrarNome.ReadOnly = false;
            this.txtFiltrarNome.Size = new System.Drawing.Size(302, 31);
            this.txtFiltrarNome.Style = MetroSet_UI.Design.Style.Dark;
            this.txtFiltrarNome.StyleManager = null;
            this.txtFiltrarNome.TabIndex = 1;
            this.txtFiltrarNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltrarNome.ThemeAuthor = "Narwin";
            this.txtFiltrarNome.ThemeName = "MetroDark";
            this.txtFiltrarNome.UseSystemPasswordChar = false;
            this.txtFiltrarNome.WatermarkText = "";
            // 
            // lblTituloConsultar
            // 
            this.lblTituloConsultar.AutoSize = true;
            this.lblTituloConsultar.Font = new System.Drawing.Font("Muli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultar.ForeColor = System.Drawing.Color.White;
            this.lblTituloConsultar.Location = new System.Drawing.Point(297, 9);
            this.lblTituloConsultar.Name = "lblTituloConsultar";
            this.lblTituloConsultar.Size = new System.Drawing.Size(198, 35);
            this.lblTituloConsultar.TabIndex = 2;
            this.lblTituloConsultar.Text = "Consultar Aluno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 201);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblFiltrarCurso
            // 
            this.lblFiltrarCurso.AutoSize = true;
            this.lblFiltrarCurso.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCurso.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarCurso.Location = new System.Drawing.Point(188, 150);
            this.lblFiltrarCurso.Name = "lblFiltrarCurso";
            this.lblFiltrarCurso.Size = new System.Drawing.Size(137, 24);
            this.lblFiltrarCurso.TabIndex = 4;
            this.lblFiltrarCurso.Text = "Filtrar por curso:";
            // 
            // txtFiltrarCurso
            // 
            this.txtFiltrarCurso.AutoCompleteCustomSource = null;
            this.txtFiltrarCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFiltrarCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFiltrarCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtFiltrarCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtFiltrarCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFiltrarCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtFiltrarCurso.Image = null;
            this.txtFiltrarCurso.Lines = null;
            this.txtFiltrarCurso.Location = new System.Drawing.Point(333, 150);
            this.txtFiltrarCurso.MaxLength = 32767;
            this.txtFiltrarCurso.Multiline = false;
            this.txtFiltrarCurso.Name = "txtFiltrarCurso";
            this.txtFiltrarCurso.ReadOnly = false;
            this.txtFiltrarCurso.Size = new System.Drawing.Size(302, 31);
            this.txtFiltrarCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.txtFiltrarCurso.StyleManager = null;
            this.txtFiltrarCurso.TabIndex = 5;
            this.txtFiltrarCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltrarCurso.ThemeAuthor = "Narwin";
            this.txtFiltrarCurso.ThemeName = "MetroDark";
            this.txtFiltrarCurso.UseSystemPasswordChar = false;
            this.txtFiltrarCurso.WatermarkText = "";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPesquisar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPesquisar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisar.HoverTextColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(290, 239);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisar.NormalTextColor = System.Drawing.Color.White;
            this.btnPesquisar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPesquisar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPesquisar.PressTextColor = System.Drawing.Color.White;
            this.btnPesquisar.Size = new System.Drawing.Size(79, 29);
            this.btnPesquisar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnPesquisar.StyleManager = null;
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.ThemeAuthor = "Narwin";
            this.btnPesquisar.ThemeName = "MetroLite";
            // 
            // btnFechar
            // 
            this.btnFechar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnFechar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnFechar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.HoverTextColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(480, 239);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.NormalTextColor = System.Drawing.Color.White;
            this.btnFechar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnFechar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnFechar.PressTextColor = System.Drawing.Color.White;
            this.btnFechar.Size = new System.Drawing.Size(79, 29);
            this.btnFechar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnFechar.StyleManager = null;
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.ThemeAuthor = "Narwin";
            this.btnFechar.ThemeName = "MetroLite";
            // 
            // frmConsultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtFiltrarCurso);
            this.Controls.Add(this.lblFiltrarCurso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTituloConsultar);
            this.Controls.Add(this.txtFiltrarNome);
            this.Controls.Add(this.lblFiltrarNome);
            this.Name = "frmConsultarAluno";
            this.Text = "Consultar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrarNome;
        private MetroSet_UI.Controls.MetroSetTextBox txtFiltrarNome;
        private System.Windows.Forms.Label lblTituloConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFiltrarCurso;
        private MetroSet_UI.Controls.MetroSetTextBox txtFiltrarCurso;
        private MetroSet_UI.Controls.MetroSetButton btnPesquisar;
        private MetroSet_UI.Controls.MetroSetButton btnFechar;
    }
}