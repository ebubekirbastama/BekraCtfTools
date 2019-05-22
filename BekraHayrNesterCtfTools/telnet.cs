using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x0200000B RID: 11
	public partial class telnet : Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00005E32 File Offset: 0x00004032
		public telnet()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			this.InitializeComponent();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005E51 File Offset: 0x00004051
		private void buttonX1_Click(object sender, EventArgs e)
		{
			this.th = new Thread(new ThreadStart(this.ftf_connect));
			this.th.Start();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005E78 File Offset: 0x00004078
		private void ftf_connect()
		{
			FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + this.textBoxX3.Text);
			ftpRequest.Credentials = new NetworkCredential(this.textBoxX2.Text, this.textBoxX1.Text);
			ftpRequest.Method = "NLST";
			ftpRequest.Method = "LIST";
			FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(responseStream);
			this.richTextBox1.AppendText(reader.ReadToEnd());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005F0C File Offset: 0x0000410C
		private void telnet_connect()
		{
			this.port = int.Parse(this.txtport.Text);
			this.TargetIP = this.txtip.Text;
			try
			{
				TcpClient telnet = new TcpClient(this.TargetIP, this.port);
				bool connected = telnet.Connected;
				if (connected)
				{
					this.label1.Text = string.Concat(new object[]
					{
						this.TargetIP,
						" - Port : ",
						this.port,
						" Connected"
					});
				}
				NetworkStream myStream = telnet.GetStream();
				StreamWriter gidenVeri = new StreamWriter(myStream);
				StreamReader gelenVeri = new StreamReader(myStream);
				while ((this.line = gelenVeri.ReadLine()) != null)
				{
					this.richTextBox1.AppendText(this.line);
					this.richTextBox1.AppendText("\r");
				}
				telnet.Close();
			}
			catch (SocketException se)
			{
				MessageBox.Show(se.Message + "Tanınmayan Host - " + this.TargetIP + " - Çıkış yapılıyor...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006040 File Offset: 0x00004240
		private void buttonX2_Click(object sender, EventArgs e)
		{
			this.th = new Thread(new ThreadStart(this.telnet_connect));
			this.th.Start();
		}

		// Token: 0x04000060 RID: 96
		private string line;

		// Token: 0x04000061 RID: 97
		private int port;

		// Token: 0x04000062 RID: 98
		private string TargetIP;

		// Token: 0x04000063 RID: 99
		private Thread th;
	}
}
