namespace Trabalho_4 {
    partial class frmExcluirAluno {
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
            this.lblTituloExcluiAluno = new System.Windows.Forms.Label();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.txtExcluir = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnCancelar = new MetroSet_UI.Controls.MetroSetButton();
            this.btnExcluir = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloExcluiAluno
            // 
            this.lblTituloExcluiAluno.AutoSize = true;
            this.lblTituloExcluiAluno.Font = new System.Drawing.Font("Muli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExcluiAluno.ForeColor = System.Drawing.Color.White;
            this.lblTituloExcluiAluno.Location = new System.Drawing.Point(308, 9);
            this.lblTituloExcluiAluno.Name = "lblTituloExcluiAluno";
            this.lblTituloExcluiAluno.Size = new System.Drawing.Size(161, 35);
            this.lblTituloExcluiAluno.TabIndex = 0;
            this.lblTituloExcluiAluno.Text = "Excluir Aluno";
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.White;
            this.lblExcluir.Location = new System.Drawing.Point(65, 77);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(318, 24);
            this.lblExcluir.TabIndex = 1;
            this.lblExcluir.Text = "Digite o ID do aluno que deseja excluir: ";
            // 
            // txtExcluir
            // 
            this.txtExcluir.AutoCompleteCustomSource = null;
            this.txtExcluir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtExcluir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtExcluir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtExcluir.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtExcluir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExcluir.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtExcluir.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtExcluir.Image = null;
            this.txtExcluir.Lines = null;
            this.txtExcluir.Location = new System.Drawing.Point(389, 74);
            this.txtExcluir.MaxLength = 32767;
            this.txtExcluir.Multiline = false;
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.ReadOnly = false;
            this.txtExcluir.Size = new System.Drawing.Size(62, 27);
            this.txtExcluir.Style = MetroSet_UI.Design.Style.Dark;
            this.txtExcluir.StyleManager = null;
            this.txtExcluir.TabIndex = 2;
            this.txtExcluir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtExcluir.ThemeAuthor = "Narwin";
            this.txtExcluir.ThemeName = "MetroDark";
            this.txtExcluir.UseSystemPasswordChar = false;
            this.txtExcluir.WatermarkText = "";
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
            this.btnCancelar.Location = new System.Drawing.Point(620, 77);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalTextColor = System.Drawing.Color.White;
            this.btnCancelar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancelar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancelar.PressTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnCancelar.StyleManager = null;
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeAuthor = "Narwin";
            this.btnCancelar.ThemeName = "MetroLite";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExcluir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExcluir.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluir.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluir.HoverTextColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(495, 77);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluir.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluir.NormalTextColor = System.Drawing.Color.White;
            this.btnExcluir.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExcluir.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExcluir.PressTextColor = System.Drawing.Color.White;
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.Style = MetroSet_UI.Design.Style.Custom;
            this.btnExcluir.StyleManager = null;
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.ThemeAuthor = "Narwin";
            this.btnExcluir.ThemeName = "MetroLite";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 239);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmExcluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.lblTituloExcluiAluno);
            this.Name = "frmExcluirAluno";
            this.Text = "Excluir Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloExcluiAluno;
        private System.Windows.Forms.Label lblExcluir;
        private MetroSet_UI.Controls.MetroSetTextBox txtExcluir;
        private MetroSet_UI.Controls.MetroSetButton btnCancelar;
        private MetroSet_UI.Controls.MetroSetButton btnExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}