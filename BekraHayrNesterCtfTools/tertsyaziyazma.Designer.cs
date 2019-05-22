namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000C RID: 12
	public partial class tertsyaziyazma : global::System.Windows.Forms.Form
	{
		// Token: 0x06000050 RID: 80 RVA: 0x0000724C File Offset: 0x0000544C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007284 File Offset: 0x00005484
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(383, 264);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(104, 46);
			this.button1.TabIndex = 0;
			this.button1.Text = "Yazıyı Terse Çevir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new global::System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(475, 246);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(499, 314);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.button1);
			base.Name = "tertsyaziyazma";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tersten Yazi Yazma";
			base.ResumeLayout(false);
		}

		// Token: 0x04000078 RID: 120
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.RichTextBox richTextBox1;
	}
}
