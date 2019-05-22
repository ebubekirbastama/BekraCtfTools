using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000008 RID: 8
	public partial class Post_or_Get : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00004C49 File Offset: 0x00002E49
		public Post_or_Get()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004C64 File Offset: 0x00002E64
		private void button1_Click(object sender, EventArgs e)
		{
			using (WebClient client = new WebClient())
			{
				client.Headers.Add("Host: pintimarket.com");
				client.Headers.Add("User-Agent: Mozilla/5.0 (Windows NT 6.3; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0");
				client.Headers.Add("Accept: */*");
				client.Headers.Add("Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3");
				client.Headers.Add("Accept-Encoding: gzip, deflate, br");
				client.Headers.Add("Referer: https://pintimarket.com/sifre/");
				client.Headers.Add("Content-Type: application/x-www-form-urlencoded; charset=UTF-8");
				client.Headers.Add("X-Requested-With: XMLHttpRequest");
				client.Headers.Add("DNT: 1");
				string gelenYanit = client.UploadString(this.url.Text, this.postveri.Text);
				this.richTextBox1.AppendText(gelenYanit.ToString());
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004D60 File Offset: 0x00002F60
		private void Post_or_Get_Load(object sender, EventArgs e)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004D6E File Offset: 0x00002F6E
		private void button2_Click(object sender, EventArgs e)
		{
			this.richTextBox3.AppendText(this.getistegiii(this.textBoxX1.Text));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004D90 File Offset: 0x00002F90
		public string getistegiii(string uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
			string result;
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			{
				using (Stream stream = response.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						result = reader.ReadToEnd();
					}
				}
			}
			return result;
		}

		// Token: 0x04000047 RID: 71
		private static readonly HttpClient client = new HttpClient();
	}
}
