namespace Trabalho_4 {
    partial class frmConsultarCurso {
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
            this.btnFechar = new MetroSet_UI.Controls.MetroSetButton();
            this.btnPesquisarCurso = new MetroSet_UI.Controls.MetroSetButton();
            this.editFiltrarCurso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblFiltrarCurso = new System.Windows.Forms.Label();
            this.lblTituloConsultar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCurso = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFiltrarArea = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnLimpar = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurso)).BeginInit();
            this.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(532, 235);
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
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.ThemeAuthor = "Narwin";
            this.btnFechar.ThemeName = "MetroLite";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisarCurso
            // 
            this.btnPesquisarCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPesquisarCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPesquisarCurso.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPesquisarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisarCurso.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnPesquisarCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnPesquisarCurso.HoverTextColor = System.Drawing.Color.White;
            this.btnPesquisarCurso.Location = new System.Drawing.Point(261, 235);
            this.btnPesquisarCurso.Name = "btnPesquisarCurso";
            this.btnPesquisarCurso.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisarCurso.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPesquisarCurso.NormalTextColor = System.Drawing.Color.White;
            this.btnPesquisarCurso.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnPesquisarCurso.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnPesquisarCurso.PressTextColor = System.Drawing.Color.White;
            this.btnPesquisarCurso.Size = new System.Drawing.Size(79, 29);
            this.btnPesquisarCurso.Style = MetroSet_UI.Design.Style.Custom;
            this.btnPesquisarCurso.StyleManager = null;
            this.btnPesquisarCurso.TabIndex = 14;
            this.btnPesquisarCurso.Text = "Pesquisar";
            this.btnPesquisarCurso.ThemeAuthor = "Narwin";
            this.btnPesquisarCurso.ThemeName = "MetroLite";
            this.btnPesquisarCurso.Click += new System.EventHandler(this.btnPesquisarCurso_Click);
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
            this.editFiltrarCurso.Location = new System.Drawing.Point(329, 108);
            this.editFiltrarCurso.MaxLength = 32767;
            this.editFiltrarCurso.Multiline = false;
            this.editFiltrarCurso.Name = "editFiltrarCurso";
            this.editFiltrarCurso.ReadOnly = false;
            this.editFiltrarCurso.Size = new System.Drawing.Size(302, 31);
            this.editFiltrarCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.editFiltrarCurso.StyleManager = null;
            this.editFiltrarCurso.TabIndex = 13;
            this.editFiltrarCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editFiltrarCurso.ThemeAuthor = "Narwin";
            this.editFiltrarCurso.ThemeName = "MetroDark";
            this.editFiltrarCurso.UseSystemPasswordChar = false;
            this.editFiltrarCurso.WatermarkText = "";
            // 
            // lblFiltrarCurso
            // 
            this.lblFiltrarCurso.AutoSize = true;
            this.lblFiltrarCurso.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCurso.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarCurso.Location = new System.Drawing.Point(184, 108);
            this.lblFiltrarCurso.Name = "lblFiltrarCurso";
            this.lblFiltrarCurso.Size = new System.Drawing.Size(137, 24);
            this.lblFiltrarCurso.TabIndex = 12;
            this.lblFiltrarCurso.Text = "Filtrar por curso:";
            // 
            // lblTituloConsultar
            // 
            this.lblTituloConsultar.AutoSize = true;
            this.lblTituloConsultar.Font = new System.Drawing.Font("Muli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultar.ForeColor = System.Drawing.Color.White;
            this.lblTituloConsultar.Location = new System.Drawing.Point(294, 19);
            this.lblTituloConsultar.Name = "lblTituloConsultar";
            this.lblTituloConsultar.Size = new System.Drawing.Size(197, 35);
            this.lblTituloConsultar.TabIndex = 10;
            this.lblTituloConsultar.Text = "Consultar Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filtrar por area:";
            // 
            // gridCurso
            // 
            this.gridCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.area,
            this.precoTotal});
            this.gridCurso.Location = new System.Drawing.Point(188, 310);
            this.gridCurso.Name = "gridCurso";
            this.gridCurso.Size = new System.Drawing.Size(443, 228);
            this.gridCurso.TabIndex = 18;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código do Curso";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do Curso";
            this.nome.Name = "nome";
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Área do Curso";
            this.area.Name = "area";
            // 
            // precoTotal
            // 
            this.precoTotal.DataPropertyName = "preco_total";
            this.precoTotal.HeaderText = "Preço Total";
            this.precoTotal.Name = "precoTotal";
            // 
            // cmbFiltrarArea
            // 
            this.cmbFiltrarArea.AllowDrop = true;
            this.cmbFiltrarArea.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbFiltrarArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltrarArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbFiltrarArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbFiltrarArea.CausesValidation = false;
            this.cmbFiltrarArea.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbFiltrarArea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFiltrarArea.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFiltrarArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltrarArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbFiltrarArea.FormattingEnabled = true;
            this.cmbFiltrarArea.ItemHeight = 20;
            this.cmbFiltrarArea.Items.AddRange(new object[] {
            "Exatas",
            "Humanas",
            "Biologicas"});
            this.cmbFiltrarArea.Location = new System.Drawing.Point(329, 171);
            this.cmbFiltrarArea.Name = "cmbFiltrarArea";
            this.cmbFiltrarArea.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbFiltrarArea.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbFiltrarArea.Size = new System.Drawing.Size(302, 26);
            this.cmbFiltrarArea.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbFiltrarArea.StyleManager = null;
            this.cmbFiltrarArea.TabIndex = 19;
            this.cmbFiltrarArea.ThemeAuthor = "Narwin";
            this.cmbFiltrarArea.ThemeName = "MetroDark";
            // 
            // btnLimpar
            // 
            this.btnLimpar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLimpar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLimpar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnLimpar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnLimpar.HoverTextColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(396, 235);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnLimpar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnLimpar.NormalTextColor = System.Drawing.Color.White;
            this.btnLimpar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnLimpar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnLimpar.PressTextColor = System.Drawing.Color.White;
            this.btnLimpar.Size = new System.Drawing.Size(79, 29);
            this.btnLimpar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnLimpar.StyleManager = null;
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.ThemeAuthor = "Narwin";
            this.btnLimpar.ThemeName = "MetroLite";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmConsultarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbFiltrarArea);
            this.Controls.Add(this.gridCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisarCurso);
            this.Controls.Add(this.editFiltrarCurso);
            this.Controls.Add(this.lblFiltrarCurso);
            this.Controls.Add(this.lblTituloConsultar);
            this.Name = "frmConsultarCurso";
            this.Text = "frmConsultarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.gridCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnFechar;
        private MetroSet_UI.Controls.MetroSetButton btnPesquisarCurso;
        private MetroSet_UI.Controls.MetroSetTextBox editFiltrarCurso;
        private System.Windows.Forms.Label lblFiltrarCurso;
        private System.Windows.Forms.Label lblTituloConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private MetroSet_UI.Controls.MetroSetComboBox cmbFiltrarArea;
        private MetroSet_UI.Controls.MetroSetButton btnLimpar;
    }
}