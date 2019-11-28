namespace Trabalho_4 {
    partial class frmAcademico {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lblExcluir;
            MetroSet_UI.Controls.MetroDefaultSetButton conectar;
            System.Windows.Forms.Label label1;
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarConsultarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSenha = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtBanco = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtUsuario = new MetroSet_UI.Controls.MetroSetTextBox();
            label2 = new System.Windows.Forms.Label();
            lblExcluir = new System.Windows.Forms.Label();
            conectar = new MetroSet_UI.Controls.MetroDefaultSetButton();
            label1 = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(209, 158);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 20);
            label2.TabIndex = 9;
            label2.Text = "Senha:";
            // 
            // lblExcluir
            // 
            lblExcluir.AutoSize = true;
            lblExcluir.BackColor = System.Drawing.Color.Transparent;
            lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblExcluir.ForeColor = System.Drawing.Color.Black;
            lblExcluir.Location = new System.Drawing.Point(209, 98);
            lblExcluir.Name = "lblExcluir";
            lblExcluir.Size = new System.Drawing.Size(197, 20);
            lblExcluir.TabIndex = 5;
            lblExcluir.Text = "Nome do Banco de dados:";
            // 
            // conectar
            // 
            conectar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            conectar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            conectar.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            conectar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            conectar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            conectar.HoverTextColor = System.Drawing.Color.White;
            conectar.Location = new System.Drawing.Point(360, 231);
            conectar.Name = "conectar";
            conectar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            conectar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            conectar.NormalTextColor = System.Drawing.Color.Black;
            conectar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            conectar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            conectar.PressTextColor = System.Drawing.Color.White;
            conectar.Size = new System.Drawing.Size(91, 39);
            conectar.Style = MetroSet_UI.Design.Style.Light;
            conectar.StyleManager = null;
            conectar.TabIndex = 12;
            conectar.Text = "Conectar";
            conectar.ThemeAuthor = "Narwin";
            conectar.ThemeName = "MetroLite";
            conectar.Click += new System.EventHandler(this.metroDefaultSetButton1_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(209, 128);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome de usuario:";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.DarkGray;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.Visible = false;
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.pesquisarConsultarToolStripMenuItem});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click_1);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // pesquisarConsultarToolStripMenuItem
            // 
            this.pesquisarConsultarToolStripMenuItem.Name = "pesquisarConsultarToolStripMenuItem";
            this.pesquisarConsultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarConsultarToolStripMenuItem.Text = "Pesquisar/Consultar";
            this.pesquisarConsultarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarConsultarToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem1,
            this.alterarCursoToolStripMenuItem,
            this.excluirCursoToolStripMenuItem,
            this.pesquisarConsultarCursoToolStripMenuItem});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // incluirToolStripMenuItem1
            // 
            this.incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            this.incluirToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.incluirToolStripMenuItem1.Text = "Incluir curso";
            this.incluirToolStripMenuItem1.Click += new System.EventHandler(this.incluirToolStripMenuItem1_Click);
            // 
            // alterarCursoToolStripMenuItem
            // 
            this.alterarCursoToolStripMenuItem.Name = "alterarCursoToolStripMenuItem";
            this.alterarCursoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.alterarCursoToolStripMenuItem.Text = "Alterar curso";
            this.alterarCursoToolStripMenuItem.Click += new System.EventHandler(this.alterarCursoToolStripMenuItem_Click);
            // 
            // excluirCursoToolStripMenuItem
            // 
            this.excluirCursoToolStripMenuItem.Name = "excluirCursoToolStripMenuItem";
            this.excluirCursoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.excluirCursoToolStripMenuItem.Text = "Excluir curso";
            this.excluirCursoToolStripMenuItem.Click += new System.EventHandler(this.excluirCursoToolStripMenuItem_Click);
            // 
            // pesquisarConsultarCursoToolStripMenuItem
            // 
            this.pesquisarConsultarCursoToolStripMenuItem.Name = "pesquisarConsultarCursoToolStripMenuItem";
            this.pesquisarConsultarCursoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.pesquisarConsultarCursoToolStripMenuItem.Text = "Pesquisar/Consultar curso";
            this.pesquisarConsultarCursoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarConsultarCursoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.AutoCompleteCustomSource = null;
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSenha.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSenha.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSenha.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSenha.Image = null;
            this.txtSenha.Lines = null;
            this.txtSenha.Location = new System.Drawing.Point(409, 158);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = false;
            this.txtSenha.Size = new System.Drawing.Size(182, 26);
            this.txtSenha.Style = MetroSet_UI.Design.Style.Light;
            this.txtSenha.StyleManager = null;
            this.txtSenha.TabIndex = 17;
            this.txtSenha.Text = "123";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.ThemeAuthor = "Narwin";
            this.txtSenha.ThemeName = "MetroLite";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WatermarkText = "Senha";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.metroSetLabel1.Location = new System.Drawing.Point(0, 40);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(800, 34);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 11;
            this.metroSetLabel1.Text = "Conexão com o banco de dados";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // txtBanco
            // 
            this.txtBanco.AccessibleName = "nomeBanco";
            this.txtBanco.AutoCompleteCustomSource = null;
            this.txtBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBanco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBanco.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBanco.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBanco.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBanco.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtBanco.Image = null;
            this.txtBanco.Lines = null;
            this.txtBanco.Location = new System.Drawing.Point(409, 98);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(0);
            this.txtBanco.MaxLength = 32767;
            this.txtBanco.Multiline = false;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.ReadOnly = false;
            this.txtBanco.Size = new System.Drawing.Size(182, 26);
            this.txtBanco.Style = MetroSet_UI.Design.Style.Light;
            this.txtBanco.StyleManager = null;
            this.txtBanco.TabIndex = 15;
            this.txtBanco.Text = "academico";
            this.txtBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBanco.ThemeAuthor = "Narwin";
            this.txtBanco.ThemeName = "MetroLite";
            this.txtBanco.UseSystemPasswordChar = false;
            this.txtBanco.WatermarkText = "Banco de Dados";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleName = "nomeUsuario";
            this.txtUsuario.AutoCompleteCustomSource = null;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsuario.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsuario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsuario.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsuario.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsuario.Image = null;
            this.txtUsuario.Lines = null;
            this.txtUsuario.Location = new System.Drawing.Point(409, 128);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(182, 26);
            this.txtUsuario.Style = MetroSet_UI.Design.Style.Light;
            this.txtUsuario.StyleManager = null;
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.Text = "root";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.ThemeAuthor = "Narwin";
            this.txtUsuario.ThemeName = "MetroLite";
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.WatermarkText = "Usuario";
            // 
            // frmAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(lblExcluir);
            this.Controls.Add(conectar);
            this.Controls.Add(this.metroSetLabel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmAcademico";
            this.Text = "Acadêmico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarConsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarConsultarCursoToolStripMenuItem;
        private MetroSet_UI.Controls.MetroSetTextBox txtSenha;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox txtBanco;
        private MetroSet_UI.Controls.MetroSetTextBox txtUsuario;
    }
}

