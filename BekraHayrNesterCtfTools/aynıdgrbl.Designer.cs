namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000002 RID: 2
	public partial class aynıdgrbl : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002204 File Offset: 0x00000404
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && components != null;
			if (flag)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000223C File Offset: 0x0000043C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new global::System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.bekraHayrNesterToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aynıDeğeriBulToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.temizleToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.richTextBox1.Location = new global::System.Drawing.Point(3, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(222, 235);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox2.Location = new global::System.Drawing.Point(249, 2);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new global::System.Drawing.Size(222, 235);
			this.richTextBox2.TabIndex = 1;
			this.richTextBox2.Text = "";
			this.richTextBox3.Location = new global::System.Drawing.Point(3, 243);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new global::System.Drawing.Size(468, 203);
			this.richTextBox3.TabIndex = 2;
			this.richTextBox3.Text = "";
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.bekraHayrNesterToolStripMenuItem,
				this.aynıDeğeriBulToolStripMenuItem,
				this.temizleToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(181, 92);
			this.bekraHayrNesterToolStripMenuItem.Name = "bekraHayrNesterToolStripMenuItem";
			this.bekraHayrNesterToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.bekraHayrNesterToolStripMenuItem.Text = "Bekra Hayr Nester";
			this.aynıDeğeriBulToolStripMenuItem.Name = "aynıDeğeriBulToolStripMenuItem";
			this.aynıDeğeriBulToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.aynıDeğeriBulToolStripMenuItem.Text = "Aynı Değeri Bul";
			this.aynıDeğeriBulToolStripMenuItem.Click += new global::System.EventHandler(this.aynıDeğeriBulToolStripMenuItem_Click);
			this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
			this.temizleToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.temizleToolStripMenuItem.Text = "Temizle";
			this.temizleToolStripMenuItem.Click += new global::System.EventHandler(this.temizleToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(621, 450);
			this.ContextMenuStrip = this.contextMenuStrip1;
			base.Controls.Add(this.richTextBox3);
			base.Controls.Add(this.richTextBox2);
			base.Controls.Add(this.richTextBox1);
			base.Name = "aynıdgrbl";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Aynı Değeri Bul";
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000005 RID: 5
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.RichTextBox richTextBox2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.RichTextBox richTextBox3;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ToolStripMenuItem bekraHayrNesterToolStripMenuItem;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ToolStripMenuItem aynıDeğeriBulToolStripMenuItem;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
	}
}
