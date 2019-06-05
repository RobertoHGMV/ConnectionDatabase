namespace ConnectionDatabase.UI
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageConnDatabase = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbServerType = new MetroFramework.Controls.MetroComboBox();
            this.btnConTest = new MetroFramework.Controls.MetroButton();
            this.cmdOk = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDatabase = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtServer = new MetroFramework.Controls.MetroTextBox();
            this.tabPageConnSbo = new MetroFramework.Controls.MetroTabPage();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.btnConnTestSbo = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPasswordSbo = new MetroFramework.Controls.MetroTextBox();
            this.txtUserSbo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tabPageConnDatabase.SuspendLayout();
            this.tabPageConnSbo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tabPageConnDatabase);
            this.metroTabControl1.Controls.Add(this.tabPageConnSbo);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(497, 270);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPageConnDatabase
            // 
            this.tabPageConnDatabase.Controls.Add(this.metroLabel7);
            this.tabPageConnDatabase.Controls.Add(this.cbServerType);
            this.tabPageConnDatabase.Controls.Add(this.btnConTest);
            this.tabPageConnDatabase.Controls.Add(this.cmdOk);
            this.tabPageConnDatabase.Controls.Add(this.metroLabel4);
            this.tabPageConnDatabase.Controls.Add(this.metroLabel3);
            this.tabPageConnDatabase.Controls.Add(this.txtDatabase);
            this.tabPageConnDatabase.Controls.Add(this.txtPassword);
            this.tabPageConnDatabase.Controls.Add(this.txtUser);
            this.tabPageConnDatabase.Controls.Add(this.metroLabel2);
            this.tabPageConnDatabase.Controls.Add(this.metroLabel1);
            this.tabPageConnDatabase.Controls.Add(this.txtServer);
            this.tabPageConnDatabase.HorizontalScrollbarBarColor = true;
            this.tabPageConnDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageConnDatabase.HorizontalScrollbarSize = 10;
            this.tabPageConnDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabPageConnDatabase.Name = "tabPageConnDatabase";
            this.tabPageConnDatabase.Size = new System.Drawing.Size(489, 228);
            this.tabPageConnDatabase.TabIndex = 0;
            this.tabPageConnDatabase.Text = "Conexão - Banco";
            this.tabPageConnDatabase.VerticalScrollbarBarColor = true;
            this.tabPageConnDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageConnDatabase.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 115);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(108, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Tipo de Servidor";
            // 
            // cbServerType
            // 
            this.cbServerType.FormattingEnabled = true;
            this.cbServerType.ItemHeight = 23;
            this.cbServerType.Location = new System.Drawing.Point(11, 137);
            this.cbServerType.Name = "cbServerType";
            this.cbServerType.Size = new System.Drawing.Size(230, 29);
            this.cbServerType.TabIndex = 5;
            this.cbServerType.UseSelectable = true;
            // 
            // btnConTest
            // 
            this.btnConTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConTest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConTest.Location = new System.Drawing.Point(339, 193);
            this.btnConTest.Name = "btnConTest";
            this.btnConTest.Size = new System.Drawing.Size(138, 23);
            this.btnConTest.TabIndex = 6;
            this.btnConTest.Text = "Testar Conexão";
            this.btnConTest.UseSelectable = true;
            this.btnConTest.Click += new System.EventHandler(this.btnConTest_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdOk.Location = new System.Drawing.Point(11, 193);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 7;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseSelectable = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(247, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Banco de dados";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(247, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Senha";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDatabase.CustomButton.Image = null;
            this.txtDatabase.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtDatabase.CustomButton.Name = "";
            this.txtDatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDatabase.CustomButton.TabIndex = 1;
            this.txtDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDatabase.CustomButton.UseSelectable = true;
            this.txtDatabase.CustomButton.Visible = false;
            this.txtDatabase.Lines = new string[0];
            this.txtDatabase.Location = new System.Drawing.Point(247, 35);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.ShortcutsEnabled = true;
            this.txtDatabase.Size = new System.Drawing.Size(230, 23);
            this.txtDatabase.TabIndex = 2;
            this.txtDatabase.UseSelectable = true;
            this.txtDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(247, 86);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(230, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(11, 86);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(230, 23);
            this.txtUser.TabIndex = 3;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Usuário";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Servidor";
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.CustomButton.Image = null;
            this.txtServer.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtServer.CustomButton.Name = "";
            this.txtServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.CustomButton.TabIndex = 1;
            this.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServer.CustomButton.UseSelectable = true;
            this.txtServer.CustomButton.Visible = false;
            this.txtServer.Lines = new string[0];
            this.txtServer.Location = new System.Drawing.Point(11, 35);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.ShortcutsEnabled = true;
            this.txtServer.Size = new System.Drawing.Size(230, 23);
            this.txtServer.TabIndex = 1;
            this.txtServer.UseSelectable = true;
            this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPageConnSbo
            // 
            this.tabPageConnSbo.Controls.Add(this.btnOk);
            this.tabPageConnSbo.Controls.Add(this.btnConnTestSbo);
            this.tabPageConnSbo.Controls.Add(this.metroLabel5);
            this.tabPageConnSbo.Controls.Add(this.txtPasswordSbo);
            this.tabPageConnSbo.Controls.Add(this.txtUserSbo);
            this.tabPageConnSbo.Controls.Add(this.metroLabel6);
            this.tabPageConnSbo.HorizontalScrollbarBarColor = true;
            this.tabPageConnSbo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageConnSbo.HorizontalScrollbarSize = 10;
            this.tabPageConnSbo.Location = new System.Drawing.Point(4, 38);
            this.tabPageConnSbo.Name = "tabPageConnSbo";
            this.tabPageConnSbo.Size = new System.Drawing.Size(489, 228);
            this.tabPageConnSbo.TabIndex = 1;
            this.tabPageConnSbo.Text = "Conexão - SAP";
            this.tabPageConnSbo.VerticalScrollbarBarColor = true;
            this.tabPageConnSbo.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageConnSbo.VerticalScrollbarSize = 10;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOk.Location = new System.Drawing.Point(11, 193);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnConnTestSbo
            // 
            this.btnConnTestSbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnTestSbo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConnTestSbo.Location = new System.Drawing.Point(339, 193);
            this.btnConnTestSbo.Name = "btnConnTestSbo";
            this.btnConnTestSbo.Size = new System.Drawing.Size(138, 23);
            this.btnConnTestSbo.TabIndex = 10;
            this.btnConnTestSbo.Text = "Testar Conexão";
            this.btnConnTestSbo.UseSelectable = true;
            this.btnConnTestSbo.Click += new System.EventHandler(this.btnConnTestSbo_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(247, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Senha";
            // 
            // txtPasswordSbo
            // 
            this.txtPasswordSbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPasswordSbo.CustomButton.Image = null;
            this.txtPasswordSbo.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtPasswordSbo.CustomButton.Name = "";
            this.txtPasswordSbo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordSbo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordSbo.CustomButton.TabIndex = 1;
            this.txtPasswordSbo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordSbo.CustomButton.UseSelectable = true;
            this.txtPasswordSbo.CustomButton.Visible = false;
            this.txtPasswordSbo.Lines = new string[0];
            this.txtPasswordSbo.Location = new System.Drawing.Point(247, 35);
            this.txtPasswordSbo.MaxLength = 32767;
            this.txtPasswordSbo.Name = "txtPasswordSbo";
            this.txtPasswordSbo.PasswordChar = '*';
            this.txtPasswordSbo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordSbo.SelectedText = "";
            this.txtPasswordSbo.SelectionLength = 0;
            this.txtPasswordSbo.SelectionStart = 0;
            this.txtPasswordSbo.ShortcutsEnabled = true;
            this.txtPasswordSbo.Size = new System.Drawing.Size(230, 23);
            this.txtPasswordSbo.TabIndex = 9;
            this.txtPasswordSbo.UseSelectable = true;
            this.txtPasswordSbo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordSbo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserSbo
            // 
            // 
            // 
            // 
            this.txtUserSbo.CustomButton.Image = null;
            this.txtUserSbo.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtUserSbo.CustomButton.Name = "";
            this.txtUserSbo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserSbo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserSbo.CustomButton.TabIndex = 1;
            this.txtUserSbo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserSbo.CustomButton.UseSelectable = true;
            this.txtUserSbo.CustomButton.Visible = false;
            this.txtUserSbo.Lines = new string[0];
            this.txtUserSbo.Location = new System.Drawing.Point(11, 35);
            this.txtUserSbo.MaxLength = 32767;
            this.txtUserSbo.Name = "txtUserSbo";
            this.txtUserSbo.PasswordChar = '\0';
            this.txtUserSbo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserSbo.SelectedText = "";
            this.txtUserSbo.SelectionLength = 0;
            this.txtUserSbo.SelectionStart = 0;
            this.txtUserSbo.ShortcutsEnabled = true;
            this.txtUserSbo.Size = new System.Drawing.Size(230, 23);
            this.txtUserSbo.TabIndex = 8;
            this.txtUserSbo.UseSelectable = true;
            this.txtUserSbo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserSbo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 13);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Usuário";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 334);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionForm";
            this.Text = "Teste de Conexão";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPageConnDatabase.ResumeLayout(false);
            this.tabPageConnDatabase.PerformLayout();
            this.tabPageConnSbo.ResumeLayout(false);
            this.tabPageConnSbo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabPageConnDatabase;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDatabase;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtServer;
        private MetroFramework.Controls.MetroTabPage tabPageConnSbo;
        private MetroFramework.Controls.MetroButton cmdOk;
        private MetroFramework.Controls.MetroButton btnConTest;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroButton btnConnTestSbo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPasswordSbo;
        private MetroFramework.Controls.MetroTextBox txtUserSbo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbServerType;
    }
}

