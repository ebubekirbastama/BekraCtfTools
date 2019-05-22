using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace BekraHayrNesterCtfTools.Properties
{
	// Token: 0x0200000E RID: 14
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00008A93 File Offset: 0x00006C93
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00008AA0 File Offset: 0x00006CA0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("BekraHayrNesterCtfTools.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00008AE8 File Offset: 0x00006CE8
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00008AFF File Offset: 0x00006CFF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000099 RID: 153
		private static ResourceManager resourceMan;

		// Token: 0x0400009A RID: 154
		private static CultureInfo resourceCulture;
	}
}
