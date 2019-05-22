namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000A RID: 10
	public partial class qrkodeoku : global::System.Windows.Forms.Form
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00005A68 File Offset: 0x00003C68
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005AA0 File Offset: 0x00003CA0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BekraHayrNesterCtfTools.qrkodeoku));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.bekraCtfToolsV01ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.decodeEtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(214, 233);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Location = new global::System.Drawing.Point(232, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(305, 233);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.bekraCtfToolsV01ToolStripMenuItem,
				this.toolStripSeparator1,
				this.decodeEtToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(177, 54);
			this.bekraCtfToolsV01ToolStripMenuItem.Enabled = false;
			this.bekraCtfToolsV01ToolStripMenuItem.Name = "bekraCtfToolsV01ToolStripMenuItem";
			this.bekraCtfToolsV01ToolStripMenuItem.Size = new global::System.Drawing.Size(176, 22);
			this.bekraCtfToolsV01ToolStripMenuItem.Text = "Bekra Ctf tools V0.1";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(173, 6);
			this.decodeEtToolStripMenuItem.Name = "decodeEtToolStripMenuItem";
			this.decodeEtToolStripMenuItem.Size = new global::System.Drawing.Size(176, 22);
			this.decodeEtToolStripMenuItem.Text = "Decode Et";
			this.decodeEtToolStripMenuItem.Click += new global::System.EventHandler(this.decodeEtToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(549, 256);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.pictureBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "qrkodeoku";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Qr Code Oku";
			base.Load += new global::System.EventHandler(this.qrkodeoku_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000059 RID: 89
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripMenuItem bekraCtfToolsV01ToolStripMenuItem;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ToolStripMenuItem decodeEtToolStripMenuItem;
	}
}
