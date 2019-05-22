namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000004 RID: 4
	public partial class BekraCTFPanel : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002D9C File Offset: 0x00000F9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002DD4 File Offset: 0x00000FD4
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BekraCTFPanel));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aynı Değerleri Bulma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rar Brute-Force";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Yazıcı Tersten Yazma";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "WordList Md5 Deneyici";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(140, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Dosya Hext to String";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(261, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "Post or Get İstekleri";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "Web Site Login Brute-Force";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(140, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "Telnet,Ssh,Ftp Connect";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(260, 119);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 48);
            this.button9.TabIndex = 8;
            this.button9.Text = "Base64 Decode";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(395, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 48);
            this.button10.TabIndex = 9;
            this.button10.Text = "Qr Code Oku";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(396, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(129, 48);
            this.button11.TabIndex = 10;
            this.button11.Text = "Cümle Brute-Force";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(395, 120);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(129, 48);
            this.button12.TabIndex = 11;
            this.button12.Text = "Rdp Brute-Force";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // BekraCTFPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 176);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BekraCTFPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BekraCTFPanel";
            this.ResumeLayout(false);

		}

		// Token: 0x04000017 RID: 23
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}
