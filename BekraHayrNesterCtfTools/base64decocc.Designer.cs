namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000003 RID: 3
	public partial class base64decocc : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002888 File Offset: 0x00000A88
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000028C0 File Offset: 0x00000AC0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BekraHayrNesterCtfTools.base64decocc));
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.bekraCtfToolsV01ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.decodeEtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.listBox1.AllowDrop = true;
			this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(178, 264);
			this.listBox1.TabIndex = 0;
			this.listBox1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
			this.listBox1.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.bekraCtfToolsV01ToolStripMenuItem,
				this.toolStripSeparator1,
				this.decodeEtToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(181, 76);
			this.bekraCtfToolsV01ToolStripMenuItem.Enabled = false;
			this.bekraCtfToolsV01ToolStripMenuItem.Name = "bekraCtfToolsV01ToolStripMenuItem";
			this.bekraCtfToolsV01ToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.bekraCtfToolsV01ToolStripMenuItem.Text = "Bekra Ctf Tools V0.1";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(177, 6);
			this.decodeEtToolStripMenuItem.Name = "decodeEtToolStripMenuItem";
			this.decodeEtToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.decodeEtToolStripMenuItem.Text = "Decode Et";
			this.decodeEtToolStripMenuItem.Click += new global::System.EventHandler(this.decodeEtToolStripMenuItem_Click);
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Location = new global::System.Drawing.Point(205, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(496, 265);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.AllowDrop = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(709, 286);
			this.ContextMenuStrip = this.contextMenuStrip1;
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.listBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "base64decocc";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bekra Base64 Decode";
			base.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.base64decocc_DragDrop);
			base.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.base64decocc_DragEnter);
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ToolStripMenuItem bekraCtfToolsV01ToolStripMenuItem;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ToolStripMenuItem decodeEtToolStripMenuItem;
	}
}
