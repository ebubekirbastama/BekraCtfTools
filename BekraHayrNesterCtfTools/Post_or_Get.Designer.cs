namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000008 RID: 8
	public partial class Post_or_Get : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00004E24 File Offset: 0x00003024
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004E5C File Offset: 0x0000305C
		private void InitializeComponent()
		{
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.label3 = new global::System.Windows.Forms.Label();
			this.postveri = new global::System.Windows.Forms.RichTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.url = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.label1 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.label5 = new global::System.Windows.Forms.Label();
			this.textBoxX1 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.label6 = new global::System.Windows.Forms.Label();
			this.richTextBox3 = new global::System.Windows.Forms.RichTextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(798, 430);
			this.tabControl1.TabIndex = 0;
			this.tabPage1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.postveri);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.url);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.richTextBox1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(790, 404);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Post";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label3.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label3.Location = new global::System.Drawing.Point(572, 47);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(68, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Post İstek";
			this.postveri.BackColor = global::System.Drawing.Color.Black;
			this.postveri.ForeColor = global::System.Drawing.Color.White;
			this.postveri.Location = new global::System.Drawing.Point(405, 66);
			this.postveri.Name = "postveri";
			this.postveri.Size = new global::System.Drawing.Size(376, 159);
			this.postveri.TabIndex = 5;
			this.postveri.Text = "";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label2.Location = new global::System.Drawing.Point(582, 5);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(34, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "URL";
			this.url.BackColor = global::System.Drawing.Color.Red;
			this.url.Border.Class = "TextBoxBorder";
			this.url.ForeColor = global::System.Drawing.Color.Black;
			this.url.Location = new global::System.Drawing.Point(405, 24);
			this.url.Name = "url";
			this.url.Size = new global::System.Drawing.Size(377, 20);
			this.url.TabIndex = 3;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label1.Location = new global::System.Drawing.Point(166, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(79, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Gelen İstek";
			this.richTextBox1.BackColor = global::System.Drawing.Color.Black;
			this.richTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.richTextBox1.Location = new global::System.Drawing.Point(8, 23);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(390, 202);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.button1.Location = new global::System.Drawing.Point(682, 231);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(99, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Post Yolla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.tabPage2.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.textBoxX1);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.richTextBox3);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(790, 357);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Get";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label5.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label5.Location = new global::System.Drawing.Point(582, 11);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(34, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "URL";
			this.textBoxX1.BackColor = global::System.Drawing.Color.Red;
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxX1.Location = new global::System.Drawing.Point(405, 30);
			this.textBoxX1.Name = "textBoxX1";
			this.textBoxX1.Size = new global::System.Drawing.Size(377, 20);
			this.textBoxX1.TabIndex = 10;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label6.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label6.Location = new global::System.Drawing.Point(166, 11);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(79, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Gelen İstek";
			this.richTextBox3.BackColor = global::System.Drawing.Color.Black;
			this.richTextBox3.ForeColor = global::System.Drawing.Color.White;
			this.richTextBox3.Location = new global::System.Drawing.Point(8, 29);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new global::System.Drawing.Size(390, 202);
			this.richTextBox3.TabIndex = 8;
			this.richTextBox3.Text = "";
			this.button2.Location = new global::System.Drawing.Point(541, 56);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(99, 34);
			this.button2.TabIndex = 7;
			this.button2.Text = "Get Yolla";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(798, 430);
			base.Controls.Add(this.tabControl1);
			base.Name = "Post_or_Get";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Post ve Get İstekler";
			base.Load += new global::System.EventHandler(this.Post_or_Get_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000048 RID: 72
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000050 RID: 80
		private global::DevComponents.DotNetBar.Controls.TextBoxX url;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.RichTextBox postveri;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000054 RID: 84
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.RichTextBox richTextBox3;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Button button2;
	}
}
