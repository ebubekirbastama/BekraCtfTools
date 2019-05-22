using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000005 RID: 5
	public partial class binary : Form
	{
		// Token: 0x0600001D RID: 29 RVA: 0x0000349C File Offset: 0x0000169C
		public binary()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			this.InitializeComponent();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000034BC File Offset: 0x000016BC
		private void vrgtr()
		{
			string[] digits = new string[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"A",
				"B",
				"C",
				"D",
				"E",
				"F"
			};
			using (BinaryReader br = new BinaryReader(new FileStream(this.filePaths[0].ToString(), FileMode.Open, FileAccess.Read, FileShare.None, 1024)))
			{
				byte[] inbuff = new byte[0];
				while ((inbuff = br.ReadBytes(50)).Length != 0)
				{
					int b;
					for (b = 0; b < inbuff.Length - 1; b++)
					{
						this.globaldgr = this.globaldgr + digits[(int)(inbuff[b] / 16 % 16)] + digits[(int)(inbuff[b] % 16)] + " ";
					}
					this.globaldgr = this.globaldgr + digits[(int)(inbuff[b] / 16 % 16)] + digits[(int)(inbuff[b] % 16)];
				}
				this.richTextBox1.Text = this.globaldgr.ToString();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003638 File Offset: 0x00001838
		private void binary_DragDrop(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				try
				{
					this.filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
					this.th = new Thread(new ThreadStart(this.vrgtr));
					this.th.Start();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Bekra Ctf Tools");
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000036C4 File Offset: 0x000018C4
		private void binary_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop, false);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.All;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000036F8 File Offset: 0x000018F8
		private void işlemleriDurdurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.th.Abort();
			}
			catch
			{
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000372C File Offset: 0x0000192C
		private void hexTextÇevirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] data = binary.hextotextcevir(this.richTextBox1.Text);
			this.richTextBox2.AppendText(Encoding.ASCII.GetString(data));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003764 File Offset: 0x00001964
		public static byte[] hextotextcevir(string hex)
		{
			hex = hex.Replace(" ", "");
			byte[] raw = new byte[hex.Length / 2];
			for (int i = 0; i < raw.Length; i++)
			{
				raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
			}
			return raw;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000037C0 File Offset: 0x000019C0
		private void groupPanel1_DragDrop(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				try
				{
					this.filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
					this.th = new Thread(new ThreadStart(this.vrgtr));
					this.th.Start();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Bekra Ctf Tools");
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000384C File Offset: 0x00001A4C
		private void groupPanel1_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop, false);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.All;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000387D File Offset: 0x00001A7D
		private void binary_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000022 RID: 34
		private Thread th;

		// Token: 0x04000023 RID: 35
		private string[] filePaths;

		// Token: 0x04000024 RID: 36
		private string globaldgr;
	}
}
