using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000C RID: 12
	public partial class tertsyaziyazma : Form
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000071B0 File Offset: 0x000053B0
		public tertsyaziyazma()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000071C8 File Offset: 0x000053C8
		private void button1_Click(object sender, EventArgs e)
		{
			string metin = this.richTextBox1.Text;
			int dgr = metin.Length - 1;
			RichTextBox expr_1C = this.richTextBox1;
			expr_1C.Text += "\n";
			for (int i = 0; i < metin.Length; i++)
			{
				RichTextBox expr_3D = this.richTextBox1;
				expr_3D.Text += metin[dgr].ToString();
				dgr--;
			}
		}
	}
}
