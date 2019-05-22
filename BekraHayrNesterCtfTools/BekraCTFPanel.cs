using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000004 RID: 4
	public partial class BekraCTFPanel : Form
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002C69 File Offset: 0x00000E69
		public BekraCTFPanel()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002C84 File Offset: 0x00000E84
		private void button1_Click(object sender, EventArgs e)
		{
			aynıdgrbl ay = new aynıdgrbl();
			ay.ShowDialog();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002CA0 File Offset: 0x00000EA0
		private void button2_Click(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.ShowDialog();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002CBC File Offset: 0x00000EBC
		private void button3_Click(object sender, EventArgs e)
		{
			tertsyaziyazma ts = new tertsyaziyazma();
			ts.ShowDialog();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002CD8 File Offset: 0x00000ED8
		private void button4_Click(object sender, EventArgs e)
		{
			Md5Brutefforcewordlist md5brt = new Md5Brutefforcewordlist();
			md5brt.ShowDialog();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CF4 File Offset: 0x00000EF4
		private void button5_Click(object sender, EventArgs e)
		{
			binary bynr = new binary();
			bynr.ShowDialog();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002D10 File Offset: 0x00000F10
		private void button6_Click(object sender, EventArgs e)
		{
			Post_or_Get p_o = new Post_or_Get();
			p_o.ShowDialog();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002D2C File Offset: 0x00000F2C
		private void button7_Click(object sender, EventArgs e)
		{
			Webloginbrute wb = new Webloginbrute();
			wb.ShowDialog();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D48 File Offset: 0x00000F48
		private void button8_Click(object sender, EventArgs e)
		{
			telnet t = new telnet();
			t.ShowDialog();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002D64 File Offset: 0x00000F64
		private void button9_Click(object sender, EventArgs e)
		{
			base64decocc bcd = new base64decocc();
			bcd.ShowDialog();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002D80 File Offset: 0x00000F80
		private void button10_Click(object sender, EventArgs e)
		{
			qrkodeoku ooo = new qrkodeoku();
			ooo.ShowDialog();
		}

        private void button11_Click(object sender, EventArgs e)
        {
            cumledenwordlist cmlf = new cumledenwordlist();cmlf.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rdphack ph = new rdphack(); ph.ShowDialog();
        }
    }
}
