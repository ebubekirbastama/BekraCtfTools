namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000006 RID: 6
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000408C File Offset: 0x0000228C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000040C4 File Offset: 0x000022C4
		private void InitializeComponent()
		{
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new global::System.Windows.Forms.OpenFileDialog();
			this.button3 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button2.Location = new global::System.Drawing.Point(235, 13);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(118, 44);
			this.button2.TabIndex = 7;
			this.button2.Text = "Denemeye Başla";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.Location = new global::System.Drawing.Point(12, 269);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(210, 31);
			this.button1.TabIndex = 6;
			this.button1.Text = "Word List Aç";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(210, 251);
			this.listBox1.TabIndex = 4;
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog2.FileName = "openFileDialog1";
			this.button3.Location = new global::System.Drawing.Point(290, 261);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(75, 41);
			this.button3.TabIndex = 8;
			this.button3.Text = "Dosya Seç";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(370, 310);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.listBox1);
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rar Brute-Force";
			base.ResumeLayout(false);
		}

		// Token: 0x04000030 RID: 48
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.OpenFileDialog openFileDialog2;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Button button3;
	}
}
