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
            this.editFiltrarNome = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTituloConsultar = new System.Windows.Forms.Label();
            this.dadosAluno = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFiltrarCurso = new System.Windows.Forms.Label();
            this.editFiltrarCurso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnPesquisar = new MetroSet_UI.Controls.MetroSetButton();
            this.btnFechar = new MetroSet_UI.Controls.MetroSetButton();
            this.editFiltrarSetor = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblFiltrarSetor = new System.Windows.Forms.Label();
            this.editFiltrarSexo = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblFiltrarSexo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dadosAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrarNome
            // 
            this.lblFiltrarNome.AutoSize = true;
            this.lblFiltrarNome.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarNome.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarNome.Location = new System.Drawing.Point(188, 86);
            this.lblFiltrarNome.Name = "lblFiltrarNome";
            this.lblFiltrarNome.Size = new System.Drawing.Size(139, 24);
            this.lblFiltrarNome.TabIndex = 0;
            this.lblFiltrarNome.Text = "Filtrar por nome:";
            // 
            // editFiltrarNome
            // 
            this.editFiltrarNome.AutoCompleteCustomSource = null;
            this.editFiltrarNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editFiltrarNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editFiltrarNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editFiltrarNome.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editFiltrarNome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarNome.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editFiltrarNome.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editFiltrarNome.Image = null;
            this.editFiltrarNome.Lines = null;
            this.editFiltrarNome.Location = new System.Drawing.Point(333, 79);
            this.editFiltrarNome.MaxLength = 32767;
            this.editFiltrarNome.Multiline = false;
            this.editFiltrarNome.Name = "editFiltrarNome";
            this.editFiltrarNome.ReadOnly = false;
            this.editFiltrarNome.Size = new System.Drawing.Size(302, 31);
            this.editFiltrarNome.Style = MetroSet_UI.Design.Style.Dark;
            this.editFiltrarNome.StyleManager = null;
            this.editFiltrarNome.TabIndex = 1;
            this.editFiltrarNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editFiltrarNome.ThemeAuthor = "Narwin";
            this.editFiltrarNome.ThemeName = "MetroDark";
            this.editFiltrarNome.UseSystemPasswordChar = false;
            this.editFiltrarNome.WatermarkText = "";
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
            // dadosAluno
            // 
            this.dadosAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nome,
            this.Sexo,
            this.Setor,
            this.Cidade,
            this.UF,
            this.nome_curso});
            this.dadosAluno.Location = new System.Drawing.Point(28, 397);
            this.dadosAluno.Name = "dadosAluno";
            this.dadosAluno.Size = new System.Drawing.Size(744, 201);
            this.dadosAluno.TabIndex = 3;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "matriculaAluno";
            this.Matricula.HeaderText = "Matricula do Aluno";
            this.Matricula.Name = "Matricula";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nomeAluno";
            this.Nome.HeaderText = "Nome do Aluno";
            this.Nome.Name = "Nome";
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "sexoAluno";
            this.Sexo.HeaderText = "Sexo do Aluno";
            this.Sexo.Name = "Sexo";
            // 
            // Setor
            // 
            this.Setor.DataPropertyName = "setor";
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // UF
            // 
            this.UF.DataPropertyName = "uf";
            this.UF.HeaderText = "Estado";
            this.UF.Name = "UF";
            // 
            // nome_curso
            // 
            this.nome_curso.DataPropertyName = "nomeCurso";
            this.nome_curso.HeaderText = "Nome do Curso";
            this.nome_curso.Name = "nome_curso";
            // 
            // lblFiltrarCurso
            // 
            this.lblFiltrarCurso.AutoSize = true;
            this.lblFiltrarCurso.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCurso.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarCurso.Location = new System.Drawing.Point(190, 143);
            this.lblFiltrarCurso.Name = "lblFiltrarCurso";
            this.lblFiltrarCurso.Size = new System.Drawing.Size(137, 24);
            this.lblFiltrarCurso.TabIndex = 4;
            this.lblFiltrarCurso.Text = "Filtrar por curso:";
            // 
            // editFiltrarCurso
            // 
            this.editFiltrarCurso.AutoCompleteCustomSource = null;
            this.editFiltrarCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editFiltrarCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editFiltrarCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editFiltrarCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editFiltrarCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editFiltrarCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editFiltrarCurso.Image = null;
            this.editFiltrarCurso.Lines = null;
            this.editFiltrarCurso.Location = new System.Drawing.Point(333, 136);
            this.editFiltrarCurso.MaxLength = 32767;
            this.editFiltrarCurso.Multiline = false;
            this.editFiltrarCurso.Name = "editFiltrarCurso";
            this.editFiltrarCurso.ReadOnly = false;
            this.editFiltrarCurso.Size = new System.Drawing.Size(302, 31);
            this.editFiltrarCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.editFiltrarCurso.StyleManager = null;
            this.editFiltrarCurso.TabIndex = 5;
            this.editFiltrarCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editFiltrarCurso.ThemeAuthor = "Narwin";
            this.editFiltrarCurso.ThemeName = "MetroDark";
            this.editFiltrarCurso.UseSystemPasswordChar = false;
            this.editFiltrarCurso.WatermarkText = "";
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
            this.btnPesquisar.Location = new System.Drawing.Point(268, 322);
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
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(458, 322);
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
            // editFiltrarSetor
            // 
            this.editFiltrarSetor.AutoCompleteCustomSource = null;
            this.editFiltrarSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editFiltrarSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editFiltrarSetor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editFiltrarSetor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editFiltrarSetor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarSetor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editFiltrarSetor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editFiltrarSetor.Image = null;
            this.editFiltrarSetor.Lines = null;
            this.editFiltrarSetor.Location = new System.Drawing.Point(333, 194);
            this.editFiltrarSetor.MaxLength = 32767;
            this.editFiltrarSetor.Multiline = false;
            this.editFiltrarSetor.Name = "editFiltrarSetor";
            this.editFiltrarSetor.ReadOnly = false;
            this.editFiltrarSetor.Size = new System.Drawing.Size(302, 31);
            this.editFiltrarSetor.Style = MetroSet_UI.Design.Style.Dark;
            this.editFiltrarSetor.StyleManager = null;
            this.editFiltrarSetor.TabIndex = 9;
            this.editFiltrarSetor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editFiltrarSetor.ThemeAuthor = "Narwin";
            this.editFiltrarSetor.ThemeName = "MetroDark";
            this.editFiltrarSetor.UseSystemPasswordChar = false;
            this.editFiltrarSetor.WatermarkText = "";
            // 
            // lblFiltrarSetor
            // 
            this.lblFiltrarSetor.AutoSize = true;
            this.lblFiltrarSetor.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarSetor.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarSetor.Location = new System.Drawing.Point(190, 201);
            this.lblFiltrarSetor.Name = "lblFiltrarSetor";
            this.lblFiltrarSetor.Size = new System.Drawing.Size(134, 24);
            this.lblFiltrarSetor.TabIndex = 8;
            this.lblFiltrarSetor.Text = "Filtrar por setor:";
            // 
            // editFiltrarSexo
            // 
            this.editFiltrarSexo.AutoCompleteCustomSource = null;
            this.editFiltrarSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editFiltrarSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editFiltrarSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editFiltrarSexo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editFiltrarSexo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarSexo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editFiltrarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editFiltrarSexo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editFiltrarSexo.Image = null;
            this.editFiltrarSexo.Lines = null;
            this.editFiltrarSexo.Location = new System.Drawing.Point(333, 247);
            this.editFiltrarSexo.MaxLength = 32767;
            this.editFiltrarSexo.Multiline = false;
            this.editFiltrarSexo.Name = "editFiltrarSexo";
            this.editFiltrarSexo.ReadOnly = false;
            this.editFiltrarSexo.Size = new System.Drawing.Size(302, 31);
            this.editFiltrarSexo.Style = MetroSet_UI.Design.Style.Dark;
            this.editFiltrarSexo.StyleManager = null;
            this.editFiltrarSexo.TabIndex = 11;
            this.editFiltrarSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editFiltrarSexo.ThemeAuthor = "Narwin";
            this.editFiltrarSexo.ThemeName = "MetroDark";
            this.editFiltrarSexo.UseSystemPasswordChar = false;
            this.editFiltrarSexo.WatermarkText = "";
            // 
            // lblFiltrarSexo
            // 
            this.lblFiltrarSexo.AutoSize = true;
            this.lblFiltrarSexo.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarSexo.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarSexo.Location = new System.Drawing.Point(188, 254);
            this.lblFiltrarSexo.Name = "lblFiltrarSexo";
            this.lblFiltrarSexo.Size = new System.Drawing.Size(130, 24);
            this.lblFiltrarSexo.TabIndex = 10;
            this.lblFiltrarSexo.Text = "Filtrar por sexo:";
            // 
            // frmConsultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(816, 621);
            this.Controls.Add(this.editFiltrarSexo);
            this.Controls.Add(this.lblFiltrarSexo);
            this.Controls.Add(this.editFiltrarSetor);
            this.Controls.Add(this.lblFiltrarSetor);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.editFiltrarCurso);
            this.Controls.Add(this.lblFiltrarCurso);
            this.Controls.Add(this.dadosAluno);
            this.Controls.Add(this.lblTituloConsultar);
            this.Controls.Add(this.editFiltrarNome);
            this.Controls.Add(this.lblFiltrarNome);
            this.Name = "frmConsultarAluno";
            this.Text = "Consultar Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dadosAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrarNome;
        private MetroSet_UI.Controls.MetroSetTextBox editFiltrarNome;
        private System.Windows.Forms.Label lblTituloConsultar;
        private System.Windows.Forms.DataGridView dadosAluno;
        private System.Windows.Forms.Label lblFiltrarCurso;
        private MetroSet_UI.Controls.MetroSetTextBox editFiltrarCurso;
        private MetroSet_UI.Controls.MetroSetButton btnPesquisar;
        private MetroSet_UI.Controls.MetroSetButton btnFechar;
        private MetroSet_UI.Controls.MetroSetTextBox editFiltrarSetor;
        private System.Windows.Forms.Label lblFiltrarSetor;
        private MetroSet_UI.Controls.MetroSetTextBox editFiltrarSexo;
        private System.Windows.Forms.Label lblFiltrarSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_curso;
    }
}