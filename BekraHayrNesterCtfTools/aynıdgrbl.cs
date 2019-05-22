using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000002 RID: 2
	public partial class aynıdgrbl : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public aynıdgrbl()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000208C File Offset: 0x0000028C
		private void aynıDeğeriBulToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text.Trim();
			richTextBox2.Text.Trim();
			th = new Thread(new ThreadStart(dgrbul));
			th.Start();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E0 File Offset: 0x000002E0
		private void dgrbul()
		{
			string[] a = richTextBox1.Lines;
			string[] a2 = richTextBox2.Lines;
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < a2.Length; j++)
				{
					bool flag = a[i].ToString() == a2[j].ToString();
					if (flag)
					{
						bool flag2 = syc == 0;
						if (flag2)
						{
							richTextBox3.Text = a[i].ToString();
							syc++;
						}
						else
						{
							RichTextBox expr_81 = richTextBox3;
							expr_81.Text += "\n";
							RichTextBox expr_9D = richTextBox3;
							expr_9D.Text += a[i].ToString();
						}
					}
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021CD File Offset: 0x000003CD
		private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";
			richTextBox2.Text = "";
			richTextBox3.Text = "";
		}

		// Token: 0x04000001 RID: 1
		private Thread th;

		// Token: 0x04000002 RID: 2
		private ArrayList a1 = new ArrayList();

		// Token: 0x04000003 RID: 3
		private ArrayList a2 = new ArrayList();

		// Token: 0x04000004 RID: 4
		private int syc = 0;
	}
}
