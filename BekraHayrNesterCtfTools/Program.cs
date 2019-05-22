using System;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000595E File Offset: 0x00003B5E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BekraCTFPanel());
		}
	}
}
