namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000D RID: 13
	public partial class Webloginbrute : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005B RID: 91 RVA: 0x0000791C File Offset: 0x00005B1C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007954 File Offset: 0x00005B54
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Webloginbrute));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kullanıcıAdıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıŞifresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemleriDurdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupPanel1.Controls.Add(this.label8);
            this.groupPanel1.Controls.Add(this.listBox4);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.textBoxX4);
            this.groupPanel1.Controls.Add(this.label10);
            this.groupPanel1.Controls.Add(this.listBox3);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.textBoxX5);
            this.groupPanel1.Controls.Add(this.listBox2);
            this.groupPanel1.Controls.Add(this.listBox1);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.textBoxX3);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.textBoxX2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.textBoxX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(799, 268);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıAdıToolStripMenuItem,
            this.kullanıcıŞifresiToolStripMenuItem,
            this.işlemleriDurdurToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 70);
            // 
            // kullanıcıAdıToolStripMenuItem
            // 
            this.kullanıcıAdıToolStripMenuItem.Name = "kullanıcıAdıToolStripMenuItem";
            this.kullanıcıAdıToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kullanıcıAdıToolStripMenuItem.Text = "Kullanıcı Adı";
            this.kullanıcıAdıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıAdıToolStripMenuItem_Click);
            // 
            // kullanıcıŞifresiToolStripMenuItem
            // 
            this.kullanıcıŞifresiToolStripMenuItem.Name = "kullanıcıŞifresiToolStripMenuItem";
            this.kullanıcıŞifresiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kullanıcıŞifresiToolStripMenuItem.Text = "Kullanıcı Şifresi";
            this.kullanıcıŞifresiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıŞifresiToolStripMenuItem_Click);
            // 
            // işlemleriDurdurToolStripMenuItem
            // 
            this.işlemleriDurdurToolStripMenuItem.Name = "işlemleriDurdurToolStripMenuItem";
            this.işlemleriDurdurToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.işlemleriDurdurToolStripMenuItem.Text = "İşlemleri Durdur";
            this.işlemleriDurdurToolStripMenuItem.Click += new System.EventHandler(this.işlemleriDurdurToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(427, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Kırılan Site";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(401, 27);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 225);
            this.listBox4.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(543, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "user nad pass zamanı";
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Location = new System.Drawing.Point(695, 51);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(83, 20);
            this.textBoxX4.TabIndex = 20;
            this.textBoxX4.Text = "2000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(35, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Url";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(9, 27);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 225);
            this.listBox3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(292, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Passwords";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(157, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "User Names";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(539, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Siteye Ulaşma Zamanı";
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Location = new System.Drawing.Point(695, 27);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.Size = new System.Drawing.Size(83, 20);
            this.textBoxX5.TabIndex = 13;
            this.textBoxX5.Text = "3000";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(266, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 225);
            this.listBox2.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(137, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 9;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(671, 164);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(107, 36);
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "Brute-Force Başla";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(558, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giriş Butonu(Html)";
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Location = new System.Drawing.Point(695, 124);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(83, 20);
            this.textBoxX3.TabIndex = 6;
            this.textBoxX3.Text = "wp-submit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(539, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Şifresi(Html)";
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Location = new System.Drawing.Point(695, 75);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(83, 20);
            this.textBoxX2.TabIndex = 4;
            this.textBoxX2.Text = "user_pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(558, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı(Html)";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(695, 99);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(83, 20);
            this.textBoxX1.TabIndex = 0;
            this.textBoxX1.Text = "user_login";
            // 
            // Webloginbrute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 268);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Webloginbrute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Login Brute-Force";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Webloginbrute_FormClosing);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000080 RID: 128
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000081 RID: 129
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000083 RID: 131
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000086 RID: 134
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000088 RID: 136
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;

		// Token: 0x04000089 RID: 137
		private global::DevComponents.DotNetBar.ButtonX buttonX1;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.ToolStripMenuItem kullanıcıAdıToolStripMenuItem;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.ToolStripMenuItem kullanıcıŞifresiToolStripMenuItem;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.ListBox listBox2;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400008F RID: 143
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.ToolStripMenuItem işlemleriDurdurToolStripMenuItem;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.ListBox listBox3;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000096 RID: 150
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.ListBox listBox4;
	}
}
