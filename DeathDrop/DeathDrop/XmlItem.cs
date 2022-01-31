using System;
using System.Xml.Serialization;

namespace DeathDrop
{
	// Token: 0x02000011 RID: 17
	public class XmlItem
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00005530 File Offset: 0x00003730
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00005544 File Offset: 0x00003744
		[XmlAttribute]
		public ushort ID { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00005558 File Offset: 0x00003758
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000556C File Offset: 0x0000376C
		[XmlAttribute]
		public string Save { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00005580 File Offset: 0x00003780
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00005594 File Offset: 0x00003794
		[XmlAttribute]
		public string Remove { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000055A8 File Offset: 0x000037A8
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000055BC File Offset: 0x000037BC
		[XmlAttribute]
		public string Spawn { get; set; }

		// Token: 0x0600004F RID: 79 RVA: 0x00005318 File Offset: 0x00003518
		public XmlItem()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000055D0 File Offset: 0x000037D0
		public XmlItem(ushort id, string save, string remove, string spawn)
		{
			this.ID = id;
			this.Save = save;
			this.Remove = remove;
			this.Spawn = spawn;
		}
	}
}
