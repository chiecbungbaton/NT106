namespace Lab5
{
    partial class Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            this.boxLogin = new System.Windows.Forms.GroupBox();
            this.logout = new System.Windows.Forms.Button();
            this.sendMail = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smptPort = new System.Windows.Forms.TextBox();
            this.imapPort = new System.Windows.Forms.TextBox();
            this.smtpBox = new System.Windows.Forms.TextBox();
            this.imapBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // boxLogin
            // 
            this.boxLogin.BackColor = System.Drawing.Color.GhostWhite;
            this.boxLogin.Controls.Add(this.logout);
            this.boxLogin.Controls.Add(this.sendMail);
            this.boxLogin.Controls.Add(this.refresh);
            this.boxLogin.Controls.Add(this.login);
            this.boxLogin.Controls.Add(this.label2);
            this.boxLogin.Controls.Add(this.label1);
            this.boxLogin.Controls.Add(this.password);
            this.boxLogin.Controls.Add(this.username);
            this.boxLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxLogin.Location = new System.Drawing.Point(17, 12);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(459, 114);
            this.boxLogin.TabIndex = 0;
            this.boxLogin.TabStop = false;
            this.boxLogin.Text = "Login";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Lavender;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(364, 80);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(85, 27);
            this.logout.TabIndex = 7;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // sendMail
            // 
            this.sendMail.BackColor = System.Drawing.Color.Lavender;
            this.sendMail.FlatAppearance.BorderSize = 0;
            this.sendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMail.Location = new System.Drawing.Point(364, 49);
            this.sendMail.Name = "sendMail";
            this.sendMail.Size = new System.Drawing.Size(85, 27);
            this.sendMail.TabIndex = 6;
            this.sendMail.Text = "SEND";
            this.sendMail.UseVisualStyleBackColor = false;
            this.sendMail.Visible = false;
            this.sendMail.Click += new System.EventHandler(this.sendMail_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Lavender;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Location = new System.Drawing.Point(364, 15);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 27);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "REFRESH";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Visible = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Lavender;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Location = new System.Drawing.Point(364, 46);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(85, 27);
            this.login.TabIndex = 4;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(82, 63);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(267, 27);
            this.password.TabIndex = 1;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(82, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(267, 27);
            this.username.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.smptPort);
            this.groupBox2.Controls.Add(this.imapPort);
            this.groupBox2.Controls.Add(this.smtpBox);
            this.groupBox2.Controls.Add(this.imapBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(482, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // smptPort
            // 
            this.smptPort.BackColor = System.Drawing.SystemColors.Window;
            this.smptPort.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smptPort.Location = new System.Drawing.Point(283, 63);
            this.smptPort.Name = "smptPort";
            this.smptPort.ReadOnly = true;
            this.smptPort.Size = new System.Drawing.Size(45, 27);
            this.smptPort.TabIndex = 6;
            this.smptPort.Text = "465";
            this.smptPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imapPort
            // 
            this.imapPort.BackColor = System.Drawing.SystemColors.Window;
            this.imapPort.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imapPort.Location = new System.Drawing.Point(284, 27);
            this.imapPort.Name = "imapPort";
            this.imapPort.ReadOnly = true;
            this.imapPort.Size = new System.Drawing.Size(45, 27);
            this.imapPort.TabIndex = 5;
            this.imapPort.Text = "993";
            this.imapPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smtpBox
            // 
            this.smtpBox.BackColor = System.Drawing.SystemColors.Window;
            this.smtpBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smtpBox.Location = new System.Drawing.Point(56, 63);
            this.smtpBox.Name = "smtpBox";
            this.smtpBox.ReadOnly = true;
            this.smtpBox.Size = new System.Drawing.Size(178, 27);
            this.smtpBox.TabIndex = 4;
            this.smtpBox.Text = "smtp.gmail.com";
            this.smtpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imapBox
            // 
            this.imapBox.BackColor = System.Drawing.SystemColors.Window;
            this.imapBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imapBox.Location = new System.Drawing.Point(56, 27);
            this.imapBox.Name = "imapBox";
            this.imapBox.ReadOnly = true;
            this.imapBox.Size = new System.Drawing.Size(178, 27);
            this.imapBox.TabIndex = 2;
            this.imapBox.Text = "imap.gmail.com";
            this.imapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(243, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(242, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "IMAP";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.from,
            this.subject,
            this.datetime});
            this.dataGridView.Location = new System.Drawing.Point(17, 132);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(804, 397);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.number.HeaderText = "No.";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 50;
            // 
            // from
            // 
            this.from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.from.HeaderText = "From";
            this.from.MinimumWidth = 6;
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.from.Width = 200;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subject.Width = 300;
            // 
            // datetime
            // 
            this.datetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datetime.HeaderText = "Date & Time";
            this.datetime.MinimumWidth = 6;
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            this.datetime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datetime.Width = 200;
            // 
            // Bai4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 541);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boxLogin);
            this.MaximizeBox = false;
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.boxLogin.ResumeLayout(false);
            this.boxLogin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox boxLogin;
        private TextBox password;
        private TextBox username;
        private GroupBox groupBox2;
        private Button login;
        private Label label2;
        private Label label1;
        private TextBox smptPort;
        private TextBox imapPort;
        private TextBox smtpBox;
        private TextBox imapBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button sendMail;
        private Button refresh;
        private Button logout;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn datetime;
    }
}