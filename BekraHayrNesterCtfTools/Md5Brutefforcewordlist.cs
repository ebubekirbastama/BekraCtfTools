using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000007 RID: 7
	public partial class Md5Brutefforcewordlist : Form
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000043C5 File Offset: 0x000025C5
		public Md5Brutefforcewordlist()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			this.InitializeComponent();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000043F0 File Offset: 0x000025F0
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

		// Token: 0x06000032 RID: 50 RVA: 0x00004460 File Offset: 0x00002660
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

		// Token: 0x06000033 RID: 51 RVA: 0x00004508 File Offset: 0x00002708
		public static string MD5Sifrele(string metin)
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			byte[] btr = Encoding.UTF8.GetBytes(metin);
			btr = md5.ComputeHash(btr);
			StringBuilder sb = new StringBuilder();
			byte[] array = btr;
			for (int i = 0; i < array.Length; i++)
			{
				byte ba = array[i];
				sb.Append(ba.ToString("x2").ToLower());
			}
			return sb.ToString();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004577 File Offset: 0x00002777
		private void aynıDeğeriBulToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.th = new Thread(new ThreadStart(this.sifrecozz));
			this.th.Start();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000045A0 File Offset: 0x000027A0
		private void sifrecozz()
		{
			for (int i = 0; i < this.listBox1.Items.Count; i++)
			{
				this.label4.Text = i.ToString();
				string mdlihali = Md5Brutefforcewordlist.MD5Sifrele(this.listBox1.Items[i].ToString());
				bool flag = mdlihali == this.textBox1.Text;
				if (flag)
				{
					this.textBox2.Text = this.listBox1.Items[i].ToString();
				}
			}
		}

		// Token: 0x04000037 RID: 55
		private Thread th;

		// Token: 0x04000038 RID: 56
		private StreamReader sr;

		// Token: 0x04000039 RID: 57
		private string dsyl = "";
	}
}
