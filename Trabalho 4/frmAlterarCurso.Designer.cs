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
            this.btnAlterarAluno = new MetroSet_UI.Controls.MetroSetTextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancelar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.HoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(649, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalTextColor = System.Drawing.Color.White;
            this.btnCancelar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancelar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancelar.PressTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(79, 29);
            this.btnCancelar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnCancelar.StyleManager = null;
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeAuthor = "Narwin";
            this.btnCancelar.ThemeName = "MetroLite";
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
            this.btnAlterar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAlterar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAlterar.HoverTextColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(533, 96);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAlterar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAlterar.NormalTextColor = System.Drawing.Color.White;
            this.btnAlterar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlterar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlterar.PressTextColor = System.Drawing.Color.White;
            this.btnAlterar.Size = new System.Drawing.Size(79, 29);
            this.btnAlterar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnAlterar.StyleManager = null;
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.ThemeAuthor = "Narwin";
            this.btnAlterar.ThemeName = "MetroLite";
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.AutoCompleteCustomSource = null;
            this.btnAlterarAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.btnAlterarAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.btnAlterarAluno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnAlterarAluno.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAlterarAluno.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnAlterarAluno.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnAlterarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterarAluno.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlterarAluno.Image = null;
            this.btnAlterarAluno.Lines = null;
            this.btnAlterarAluno.Location = new System.Drawing.Point(375, 96);
            this.btnAlterarAluno.MaxLength = 32767;
            this.btnAlterarAluno.Multiline = false;
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.ReadOnly = false;
            this.btnAlterarAluno.Size = new System.Drawing.Size(133, 31);
            this.btnAlterarAluno.Style = MetroSet_UI.Design.Style.Dark;
            this.btnAlterarAluno.StyleManager = null;
            this.btnAlterarAluno.TabIndex = 8;
            this.btnAlterarAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAlterarAluno.ThemeAuthor = "Narwin";
            this.btnAlterarAluno.ThemeName = "MetroDark";
            this.btnAlterarAluno.UseSystemPasswordChar = false;
            this.btnAlterarAluno.WatermarkText = "";
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaa.ForeColor = System.Drawing.Color.White;
            this.aaa.Location = new System.Drawing.Point(27, 96);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(340, 24);
            this.aaa.TabIndex = 7;
            this.aaa.Text = "Digite o nome do curso que deseja alterar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 199);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmAlterarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAlterarCurso";
            this.Text = "frmAlterarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnCancelar;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetButton btnAlterar;
        private MetroSet_UI.Controls.MetroSetTextBox btnAlterarAluno;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}