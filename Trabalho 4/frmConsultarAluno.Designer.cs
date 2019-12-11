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
            this.codigo_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFiltrarCurso = new System.Windows.Forms.Label();
            this.btnPesquisar = new MetroSet_UI.Controls.MetroSetButton();
            this.btnFechar = new MetroSet_UI.Controls.MetroSetButton();
            this.editFiltrarSetor = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblFiltrarSetor = new System.Windows.Forms.Label();
            this.lblFiltrarSexo = new System.Windows.Forms.Label();
            this.cmbFiltrarCurso = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cmbFiltrarSexo = new MetroSet_UI.Controls.MetroSetComboBox();
            this.rbNome = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.rbCurso = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.rbSetor = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.rbSexo = new MetroSet_UI.Controls.MetroSetRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dadosAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrarNome
            // 
            this.lblFiltrarNome.AutoSize = true;
            this.lblFiltrarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarNome.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarNome.Location = new System.Drawing.Point(188, 86);
            this.lblFiltrarNome.Name = "lblFiltrarNome";
            this.lblFiltrarNome.Size = new System.Drawing.Size(124, 20);
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
            this.lblTituloConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultar.ForeColor = System.Drawing.Color.White;
            this.lblTituloConsultar.Location = new System.Drawing.Point(297, 9);
            this.lblTituloConsultar.Name = "lblTituloConsultar";
            this.lblTituloConsultar.Size = new System.Drawing.Size(182, 29);
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
            this.codigo_curso});
            this.dadosAluno.Location = new System.Drawing.Point(28, 397);
            this.dadosAluno.Name = "dadosAluno";
            this.dadosAluno.Size = new System.Drawing.Size(744, 201);
            this.dadosAluno.TabIndex = 3;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "matricula";
            this.Matricula.HeaderText = "Matricula do Aluno";
            this.Matricula.Name = "Matricula";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome do Aluno";
            this.Nome.Name = "Nome";
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "sexo";
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
            // codigo_curso
            // 
            this.codigo_curso.DataPropertyName = "codigo_curso";
            this.codigo_curso.HeaderText = "Codigo do Curso";
            this.codigo_curso.Name = "codigo_curso";
            // 
            // lblFiltrarCurso
            // 
            this.lblFiltrarCurso.AutoSize = true;
            this.lblFiltrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCurso.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarCurso.Location = new System.Drawing.Point(190, 143);
            this.lblFiltrarCurso.Name = "lblFiltrarCurso";
            this.lblFiltrarCurso.Size = new System.Drawing.Size(123, 20);
            this.lblFiltrarCurso.TabIndex = 4;
            this.lblFiltrarCurso.Text = "Filtrar por curso:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPesquisar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPesquisar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnPesquisar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnPesquisar.HoverTextColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(268, 322);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisar.NormalTextColor = System.Drawing.Color.White;
            this.btnPesquisar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnPesquisar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
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
            this.btnFechar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.HoverTextColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(458, 322);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.NormalTextColor = System.Drawing.Color.White;
            this.btnFechar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.PressTextColor = System.Drawing.Color.White;
            this.btnFechar.Size = new System.Drawing.Size(79, 29);
            this.btnFechar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnFechar.StyleManager = null;
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.ThemeAuthor = "Narwin";
            this.btnFechar.ThemeName = "MetroLite";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.lblFiltrarSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarSetor.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarSetor.Location = new System.Drawing.Point(190, 201);
            this.lblFiltrarSetor.Name = "lblFiltrarSetor";
            this.lblFiltrarSetor.Size = new System.Drawing.Size(120, 20);
            this.lblFiltrarSetor.TabIndex = 8;
            this.lblFiltrarSetor.Text = "Filtrar por setor:";
            // 
            // lblFiltrarSexo
            // 
            this.lblFiltrarSexo.AutoSize = true;
            this.lblFiltrarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarSexo.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarSexo.Location = new System.Drawing.Point(188, 254);
            this.lblFiltrarSexo.Name = "lblFiltrarSexo";
            this.lblFiltrarSexo.Size = new System.Drawing.Size(117, 20);
            this.lblFiltrarSexo.TabIndex = 10;
            this.lblFiltrarSexo.Text = "Filtrar por sexo:";
            // 
            // cmbFiltrarCurso
            // 
            this.cmbFiltrarCurso.AllowDrop = true;
            this.cmbFiltrarCurso.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbFiltrarCurso.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltrarCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbFiltrarCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbFiltrarCurso.CausesValidation = false;
            this.cmbFiltrarCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbFiltrarCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFiltrarCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFiltrarCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltrarCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbFiltrarCurso.FormattingEnabled = true;
            this.cmbFiltrarCurso.ItemHeight = 20;
            this.cmbFiltrarCurso.Location = new System.Drawing.Point(333, 141);
            this.cmbFiltrarCurso.Name = "cmbFiltrarCurso";
            this.cmbFiltrarCurso.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbFiltrarCurso.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbFiltrarCurso.Size = new System.Drawing.Size(302, 26);
            this.cmbFiltrarCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbFiltrarCurso.StyleManager = null;
            this.cmbFiltrarCurso.TabIndex = 43;
            this.cmbFiltrarCurso.ThemeAuthor = "Narwin";
            this.cmbFiltrarCurso.ThemeName = "MetroDark";
            // 
            // cmbFiltrarSexo
            // 
            this.cmbFiltrarSexo.AllowDrop = true;
            this.cmbFiltrarSexo.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbFiltrarSexo.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltrarSexo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbFiltrarSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbFiltrarSexo.CausesValidation = false;
            this.cmbFiltrarSexo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbFiltrarSexo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFiltrarSexo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFiltrarSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltrarSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbFiltrarSexo.FormattingEnabled = true;
            this.cmbFiltrarSexo.ItemHeight = 20;
            this.cmbFiltrarSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbFiltrarSexo.Location = new System.Drawing.Point(333, 252);
            this.cmbFiltrarSexo.Name = "cmbFiltrarSexo";
            this.cmbFiltrarSexo.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbFiltrarSexo.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbFiltrarSexo.Size = new System.Drawing.Size(302, 26);
            this.cmbFiltrarSexo.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbFiltrarSexo.StyleManager = null;
            this.cmbFiltrarSexo.TabIndex = 44;
            this.cmbFiltrarSexo.ThemeAuthor = "Narwin";
            this.cmbFiltrarSexo.ThemeName = "MetroDark";
            // 
            // rbNome
            // 
            this.rbNome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rbNome.Checked = false;
            this.rbNome.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rbNome.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rbNome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.rbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbNome.Group = 1;
            this.rbNome.Location = new System.Drawing.Point(641, 89);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(119, 17);
            this.rbNome.Style = MetroSet_UI.Design.Style.Dark;
            this.rbNome.StyleManager = null;
            this.rbNome.TabIndex = 45;
            this.rbNome.Text = "Selecionado";
            this.rbNome.ThemeAuthor = "Narwin";
            this.rbNome.ThemeName = "MetroDark";
            // 
            // rbCurso
            // 
            this.rbCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rbCurso.Checked = false;
            this.rbCurso.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rbCurso.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rbCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.rbCurso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbCurso.Group = 1;
            this.rbCurso.Location = new System.Drawing.Point(641, 146);
            this.rbCurso.Name = "rbCurso";
            this.rbCurso.Size = new System.Drawing.Size(119, 17);
            this.rbCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.rbCurso.StyleManager = null;
            this.rbCurso.TabIndex = 46;
            this.rbCurso.Text = "Selecionado";
            this.rbCurso.ThemeAuthor = "Narwin";
            this.rbCurso.ThemeName = "MetroDark";
            // 
            // rbSetor
            // 
            this.rbSetor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbSetor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rbSetor.Checked = false;
            this.rbSetor.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rbSetor.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rbSetor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.rbSetor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbSetor.Group = 1;
            this.rbSetor.Location = new System.Drawing.Point(641, 204);
            this.rbSetor.Name = "rbSetor";
            this.rbSetor.Size = new System.Drawing.Size(119, 17);
            this.rbSetor.Style = MetroSet_UI.Design.Style.Dark;
            this.rbSetor.StyleManager = null;
            this.rbSetor.TabIndex = 47;
            this.rbSetor.Text = "Selecionado";
            this.rbSetor.ThemeAuthor = "Narwin";
            this.rbSetor.ThemeName = "MetroDark";
            // 
            // rbSexo
            // 
            this.rbSexo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rbSexo.Checked = false;
            this.rbSexo.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rbSexo.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rbSexo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.rbSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbSexo.Group = 1;
            this.rbSexo.Location = new System.Drawing.Point(641, 257);
            this.rbSexo.Name = "rbSexo";
            this.rbSexo.Size = new System.Drawing.Size(119, 17);
            this.rbSexo.Style = MetroSet_UI.Design.Style.Dark;
            this.rbSexo.StyleManager = null;
            this.rbSexo.TabIndex = 48;
            this.rbSexo.Text = "Selecionado";
            this.rbSexo.ThemeAuthor = "Narwin";
            this.rbSexo.ThemeName = "MetroDark";
            // 
            // frmConsultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(816, 621);
            this.Controls.Add(this.rbSexo);
            this.Controls.Add(this.rbSetor);
            this.Controls.Add(this.rbCurso);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.cmbFiltrarSexo);
            this.Controls.Add(this.cmbFiltrarCurso);
            this.Controls.Add(this.lblFiltrarSexo);
            this.Controls.Add(this.editFiltrarSetor);
            this.Controls.Add(this.lblFiltrarSetor);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblFiltrarCurso);
            this.Controls.Add(this.dadosAluno);
            this.Controls.Add(this.lblTituloConsultar);
            this.Controls.Add(this.editFiltrarNome);
            this.Controls.Add(this.lblFiltrarNome);
            this.Name = "frmConsultarAluno";
            this.Text = "Consultar Aluno";
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
        private MetroSet_UI.Controls.MetroSetButton btnPesquisar;
        private MetroSet_UI.Controls.MetroSetButton btnFechar;
        private MetroSet_UI.Controls.MetroSetTextBox editFiltrarSetor;
        private System.Windows.Forms.Label lblFiltrarSetor;
        private System.Windows.Forms.Label lblFiltrarSexo;
        private MetroSet_UI.Controls.MetroSetComboBox cmbFiltrarCurso;
        private MetroSet_UI.Controls.MetroSetComboBox cmbFiltrarSexo;
        private MetroSet_UI.Controls.MetroSetRadioButton rbNome;
        private MetroSet_UI.Controls.MetroSetRadioButton rbCurso;
        private MetroSet_UI.Controls.MetroSetRadioButton rbSetor;
        private MetroSet_UI.Controls.MetroSetRadioButton rbSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_curso;
    }
}