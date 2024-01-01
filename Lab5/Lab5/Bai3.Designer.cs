namespace Lab5
{
    partial class Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3));
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_email
            // 
            this.textbox_email.BackColor = System.Drawing.Color.AliceBlue;
            this.textbox_email.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_email.Location = new System.Drawing.Point(139, 45);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(426, 31);
            this.textbox_email.TabIndex = 0;
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.Color.AliceBlue;
            this.textbox_password.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_password.Location = new System.Drawing.Point(139, 90);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(426, 31);
            this.textbox_password.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_login.Location = new System.Drawing.Point(616, 67);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(121, 56);
            this.button_login.TabIndex = 2;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_email,
            this.column_from,
            this.column_time});
            this.dataGridView1.Location = new System.Drawing.Point(40, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(758, 363);
            this.dataGridView1.TabIndex = 3;
            // 
            // column_email
            // 
            this.column_email.HeaderText = "Email";
            this.column_email.MinimumWidth = 6;
            this.column_email.Name = "column_email";
            this.column_email.ReadOnly = true;
            this.column_email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column_email.Width = 300;
            // 
            // column_from
            // 
            this.column_from.HeaderText = "From";
            this.column_from.MinimumWidth = 6;
            this.column_from.Name = "column_from";
            this.column_from.ReadOnly = true;
            this.column_from.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column_from.Width = 230;
            // 
            // column_time
            // 
            this.column_time.HeaderText = "Time";
            this.column_time.MinimumWidth = 6;
            this.column_time.Name = "column_time";
            this.column_time.ReadOnly = true;
            this.column_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column_time.Width = 180;
            // 
            // Bai3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_email);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Bai3";
            this.Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textbox_email;
        private TextBox textbox_password;
        private Button button_login;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column_email;
        private DataGridViewTextBoxColumn column_from;
        private DataGridViewTextBoxColumn column_time;
    }
}