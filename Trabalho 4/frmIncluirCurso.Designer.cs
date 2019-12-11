namespace Trabalho_4 {
    partial class frmIncluirCurso {
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
            this.lblTituloIncluirCurso = new System.Windows.Forms.Label();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtNomeCurso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoCurso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnSalvarCurso = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCancelar = new MetroSet_UI.Controls.MetroSetButton();
            this.btnLimpar = new MetroSet_UI.Controls.MetroSetButton();
            this.cmbArea = new MetroSet_UI.Controls.MetroSetComboBox();
            this.SuspendLayout();
            // 
            // lblTituloIncluirCurso
            // 
            this.lblTituloIncluirCurso.AutoSize = true;
            this.lblTituloIncluirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIncluirCurso.ForeColor = System.Drawing.Color.White;
            this.lblTituloIncluirCurso.Location = new System.Drawing.Point(332, 9);
            this.lblTituloIncluirCurso.Name = "lblTituloIncluirCurso";
            this.lblTituloIncluirCurso.Size = new System.Drawing.Size(147, 29);
            this.lblTituloIncluirCurso.TabIndex = 0;
            this.lblTituloIncluirCurso.Text = "Incluir Curso";
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCurso.ForeColor = System.Drawing.Color.White;
            this.lblNomeCurso.Location = new System.Drawing.Point(242, 87);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(120, 20);
            this.lblNomeCurso.TabIndex = 1;
            this.lblNomeCurso.Text = "Nome do curso:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(242, 151);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(112, 20);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area do curso:";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.AutoCompleteCustomSource = null;
            this.txtNomeCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtNomeCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtNomeCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtNomeCurso.Image = null;
            this.txtNomeCurso.Lines = null;
            this.txtNomeCurso.Location = new System.Drawing.Point(380, 87);
            this.txtNomeCurso.MaxLength = 32767;
            this.txtNomeCurso.Multiline = false;
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.ReadOnly = false;
            this.txtNomeCurso.Size = new System.Drawing.Size(135, 28);
            this.txtNomeCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.txtNomeCurso.StyleManager = null;
            this.txtNomeCurso.TabIndex = 3;
            this.txtNomeCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomeCurso.ThemeAuthor = "Narwin";
            this.txtNomeCurso.ThemeName = "MetroDark";
            this.txtNomeCurso.UseSystemPasswordChar = false;
            this.txtNomeCurso.WatermarkText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preço do curso:";
            // 
            // txtPrecoCurso
            // 
            this.txtPrecoCurso.AutoCompleteCustomSource = null;
            this.txtPrecoCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrecoCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrecoCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtPrecoCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtPrecoCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecoCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrecoCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtPrecoCurso.Image = null;
            this.txtPrecoCurso.Lines = null;
            this.txtPrecoCurso.Location = new System.Drawing.Point(380, 214);
            this.txtPrecoCurso.MaxLength = 32767;
            this.txtPrecoCurso.Multiline = false;
            this.txtPrecoCurso.Name = "txtPrecoCurso";
            this.txtPrecoCurso.ReadOnly = false;
            this.txtPrecoCurso.Size = new System.Drawing.Size(135, 28);
            this.txtPrecoCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.txtPrecoCurso.StyleManager = null;
            this.txtPrecoCurso.TabIndex = 6;
            this.txtPrecoCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecoCurso.ThemeAuthor = "Narwin";
            this.txtPrecoCurso.ThemeName = "MetroDark";
            this.txtPrecoCurso.UseSystemPasswordChar = false;
            this.txtPrecoCurso.WatermarkText = "";
            // 
            // btnSalvarCurso
            // 
            this.btnSalvarCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSalvarCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSalvarCurso.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSalvarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvarCurso.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnSalvarCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnSalvarCurso.HoverTextColor = System.Drawing.Color.White;
            this.btnSalvarCurso.Location = new System.Drawing.Point(182, 301);
            this.btnSalvarCurso.Name = "btnSalvarCurso";
            this.btnSalvarCurso.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSalvarCurso.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSalvarCurso.NormalTextColor = System.Drawing.Color.White;
            this.btnSalvarCurso.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnSalvarCurso.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnSalvarCurso.PressTextColor = System.Drawing.Color.White;
            this.btnSalvarCurso.Size = new System.Drawing.Size(83, 31);
            this.btnSalvarCurso.Style = MetroSet_UI.Design.Style.Custom;
            this.btnSalvarCurso.StyleManager = null;
            this.btnSalvarCurso.TabIndex = 7;
            this.btnSalvarCurso.Text = "Salvar";
            this.btnSalvarCurso.ThemeAuthor = "Narwin";
            this.btnSalvarCurso.ThemeName = "MetroDark";
            this.btnSalvarCurso.Click += new System.EventHandler(this.btnSalvarCurso_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(605, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalTextColor = System.Drawing.Color.White;
            this.btnCancelar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnCancelar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnCancelar.PressTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(83, 31);
            this.btnCancelar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnCancelar.StyleManager = null;
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeAuthor = "Narwin";
            this.btnCancelar.ThemeName = "MetroDark";
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
            this.btnLimpar.Location = new System.Drawing.Point(392, 301);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnLimpar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnLimpar.NormalTextColor = System.Drawing.Color.White;
            this.btnLimpar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnLimpar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.btnLimpar.PressTextColor = System.Drawing.Color.White;
            this.btnLimpar.Size = new System.Drawing.Size(83, 31);
            this.btnLimpar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnLimpar.StyleManager = null;
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.ThemeAuthor = "Narwin";
            this.btnLimpar.ThemeName = "MetroDark";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.cmbArea.Location = new System.Drawing.Point(380, 149);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbArea.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbArea.Size = new System.Drawing.Size(135, 26);
            this.cmbArea.Style = MetroSet_UI.Design.Style.Dark;
            this.cmbArea.StyleManager = null;
            this.cmbArea.TabIndex = 10;
            this.cmbArea.ThemeAuthor = "Narwin";
            this.cmbArea.ThemeName = "MetroDark";
            // 
            // frmIncluirCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvarCurso);
            this.Controls.Add(this.txtPrecoCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.lblTituloIncluirCurso);
            this.Name = "frmIncluirCurso";
            this.Text = "frmIncluirCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloIncluirCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.Label lblArea;
        private MetroSet_UI.Controls.MetroSetTextBox txtNomeCurso;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetTextBox txtPrecoCurso;
        private MetroSet_UI.Controls.MetroSetButton btnSalvarCurso;
        private MetroSet_UI.Controls.MetroSetButton btnCancelar;
        private MetroSet_UI.Controls.MetroSetButton btnLimpar;
        private MetroSet_UI.Controls.MetroSetComboBox cmbArea;
    }
}