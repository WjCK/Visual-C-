namespace Trabalho_4 {
    partial class frmAlterarCurso {
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
            this.btnCancelar = new MetroSet_UI.Controls.MetroSetButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new MetroSet_UI.Controls.MetroSetButton();
            this.gridCurso = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbArea = new MetroSet_UI.Controls.MetroSetComboBox();
            this.editPreco = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editNome = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.editCodigoCurso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancelar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnCancelar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnCancelar.HoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(453, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalTextColor = System.Drawing.Color.White;
            this.btnCancelar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnCancelar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnCancelar.PressTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(79, 29);
            this.btnCancelar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnCancelar.StyleManager = null;
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeAuthor = "Narwin";
            this.btnCancelar.ThemeName = "MetroLite";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Alterar Curso";
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlterar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlterar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAlterar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAlterar.HoverTextColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(312, 352);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAlterar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAlterar.NormalTextColor = System.Drawing.Color.White;
            this.btnAlterar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAlterar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnAlterar.PressTextColor = System.Drawing.Color.White;
            this.btnAlterar.Size = new System.Drawing.Size(79, 29);
            this.btnAlterar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnAlterar.StyleManager = null;
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.ThemeAuthor = "Narwin";
            this.btnAlterar.ThemeName = "MetroLite";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gridCurso
            // 
            this.gridCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.area,
            this.precoTotal});
            this.gridCurso.Location = new System.Drawing.Point(180, 425);
            this.gridCurso.Name = "gridCurso";
            this.gridCurso.Size = new System.Drawing.Size(446, 199);
            this.gridCurso.TabIndex = 6;
            this.gridCurso.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCurso_MouseDoubleClick_1);
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
            this.precoTotal.HeaderText = "Preco Total";
            this.precoTotal.Name = "precoTotal";
            // 
            // cmbArea
            // 
            this.cmbArea.AllowDrop = true;
            this.cmbArea.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbArea.CausesValidation = false;
            this.cmbArea.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbArea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbArea.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.ItemHeight = 20;
            this.cmbArea.Items.AddRange(new object[] {
            "Exatas",
            "Humanas",
            "Biologicas"});
            this.cmbArea.Location = new System.Drawing.Point(397, 202);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbArea.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbArea.Size = new System.Drawing.Size(135, 26);
            this.cmbArea.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbArea.StyleManager = null;
            this.cmbArea.TabIndex = 17;
            this.cmbArea.ThemeAuthor = "Narwin";
            this.cmbArea.ThemeName = "MetroDark";
            // 
            // editPreco
            // 
            this.editPreco.AutoCompleteCustomSource = null;
            this.editPreco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editPreco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editPreco.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editPreco.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editPreco.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editPreco.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editPreco.Image = null;
            this.editPreco.Lines = null;
            this.editPreco.Location = new System.Drawing.Point(397, 267);
            this.editPreco.MaxLength = 32767;
            this.editPreco.Multiline = false;
            this.editPreco.Name = "editPreco";
            this.editPreco.ReadOnly = false;
            this.editPreco.Size = new System.Drawing.Size(135, 28);
            this.editPreco.Style = MetroSet_UI.Design.Style.Dark;
            this.editPreco.StyleManager = null;
            this.editPreco.TabIndex = 16;
            this.editPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editPreco.ThemeAuthor = "Narwin";
            this.editPreco.ThemeName = "MetroDark";
            this.editPreco.UseSystemPasswordChar = false;
            this.editPreco.WatermarkText = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Preço do curso:";
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
            this.editNome.Location = new System.Drawing.Point(397, 140);
            this.editNome.MaxLength = 32767;
            this.editNome.Multiline = false;
            this.editNome.Name = "editNome";
            this.editNome.ReadOnly = false;
            this.editNome.Size = new System.Drawing.Size(135, 28);
            this.editNome.Style = MetroSet_UI.Design.Style.Dark;
            this.editNome.StyleManager = null;
            this.editNome.TabIndex = 14;
            this.editNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editNome.ThemeAuthor = "Narwin";
            this.editNome.ThemeName = "MetroDark";
            this.editNome.UseSystemPasswordChar = false;
            this.editNome.WatermarkText = "";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(259, 204);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(112, 20);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Area do curso:";
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCurso.ForeColor = System.Drawing.Color.White;
            this.lblNomeCurso.Location = new System.Drawing.Point(259, 140);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(120, 20);
            this.lblNomeCurso.TabIndex = 12;
            this.lblNomeCurso.Text = "Nome do curso:";
            // 
            // editCodigoCurso
            // 
            this.editCodigoCurso.AutoCompleteCustomSource = null;
            this.editCodigoCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.editCodigoCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.editCodigoCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.editCodigoCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editCodigoCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editCodigoCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editCodigoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editCodigoCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editCodigoCurso.Image = null;
            this.editCodigoCurso.Lines = null;
            this.editCodigoCurso.Location = new System.Drawing.Point(397, 84);
            this.editCodigoCurso.MaxLength = 32767;
            this.editCodigoCurso.Multiline = false;
            this.editCodigoCurso.Name = "editCodigoCurso";
            this.editCodigoCurso.ReadOnly = false;
            this.editCodigoCurso.Size = new System.Drawing.Size(135, 28);
            this.editCodigoCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.editCodigoCurso.StyleManager = null;
            this.editCodigoCurso.TabIndex = 19;
            this.editCodigoCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editCodigoCurso.ThemeAuthor = "Narwin";
            this.editCodigoCurso.ThemeName = "MetroDark";
            this.editCodigoCurso.UseSystemPasswordChar = false;
            this.editCodigoCurso.WatermarkText = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(259, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Código do curso:";
            // 
            // frmAlterarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.editCodigoCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.editPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editNome);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gridCurso);
            this.Name = "frmAlterarCurso";
            this.Text = "frmAlterarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.gridCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnCancelar;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetButton btnAlterar;
        private System.Windows.Forms.DataGridView gridCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private MetroSet_UI.Controls.MetroSetComboBox cmbArea;
        private MetroSet_UI.Controls.MetroSetTextBox editPreco;
        private System.Windows.Forms.Label label2;
        private MetroSet_UI.Controls.MetroSetTextBox editNome;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblNomeCurso;
        private MetroSet_UI.Controls.MetroSetTextBox editCodigoCurso;
        private System.Windows.Forms.Label label3;
    }
}