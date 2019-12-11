namespace Trabalho_4 {
    partial class frmAlterarAluno {
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCurso = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cmbEstado = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cmbSexo = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblCurso = new MetroSet_UI.Controls.MetroSetLabel();
            this.editCidade = new MetroSet_UI.Controls.MetroSetTextBox();
            this.editSetor = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblEstado = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblCidade = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblSetor = new MetroSet_UI.Controls.MetroSetLabel();
            this.editNumero = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblNumero = new MetroSet_UI.Controls.MetroSetLabel();
            this.editLogradouro = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLogradouro = new MetroSet_UI.Controls.MetroSetLabel();
            this.editNome = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblSexo = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblNome = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnFechar = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAtualizar = new MetroSet_UI.Controls.MetroSetButton();
            this.dadosAluno = new System.Windows.Forms.DataGridView();
            this.matriculaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editMatricula = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblMatricula = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dadosAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alterar Aluno";
            // 
            // cmbCurso
            // 
            this.cmbCurso.AllowDrop = true;
            this.cmbCurso.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbCurso.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbCurso.CausesValidation = false;
            this.cmbCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.ItemHeight = 20;
            this.cmbCurso.Location = new System.Drawing.Point(81, 337);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbCurso.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbCurso.Size = new System.Drawing.Size(212, 26);
            this.cmbCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbCurso.StyleManager = null;
            this.cmbCurso.TabIndex = 62;
            this.cmbCurso.ThemeAuthor = "Narwin";
            this.cmbCurso.ThemeName = "MetroDark";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AllowDrop = true;
            this.cmbEstado.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbEstado.CausesValidation = false;
            this.cmbEstado.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbEstado.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbEstado.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 20;
            this.cmbEstado.Items.AddRange(new object[] {
            "GO",
            "DF",
            "RJ",
            "SP",
            "BH",
            "AC"});
            this.cmbEstado.Location = new System.Drawing.Point(435, 256);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbEstado.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbEstado.Size = new System.Drawing.Size(121, 26);
            this.cmbEstado.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbEstado.StyleManager = null;
            this.cmbEstado.TabIndex = 61;
            this.cmbEstado.ThemeAuthor = "Narwin";
            this.cmbEstado.ThemeName = "MetroDark";
            // 
            // cmbSexo
            // 
            this.cmbSexo.AllowDrop = true;
            this.cmbSexo.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbSexo.BackColor = System.Drawing.Color.Transparent;
            this.cmbSexo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbSexo.CausesValidation = false;
            this.cmbSexo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbSexo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbSexo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.ItemHeight = 20;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(762, 84);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbSexo.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbSexo.Size = new System.Drawing.Size(144, 26);
            this.cmbSexo.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbSexo.StyleManager = null;
            this.cmbSexo.TabIndex = 60;
            this.cmbSexo.ThemeAuthor = "Narwin";
            this.cmbSexo.ThemeName = "MetroDark";
            // 
            // lblCurso
            // 
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(81, 311);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(117, 23);
            this.lblCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.lblCurso.StyleManager = null;
            this.lblCurso.TabIndex = 59;
            this.lblCurso.Text = "Curso";
            this.lblCurso.ThemeAuthor = "Narwin";
            this.lblCurso.ThemeName = "MetroDark";
            // 
            // editCidade
            // 
            this.editCidade.AutoCompleteCustomSource = null;
            this.editCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editCidade.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editCidade.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editCidade.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editCidade.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editCidade.Image = null;
            this.editCidade.Lines = null;
            this.editCidade.Location = new System.Drawing.Point(81, 256);
            this.editCidade.MaxLength = 32767;
            this.editCidade.Multiline = false;
            this.editCidade.Name = "editCidade";
            this.editCidade.ReadOnly = false;
            this.editCidade.Size = new System.Drawing.Size(231, 25);
            this.editCidade.Style = MetroSet_UI.Design.Style.Dark;
            this.editCidade.StyleManager = null;
            this.editCidade.TabIndex = 58;
            this.editCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editCidade.ThemeAuthor = "Narwin";
            this.editCidade.ThemeName = "MetroDark";
            this.editCidade.UseSystemPasswordChar = false;
            this.editCidade.WatermarkText = "";
            // 
            // editSetor
            // 
            this.editSetor.AutoCompleteCustomSource = null;
            this.editSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editSetor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editSetor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editSetor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editSetor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editSetor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editSetor.Image = null;
            this.editSetor.Lines = null;
            this.editSetor.Location = new System.Drawing.Point(435, 173);
            this.editSetor.MaxLength = 32767;
            this.editSetor.Multiline = false;
            this.editSetor.Name = "editSetor";
            this.editSetor.ReadOnly = false;
            this.editSetor.Size = new System.Drawing.Size(231, 25);
            this.editSetor.Style = MetroSet_UI.Design.Style.Dark;
            this.editSetor.StyleManager = null;
            this.editSetor.TabIndex = 57;
            this.editSetor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editSetor.ThemeAuthor = "Narwin";
            this.editSetor.ThemeName = "MetroDark";
            this.editSetor.UseSystemPasswordChar = false;
            this.editSetor.WatermarkText = "";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(435, 230);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 23);
            this.lblEstado.Style = MetroSet_UI.Design.Style.Dark;
            this.lblEstado.StyleManager = null;
            this.lblEstado.TabIndex = 56;
            this.lblEstado.Text = "Estado";
            this.lblEstado.ThemeAuthor = "Narwin";
            this.lblEstado.ThemeName = "MetroDark";
            // 
            // lblCidade
            // 
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCidade.Location = new System.Drawing.Point(81, 230);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(83, 23);
            this.lblCidade.Style = MetroSet_UI.Design.Style.Dark;
            this.lblCidade.StyleManager = null;
            this.lblCidade.TabIndex = 55;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.ThemeAuthor = "Narwin";
            this.lblCidade.ThemeName = "MetroDark";
            // 
            // lblSetor
            // 
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(435, 147);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(58, 23);
            this.lblSetor.Style = MetroSet_UI.Design.Style.Dark;
            this.lblSetor.StyleManager = null;
            this.lblSetor.TabIndex = 54;
            this.lblSetor.Text = "Setor";
            this.lblSetor.ThemeAuthor = "Narwin";
            this.lblSetor.ThemeName = "MetroDark";
            // 
            // editNumero
            // 
            this.editNumero.AutoCompleteCustomSource = null;
            this.editNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editNumero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editNumero.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editNumero.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editNumero.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editNumero.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editNumero.Image = null;
            this.editNumero.Lines = null;
            this.editNumero.Location = new System.Drawing.Point(762, 173);
            this.editNumero.MaxLength = 32767;
            this.editNumero.Multiline = false;
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Size = new System.Drawing.Size(144, 25);
            this.editNumero.Style = MetroSet_UI.Design.Style.Dark;
            this.editNumero.StyleManager = null;
            this.editNumero.TabIndex = 53;
            this.editNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editNumero.ThemeAuthor = "Narwin";
            this.editNumero.ThemeName = "MetroDark";
            this.editNumero.UseSystemPasswordChar = false;
            this.editNumero.WatermarkText = "";
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(762, 147);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(82, 23);
            this.lblNumero.Style = MetroSet_UI.Design.Style.Dark;
            this.lblNumero.StyleManager = null;
            this.lblNumero.TabIndex = 52;
            this.lblNumero.Text = "Número";
            this.lblNumero.ThemeAuthor = "Narwin";
            this.lblNumero.ThemeName = "MetroDark";
            // 
            // editLogradouro
            // 
            this.editLogradouro.AutoCompleteCustomSource = null;
            this.editLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editLogradouro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editLogradouro.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editLogradouro.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editLogradouro.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editLogradouro.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editLogradouro.Image = null;
            this.editLogradouro.Lines = null;
            this.editLogradouro.Location = new System.Drawing.Point(81, 173);
            this.editLogradouro.MaxLength = 32767;
            this.editLogradouro.Multiline = false;
            this.editLogradouro.Name = "editLogradouro";
            this.editLogradouro.ReadOnly = false;
            this.editLogradouro.Size = new System.Drawing.Size(231, 25);
            this.editLogradouro.Style = MetroSet_UI.Design.Style.Dark;
            this.editLogradouro.StyleManager = null;
            this.editLogradouro.TabIndex = 51;
            this.editLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editLogradouro.ThemeAuthor = "Narwin";
            this.editLogradouro.ThemeName = "MetroDark";
            this.editLogradouro.UseSystemPasswordChar = false;
            this.editLogradouro.WatermarkText = "";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(81, 147);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(105, 23);
            this.lblLogradouro.Style = MetroSet_UI.Design.Style.Dark;
            this.lblLogradouro.StyleManager = null;
            this.lblLogradouro.TabIndex = 50;
            this.lblLogradouro.Text = "Logradouro";
            this.lblLogradouro.ThemeAuthor = "Narwin";
            this.lblLogradouro.ThemeName = "MetroDark";
            // 
            // editNome
            // 
            this.editNome.AutoCompleteCustomSource = null;
            this.editNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editNome.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editNome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editNome.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editNome.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editNome.Image = null;
            this.editNome.Lines = null;
            this.editNome.Location = new System.Drawing.Point(435, 85);
            this.editNome.MaxLength = 32767;
            this.editNome.Multiline = false;
            this.editNome.Name = "editNome";
            this.editNome.ReadOnly = false;
            this.editNome.Size = new System.Drawing.Size(231, 25);
            this.editNome.Style = MetroSet_UI.Design.Style.Dark;
            this.editNome.StyleManager = null;
            this.editNome.TabIndex = 49;
            this.editNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editNome.ThemeAuthor = "Narwin";
            this.editNome.ThemeName = "MetroDark";
            this.editNome.UseSystemPasswordChar = false;
            this.editNome.WatermarkText = "";
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(762, 59);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(58, 23);
            this.lblSexo.Style = MetroSet_UI.Design.Style.Dark;
            this.lblSexo.StyleManager = null;
            this.lblSexo.TabIndex = 48;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.ThemeAuthor = "Narwin";
            this.lblSexo.ThemeName = "MetroDark";
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(435, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 23);
            this.lblNome.Style = MetroSet_UI.Design.Style.Dark;
            this.lblNome.StyleManager = null;
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "Nome";
            this.lblNome.ThemeAuthor = "Narwin";
            this.lblNome.ThemeName = "MetroDark";
            // 
            // btnFechar
            // 
            this.btnFechar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.HoverTextColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(619, 405);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnFechar.NormalTextColor = System.Drawing.Color.White;
            this.btnFechar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnFechar.PressTextColor = System.Drawing.Color.White;
            this.btnFechar.Size = new System.Drawing.Size(83, 36);
            this.btnFechar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnFechar.StyleManager = null;
            this.btnFechar.TabIndex = 45;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.ThemeAuthor = "Narwin";
            this.btnFechar.ThemeName = "MetroLite";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAtualizar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAtualizar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAtualizar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAtualizar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAtualizar.HoverTextColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(371, 405);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAtualizar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAtualizar.NormalTextColor = System.Drawing.Color.White;
            this.btnAtualizar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAtualizar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAtualizar.PressTextColor = System.Drawing.Color.White;
            this.btnAtualizar.Size = new System.Drawing.Size(83, 36);
            this.btnAtualizar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnAtualizar.StyleManager = null;
            this.btnAtualizar.TabIndex = 43;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.ThemeAuthor = "Narwin";
            this.btnAtualizar.ThemeName = "MetroLite";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dadosAluno
            // 
            this.dadosAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaAluno,
            this.nomeAluno,
            this.sexo,
            this.logradouro,
            this.numero,
            this.setor,
            this.cidade,
            this.estado,
            this.nomeCurso});
            this.dadosAluno.Location = new System.Drawing.Point(30, 467);
            this.dadosAluno.Name = "dadosAluno";
            this.dadosAluno.Size = new System.Drawing.Size(942, 217);
            this.dadosAluno.TabIndex = 63;
            this.dadosAluno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dadosAluno_MouseDoubleClick);
            // 
            // matriculaAluno
            // 
            this.matriculaAluno.DataPropertyName = "matricula";
            this.matriculaAluno.HeaderText = "Matricula";
            this.matriculaAluno.Name = "matriculaAluno";
            // 
            // nomeAluno
            // 
            this.nomeAluno.DataPropertyName = "nome";
            this.nomeAluno.HeaderText = "Nome";
            this.nomeAluno.Name = "nomeAluno";
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "logradouro";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            // 
            // setor
            // 
            this.setor.DataPropertyName = "setor";
            this.setor.HeaderText = "Setor";
            this.setor.Name = "setor";
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "uf";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // nomeCurso
            // 
            this.nomeCurso.DataPropertyName = "codigo_curso";
            this.nomeCurso.HeaderText = "Curso";
            this.nomeCurso.Name = "nomeCurso";
            // 
            // editMatricula
            // 
            this.editMatricula.AutoCompleteCustomSource = null;
            this.editMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editMatricula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editMatricula.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editMatricula.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editMatricula.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editMatricula.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editMatricula.Image = null;
            this.editMatricula.Lines = null;
            this.editMatricula.Location = new System.Drawing.Point(81, 85);
            this.editMatricula.MaxLength = 32767;
            this.editMatricula.Multiline = false;
            this.editMatricula.Name = "editMatricula";
            this.editMatricula.ReadOnly = false;
            this.editMatricula.Size = new System.Drawing.Size(231, 25);
            this.editMatricula.Style = MetroSet_UI.Design.Style.Dark;
            this.editMatricula.StyleManager = null;
            this.editMatricula.TabIndex = 65;
            this.editMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editMatricula.ThemeAuthor = "Narwin";
            this.editMatricula.ThemeName = "MetroDark";
            this.editMatricula.UseSystemPasswordChar = false;
            this.editMatricula.WatermarkText = "";
            // 
            // lblMatricula
            // 
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(81, 59);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(82, 23);
            this.lblMatricula.Style = MetroSet_UI.Design.Style.Dark;
            this.lblMatricula.StyleManager = null;
            this.lblMatricula.TabIndex = 64;
            this.lblMatricula.Text = "Matricula";
            this.lblMatricula.ThemeAuthor = "Narwin";
            this.lblMatricula.ThemeName = "MetroDark";
            // 
            // frmAlterarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.editMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.dadosAluno);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.editCidade);
            this.Controls.Add(this.editSetor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.editNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.editLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.editNome);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterarAluno";
            this.Text = "Alterar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dadosAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetComboBox cmbCurso;
        private MetroSet_UI.Controls.MetroSetComboBox cmbEstado;
        private MetroSet_UI.Controls.MetroSetComboBox cmbSexo;
        private MetroSet_UI.Controls.MetroSetLabel lblCurso;
        private MetroSet_UI.Controls.MetroSetTextBox editCidade;
        private MetroSet_UI.Controls.MetroSetTextBox editSetor;
        private MetroSet_UI.Controls.MetroSetLabel lblEstado;
        private MetroSet_UI.Controls.MetroSetLabel lblCidade;
        private MetroSet_UI.Controls.MetroSetLabel lblSetor;
        private MetroSet_UI.Controls.MetroSetTextBox editNumero;
        private MetroSet_UI.Controls.MetroSetLabel lblNumero;
        private MetroSet_UI.Controls.MetroSetTextBox editLogradouro;
        private MetroSet_UI.Controls.MetroSetLabel lblLogradouro;
        private MetroSet_UI.Controls.MetroSetTextBox editNome;
        private MetroSet_UI.Controls.MetroSetLabel lblSexo;
        private MetroSet_UI.Controls.MetroSetLabel lblNome;
        private MetroSet_UI.Controls.MetroSetButton btnFechar;
        private MetroSet_UI.Controls.MetroSetButton btnAtualizar;
        private System.Windows.Forms.DataGridView dadosAluno;
        private MetroSet_UI.Controls.MetroSetTextBox editMatricula;
        private MetroSet_UI.Controls.MetroSetLabel lblMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCurso;
    }
}