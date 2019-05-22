using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000003 RID: 3
	public partial class base64decocc : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000025CB File Offset: 0x000007CB
		public base64decocc()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025EC File Offset: 0x000007EC
		private void listBox1_DragDrop(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				try
				{
					this.yol = (string[])e.Data.GetData(DataFormats.FileDrop);
					this.th = new Thread(new ThreadStart(this.vrgtr));
					this.th.Start();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Bekra Ctf Tools");
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002678 File Offset: 0x00000878
		private void vrgtr()
		{
			try
			{
				using (this.sr = File.OpenText(this.yol[0].ToString()))
				{
					for (string kelime = this.sr.ReadLine(); kelime != null; kelime = this.sr.ReadLine())
					{
						this.listBox1.Items.Add(kelime);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bekra ctf Toosl");
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002720 File Offset: 0x00000920
		private void listBox1_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop, false);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.All;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002754 File Offset: 0x00000954
		private void base64decocc_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop, false);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.All;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002788 File Offset: 0x00000988
		private void base64decocc_DragDrop(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				try
				{
					this.yol = (string[])e.Data.GetData(DataFormats.FileDrop);
					this.th = new Thread(new ThreadStart(this.vrgtr));
					this.th.Start();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Bekra Ctf Tools");
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002814 File Offset: 0x00000A14
		private void decodeEtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.listBox1.Items.Count; i++)
			{
				byte[] data = Convert.FromBase64String(this.listBox1.Items[i].ToString());
				this.richTextBox1.AppendText(Encoding.UTF8.GetString(data));
				this.richTextBox1.AppendText("\r");
			}
		}

		// Token: 0x0400000D RID: 13
		private Thread th;

		// Token: 0x0400000E RID: 14
		private StreamReader sr;

		// Token: 0x0400000F RID: 15
		private string[] yol;
	}
}
