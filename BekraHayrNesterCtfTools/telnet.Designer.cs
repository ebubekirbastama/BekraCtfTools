namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000B RID: 11
	public partial class telnet : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00006068 File Offset: 0x00004268
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000060A0 File Offset: 0x000042A0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BekraHayrNesterCtfTools.telnet));
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtip = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtport = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.label9 = new global::System.Windows.Forms.Label();
			this.buttonX1 = new global::DevComponents.DotNetBar.ButtonX();
			this.groupPanel1 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.groupPanel3 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.buttonX2 = new global::DevComponents.DotNetBar.ButtonX();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupPanel2 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.textBoxX3 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.textBoxX1 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.textBoxX2 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.groupPanel1.SuspendLayout();
			this.groupPanel3.SuspendLayout();
			this.groupPanel2.SuspendLayout();
			base.SuspendLayout();
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label8.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label8.Location = new global::System.Drawing.Point(21, 13);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(20, 16);
			this.label8.TabIndex = 18;
			this.label8.Text = "İp";
			this.txtip.Border.Class = "TextBoxBorder";
			this.txtip.Location = new global::System.Drawing.Point(61, 13);
			this.txtip.Name = "txtip";
			this.txtip.Size = new global::System.Drawing.Size(103, 20);
			this.txtip.TabIndex = 15;
			this.txtport.Border.Class = "TextBoxBorder";
			this.txtport.Location = new global::System.Drawing.Point(61, 45);
			this.txtport.Name = "txtport";
			this.txtport.Size = new global::System.Drawing.Size(46, 20);
			this.txtport.TabIndex = 17;
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label9.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label9.Location = new global::System.Drawing.Point(21, 45);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(34, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Port";
			this.buttonX1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX1.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.buttonX1.Location = new global::System.Drawing.Point(121, 107);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new global::System.Drawing.Size(92, 37);
			this.buttonX1.TabIndex = 8;
			this.buttonX1.Text = "Bağlantı Yap";
			this.buttonX1.Click += new global::System.EventHandler(this.buttonX1_Click);
			this.groupPanel1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel1.Controls.Add(this.groupPanel3);
			this.groupPanel1.Controls.Add(this.groupPanel2);
			this.groupPanel1.Controls.Add(this.richTextBox1);
			this.groupPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.groupPanel1.Name = "groupPanel1";
			this.groupPanel1.Size = new global::System.Drawing.Size(1048, 495);
			this.groupPanel1.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.groupPanel1.Style.BackColorGradientAngle = 90;
			this.groupPanel1.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.groupPanel1.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderBottomWidth = 1;
			this.groupPanel1.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel1.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderLeftWidth = 1;
			this.groupPanel1.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderRightWidth = 1;
			this.groupPanel1.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderTopWidth = 1;
			this.groupPanel1.Style.CornerDiameter = 4;
			this.groupPanel1.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel1.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupPanel1.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel1.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel1.TabIndex = 1;
			this.groupPanel3.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel3.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel3.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel3.Controls.Add(this.buttonX2);
			this.groupPanel3.Controls.Add(this.txtport);
			this.groupPanel3.Controls.Add(this.label8);
			this.groupPanel3.Controls.Add(this.label2);
			this.groupPanel3.Controls.Add(this.label9);
			this.groupPanel3.Controls.Add(this.label1);
			this.groupPanel3.Controls.Add(this.txtip);
			this.groupPanel3.Location = new global::System.Drawing.Point(245, 0);
			this.groupPanel3.Name = "groupPanel3";
			this.groupPanel3.Size = new global::System.Drawing.Size(236, 168);
			this.groupPanel3.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.groupPanel3.Style.BackColorGradientAngle = 90;
			this.groupPanel3.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.groupPanel3.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderBottomWidth = 1;
			this.groupPanel3.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel3.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderLeftWidth = 1;
			this.groupPanel3.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderRightWidth = 1;
			this.groupPanel3.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderTopWidth = 1;
			this.groupPanel3.Style.CornerDiameter = 4;
			this.groupPanel3.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel3.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupPanel3.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel3.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel3.TabIndex = 23;
			this.groupPanel3.Text = "Telnet";
			this.buttonX2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX2.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.buttonX2.Location = new global::System.Drawing.Point(121, 107);
			this.buttonX2.Name = "buttonX2";
			this.buttonX2.Size = new global::System.Drawing.Size(92, 37);
			this.buttonX2.TabIndex = 8;
			this.buttonX2.Text = "Bağlantı Yap";
			this.buttonX2.Click += new global::System.EventHandler(this.buttonX2_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label2.Location = new global::System.Drawing.Point(21, 84);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(58, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Durum :";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label1.Location = new global::System.Drawing.Point(82, 86);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(76, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Bekleniyor";
			this.groupPanel2.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel2.Controls.Add(this.label5);
			this.groupPanel2.Controls.Add(this.textBoxX3);
			this.groupPanel2.Controls.Add(this.textBoxX1);
			this.groupPanel2.Controls.Add(this.textBoxX2);
			this.groupPanel2.Controls.Add(this.label3);
			this.groupPanel2.Controls.Add(this.buttonX1);
			this.groupPanel2.Controls.Add(this.label4);
			this.groupPanel2.Location = new global::System.Drawing.Point(3, 0);
			this.groupPanel2.Name = "groupPanel2";
			this.groupPanel2.Size = new global::System.Drawing.Size(236, 168);
			this.groupPanel2.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.groupPanel2.Style.BackColorGradientAngle = 90;
			this.groupPanel2.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.groupPanel2.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderBottomWidth = 1;
			this.groupPanel2.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel2.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderLeftWidth = 1;
			this.groupPanel2.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderRightWidth = 1;
			this.groupPanel2.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderTopWidth = 1;
			this.groupPanel2.Style.CornerDiameter = 4;
			this.groupPanel2.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel2.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupPanel2.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel2.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel2.TabIndex = 22;
			this.groupPanel2.Text = "Ftp";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label5.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label5.Location = new global::System.Drawing.Point(98, 1);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(26, 16);
			this.label5.TabIndex = 24;
			this.label5.Text = "Url";
			this.textBoxX3.Border.Class = "TextBoxBorder";
			this.textBoxX3.Location = new global::System.Drawing.Point(18, 19);
			this.textBoxX3.Name = "textBoxX3";
			this.textBoxX3.Size = new global::System.Drawing.Size(195, 20);
			this.textBoxX3.TabIndex = 23;
			this.toolTip1.SetToolTip(this.textBoxX3, "Lütfen direk adresi Giriniz\r\n(((ebubekirbastama.com))\r\n!!!!ftp://!!! Girmenize gerek yok");
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Location = new global::System.Drawing.Point(110, 77);
			this.textBoxX1.Name = "textBoxX1";
			this.textBoxX1.Size = new global::System.Drawing.Size(103, 20);
			this.textBoxX1.TabIndex = 21;
			this.textBoxX1.UseSystemPasswordChar = true;
			this.textBoxX2.Border.Class = "TextBoxBorder";
			this.textBoxX2.Location = new global::System.Drawing.Point(110, 45);
			this.textBoxX2.Name = "textBoxX2";
			this.textBoxX2.Size = new global::System.Drawing.Size(103, 20);
			this.textBoxX2.TabIndex = 19;
			this.textBoxX2.UseSystemPasswordChar = true;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label3.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label3.Location = new global::System.Drawing.Point(15, 77);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(38, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Şifre";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label4.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label4.Location = new global::System.Drawing.Point(15, 45);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(89, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Kullanıcı Adı";
			this.richTextBox1.Location = new global::System.Drawing.Point(3, 177);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(1030, 309);
			this.richTextBox1.TabIndex = 21;
			this.richTextBox1.Text = "";
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = global::System.Windows.Forms.ToolTipIcon.Warning;
			this.toolTip1.ToolTipTitle = "Bekra Hayr Nester";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1048, 495);
			base.Controls.Add(this.groupPanel1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "telnet";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Telnet,Ftp,SSH Connect";
			this.groupPanel1.ResumeLayout(false);
			this.groupPanel3.ResumeLayout(false);
			this.groupPanel3.PerformLayout();
			this.groupPanel2.ResumeLayout(false);
			this.groupPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000064 RID: 100
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000066 RID: 102
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtip;

		// Token: 0x04000067 RID: 103
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtport;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000069 RID: 105
		private global::DevComponents.DotNetBar.ButtonX buttonX1;

		// Token: 0x0400006A RID: 106
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400006E RID: 110
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;

		// Token: 0x0400006F RID: 111
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;

		// Token: 0x04000070 RID: 112
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000074 RID: 116
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000076 RID: 118
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;

		// Token: 0x04000077 RID: 119
		private global::DevComponents.DotNetBar.ButtonX buttonX2;
	}
}
