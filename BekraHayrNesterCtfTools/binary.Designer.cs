namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000005 RID: 5
	public partial class binary : global::System.Windows.Forms.Form
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003880 File Offset: 0x00001A80
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000038B8 File Offset: 0x00001AB8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BekraHayrNesterCtfTools.binary));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.bekraCtfToolsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.işlemleriDurdurToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.hexTextÇevirToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.groupPanel1 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Location = new global::System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(520, 389);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.bekraCtfToolsToolStripMenuItem,
				this.işlemleriDurdurToolStripMenuItem,
				this.hexTextÇevirToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(164, 70);
			this.bekraCtfToolsToolStripMenuItem.Name = "bekraCtfToolsToolStripMenuItem";
			this.bekraCtfToolsToolStripMenuItem.Size = new global::System.Drawing.Size(163, 22);
			this.bekraCtfToolsToolStripMenuItem.Text = "Bekra Ctf Tools";
			this.işlemleriDurdurToolStripMenuItem.Name = "işlemleriDurdurToolStripMenuItem";
			this.işlemleriDurdurToolStripMenuItem.Size = new global::System.Drawing.Size(163, 22);
			this.işlemleriDurdurToolStripMenuItem.Text = "İşlemleri Durdur";
			this.işlemleriDurdurToolStripMenuItem.Click += new global::System.EventHandler(this.işlemleriDurdurToolStripMenuItem_Click);
			this.hexTextÇevirToolStripMenuItem.Name = "hexTextÇevirToolStripMenuItem";
			this.hexTextÇevirToolStripMenuItem.Size = new global::System.Drawing.Size(163, 22);
			this.hexTextÇevirToolStripMenuItem.Text = "Hex to Text Çevir";
			this.hexTextÇevirToolStripMenuItem.Click += new global::System.EventHandler(this.hexTextÇevirToolStripMenuItem_Click);
			this.richTextBox2.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox2.Location = new global::System.Drawing.Point(538, 12);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new global::System.Drawing.Size(374, 389);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = "";
			this.groupPanel1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel1.Location = new global::System.Drawing.Point(918, 12);
			this.groupPanel1.Name = "groupPanel1";
			this.groupPanel1.Size = new global::System.Drawing.Size(188, 131);
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
			this.groupPanel1.TabIndex = 3;
			this.groupPanel1.Text = "Dosya Paneli";
			this.groupPanel1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.groupPanel1_DragDrop);
			this.groupPanel1.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.groupPanel1_DragEnter);
			this.AllowDrop = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(1118, 416);
			this.ContextMenuStrip = this.contextMenuStrip1;
			base.Controls.Add(this.groupPanel1);
			base.Controls.Add(this.richTextBox2);
			base.Controls.Add(this.richTextBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "binary";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "binary";
			base.Load += new global::System.EventHandler(this.binary_Load);
			base.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.binary_DragDrop);
			base.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.binary_DragEnter);
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000025 RID: 37
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ToolStripMenuItem bekraCtfToolsToolStripMenuItem;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ToolStripMenuItem işlemleriDurdurToolStripMenuItem;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.RichTextBox richTextBox2;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ToolStripMenuItem hexTextÇevirToolStripMenuItem;

		// Token: 0x0400002C RID: 44
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
	}
}
