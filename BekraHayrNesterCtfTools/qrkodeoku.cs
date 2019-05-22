using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000A RID: 10
	public partial class qrkodeoku : Form
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00005979 File Offset: 0x00003B79
		public qrkodeoku()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005991 File Offset: 0x00003B91
		private void qrkodeoku_Load(object sender, EventArgs e)
		{
			this.AllowDrop = true;
			this.richTextBox1.AllowDrop = true;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000059AC File Offset: 0x00003BAC
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.op = new OpenFileDialog();
			bool flag = DialogResult.OK == this.op.ShowDialog();
			if (flag)
			{
				this.pictureBox1.ImageLocation = this.op.FileName.ToString();
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000059F8 File Offset: 0x00003BF8
		private void decodeEtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BarcodeReader Reader = new BarcodeReader();
			Result result = Reader.Decode((Bitmap)this.pictureBox1.Image);
			try
			{
				string decoded = result.ToString().Trim();
				bool flag = decoded != "";
				if (flag)
				{
					this.richTextBox1.AppendText(decoded);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000058 RID: 88
		private OpenFileDialog op;
	}
}
