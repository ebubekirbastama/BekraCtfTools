using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace BekraHayrNesterCtfTools.Properties
{
	// Token: 0x0200000F RID: 15
	[CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00008B08 File Offset: 0x00006D08
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400009B RID: 155
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
