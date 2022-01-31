using System;
using System.Xml.Serialization;

namespace DeathDrop
{
	// Token: 0x02000012 RID: 18
	public class XmlType
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00005600 File Offset: 0x00003800
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00005614 File Offset: 0x00003814
		[XmlAttribute]
		public string ID { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005628 File Offset: 0x00003828
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000563C File Offset: 0x0000383C
		[XmlAttribute]
		public string Save { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005650 File Offset: 0x00003850
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00005664 File Offset: 0x00003864
		[XmlAttribute]
		public string Remove { get; set; }

		// Token: 0x06000057 RID: 87 RVA: 0x00005318 File Offset: 0x00003518
		public XmlType()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005678 File Offset: 0x00003878
		public XmlType(string id, string save, string remove)
		{
			this.ID = id;
			this.Save = save;
			this.Remove = remove;
		}
	}
}
