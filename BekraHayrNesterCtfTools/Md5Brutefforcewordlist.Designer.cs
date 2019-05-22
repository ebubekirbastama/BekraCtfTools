namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000007 RID: 7
	public partial class Md5Brutefforcewordlist : global::System.Windows.Forms.Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0000463C File Offset: 0x0000283C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004674 File Offset: 0x00002874
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.button1 = new global::System.Windows.Forms.Button();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.bekraHayrNesterToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aynıDeğeriBulToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(9, 267);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(210, 31);
			this.button1.TabIndex = 8;
			this.button1.Text = "Word List Aç";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(9, 10);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(210, 251);
			this.listBox1.TabIndex = 7;
			this.openFileDialog1.FileName = "openFileDialog1";
			this.textBox1.Location = new global::System.Drawing.Point(225, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(210, 20);
			this.textBox1.TabIndex = 9;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(297, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(61, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Şifreli Metin";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(297, 76);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(45, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Decode";
			this.textBox2.Location = new global::System.Drawing.Point(225, 92);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(210, 20);
			this.textBox2.TabIndex = 11;
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.bekraHayrNesterToolStripMenuItem,
				this.aynıDeğeriBulToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(181, 70);
			this.bekraHayrNesterToolStripMenuItem.Name = "bekraHayrNesterToolStripMenuItem";
			this.bekraHayrNesterToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.bekraHayrNesterToolStripMenuItem.Text = "Bekra Hayr Nester";
			this.aynıDeğeriBulToolStripMenuItem.Name = "aynıDeğeriBulToolStripMenuItem";
			this.aynıDeğeriBulToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.aynıDeğeriBulToolStripMenuItem.Text = "Şifreyi Çöz";
			this.aynıDeğeriBulToolStripMenuItem.Click += new global::System.EventHandler(this.aynıDeğeriBulToolStripMenuItem_Click);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(268, 147);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(105, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Denenen Şifre Adedi";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(308, 172);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(13, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "0";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(444, 311);
			this.ContextMenuStrip = this.contextMenuStrip1;
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.listBox1);
			base.Name = "Md5Brutefforcewordlist";
			this.Text = "Md5Brutefforcewordlist";
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003A RID: 58
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ToolStripMenuItem bekraHayrNesterToolStripMenuItem;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.ToolStripMenuItem aynıDeğeriBulToolStripMenuItem;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label4;
	}
}
