using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000006 RID: 6
	public partial class Form1 : Form
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00003E5C File Offset: 0x0000205C
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003E80 File Offset: 0x00002080
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.openFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.th = new Thread(new ThreadStart(this.isimaktar));
					this.th.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bekra HayrNester");
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003EF0 File Offset: 0x000020F0
		private void isimaktar()
		{
			try
			{
				using (this.sr = File.OpenText(this.openFileDialog1.FileName))
				{
					for (string kelime = this.sr.ReadLine(); kelime != null; kelime = this.sr.ReadLine())
					{
						this.listBox1.Items.Add(kelime);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bekra HayrNester");
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003F98 File Offset: 0x00002198
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.dsyl != "";
			if (flag)
			{
				Process.Start(this.dsyl);
				for (int i = 0; i < this.listBox1.Items.Count; i++)
				{
					Thread.Sleep(1000);
					SendKeys.SendWait(this.listBox1.Items[i].ToString());
					Thread.Sleep(1000);
					SendKeys.SendWait("{ENTER}");
					Thread.Sleep(1000);
					SendKeys.SendWait("{ENTER}");
				}
			}
			else
			{
				MessageBox.Show("Usta  Dosyayı Seç Aloo", "Bekra Hayr Nester");
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004054 File Offset: 0x00002254
		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = DialogResult.OK == this.openFileDialog2.ShowDialog();
			if (flag)
			{
				this.dsyl = this.openFileDialog2.FileName.ToString();
			}
		}

		// Token: 0x0400002D RID: 45
		private Thread th;

		// Token: 0x0400002E RID: 46
		private StreamReader sr;

		// Token: 0x0400002F RID: 47
		private string dsyl = "";
	}
}
