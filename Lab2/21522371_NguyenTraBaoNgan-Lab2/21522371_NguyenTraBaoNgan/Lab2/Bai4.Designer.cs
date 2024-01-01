namespace Lab2
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
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.writename = new System.Windows.Forms.TextBox();
            this.writeid = new System.Windows.Forms.TextBox();
            this.writephone = new System.Windows.Forms.TextBox();
            this.writesc1 = new System.Windows.Forms.TextBox();
            this.writesc2 = new System.Windows.Forms.TextBox();
            this.writesc3 = new System.Windows.Forms.TextBox();
            this.writeavg = new System.Windows.Forms.TextBox();
            this.readname = new System.Windows.Forms.TextBox();
            this.readid = new System.Windows.Forms.TextBox();
            this.readphone = new System.Windows.Forms.TextBox();
            this.readsc1 = new System.Windows.Forms.TextBox();
            this.readsc2 = new System.Windows.Forms.TextBox();
            this.readsc3 = new System.Windows.Forms.TextBox();
            this.readavg = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // write
            // 
            this.write.BackColor = System.Drawing.Color.Transparent;
            this.write.FlatAppearance.BorderSize = 0;
            this.write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.write.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.write.Location = new System.Drawing.Point(138, 149);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(96, 46);
            this.write.TabIndex = 0;
            this.write.Text = "WRITE";
            this.write.UseVisualStyleBackColor = false;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.Transparent;
            this.read.FlatAppearance.BorderSize = 0;
            this.read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.read.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.read.Location = new System.Drawing.Point(803, 152);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(95, 43);
            this.read.TabIndex = 1;
            this.read.Text = "READ";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(150, 627);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 41);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(719, 631);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(41, 36);
            this.back.TabIndex = 3;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(956, 630);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(42, 40);
            this.next.TabIndex = 4;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // writename
            // 
            this.writename.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writename.Location = new System.Drawing.Point(115, 210);
            this.writename.Name = "writename";
            this.writename.ReadOnly = true;
            this.writename.Size = new System.Drawing.Size(237, 31);
            this.writename.TabIndex = 5;
            this.writename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writeid
            // 
            this.writeid.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writeid.Location = new System.Drawing.Point(115, 271);
            this.writeid.Name = "writeid";
            this.writeid.ReadOnly = true;
            this.writeid.Size = new System.Drawing.Size(237, 31);
            this.writeid.TabIndex = 6;
            this.writeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writephone
            // 
            this.writephone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writephone.Location = new System.Drawing.Point(115, 331);
            this.writephone.Name = "writephone";
            this.writephone.ReadOnly = true;
            this.writephone.Size = new System.Drawing.Size(236, 31);
            this.writephone.TabIndex = 7;
            this.writephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writesc1
            // 
            this.writesc1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writesc1.Location = new System.Drawing.Point(115, 393);
            this.writesc1.Name = "writesc1";
            this.writesc1.ReadOnly = true;
            this.writesc1.Size = new System.Drawing.Size(236, 31);
            this.writesc1.TabIndex = 8;
            this.writesc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writesc2
            // 
            this.writesc2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writesc2.Location = new System.Drawing.Point(115, 451);
            this.writesc2.Name = "writesc2";
            this.writesc2.ReadOnly = true;
            this.writesc2.Size = new System.Drawing.Size(237, 31);
            this.writesc2.TabIndex = 9;
            this.writesc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writesc3
            // 
            this.writesc3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writesc3.Location = new System.Drawing.Point(115, 511);
            this.writesc3.Name = "writesc3";
            this.writesc3.ReadOnly = true;
            this.writesc3.Size = new System.Drawing.Size(237, 31);
            this.writesc3.TabIndex = 10;
            this.writesc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writeavg
            // 
            this.writeavg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writeavg.Location = new System.Drawing.Point(127, 575);
            this.writeavg.Name = "writeavg";
            this.writeavg.ReadOnly = true;
            this.writeavg.Size = new System.Drawing.Size(224, 31);
            this.writeavg.TabIndex = 11;
            this.writeavg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readname
            // 
            this.readname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readname.Location = new System.Drawing.Point(781, 212);
            this.readname.Name = "readname";
            this.readname.ReadOnly = true;
            this.readname.Size = new System.Drawing.Size(237, 31);
            this.readname.TabIndex = 12;
            this.readname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readid
            // 
            this.readid.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readid.Location = new System.Drawing.Point(781, 271);
            this.readid.Name = "readid";
            this.readid.ReadOnly = true;
            this.readid.Size = new System.Drawing.Size(237, 31);
            this.readid.TabIndex = 13;
            this.readid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readphone
            // 
            this.readphone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readphone.Location = new System.Drawing.Point(781, 331);
            this.readphone.Name = "readphone";
            this.readphone.ReadOnly = true;
            this.readphone.Size = new System.Drawing.Size(236, 31);
            this.readphone.TabIndex = 14;
            this.readphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readsc1
            // 
            this.readsc1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readsc1.Location = new System.Drawing.Point(781, 393);
            this.readsc1.Name = "readsc1";
            this.readsc1.ReadOnly = true;
            this.readsc1.Size = new System.Drawing.Size(236, 31);
            this.readsc1.TabIndex = 15;
            this.readsc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readsc2
            // 
            this.readsc2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readsc2.Location = new System.Drawing.Point(781, 451);
            this.readsc2.Name = "readsc2";
            this.readsc2.ReadOnly = true;
            this.readsc2.Size = new System.Drawing.Size(236, 31);
            this.readsc2.TabIndex = 16;
            this.readsc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readsc3
            // 
            this.readsc3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readsc3.Location = new System.Drawing.Point(782, 511);
            this.readsc3.Name = "readsc3";
            this.readsc3.ReadOnly = true;
            this.readsc3.Size = new System.Drawing.Size(236, 31);
            this.readsc3.TabIndex = 17;
            this.readsc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readavg
            // 
            this.readavg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readavg.Location = new System.Drawing.Point(798, 575);
            this.readavg.Name = "readavg";
            this.readavg.ReadOnly = true;
            this.readavg.Size = new System.Drawing.Size(219, 31);
            this.readavg.TabIndex = 18;
            this.readavg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(369, 136);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(312, 525);
            this.richTextBox.TabIndex = 19;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "1";
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1056, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.readavg);
            this.Controls.Add(this.readsc3);
            this.Controls.Add(this.readsc2);
            this.Controls.Add(this.readsc1);
            this.Controls.Add(this.readphone);
            this.Controls.Add(this.readid);
            this.Controls.Add(this.readname);
            this.Controls.Add(this.writeavg);
            this.Controls.Add(this.writesc3);
            this.Controls.Add(this.writesc2);
            this.Controls.Add(this.writesc1);
            this.Controls.Add(this.writephone);
            this.Controls.Add(this.writeid);
            this.Controls.Add(this.writename);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.read);
            this.Controls.Add(this.write);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button write;
        private Button read;
        private Button add;
        private Button back;
        private Button next;
        private TextBox writename;
        private TextBox writeid;
        private TextBox writephone;
        private TextBox writesc1;
        private TextBox writesc2;
        private TextBox writesc3;
        private TextBox writeavg;
        private TextBox readname;
        private TextBox readid;
        private TextBox readphone;
        private TextBox readsc1;
        private TextBox readsc2;
        private TextBox readsc3;
        private TextBox readavg;
        private RichTextBox richTextBox;
        private Label label1;
    }
}