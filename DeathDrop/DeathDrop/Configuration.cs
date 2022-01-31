using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Rocket.API;
using SDG.Unturned;

namespace DeathDrop
{
	// Token: 0x0200000E RID: 14
	public class Configuration : IRocketPluginConfiguration, IDefaultable
	{
		// Token: 0x06000043 RID: 67 RVA: 0x0000532C File Offset: 0x0000352C
		public void LoadDefaults()
		{
			this.Clothes = new XmlClothes
			{
				Hat = "dd.clothes.save.hat",
				Mask = "dd.clothes.save.mask",
				Glasses = "dd.clothes.save.glasses",
				Shirt = "dd.clothes.save.shirt",
				Pants = "dd.clothes.save.pants",
				Vest = "dd.clothes.save.vest",
				Backpack = "dd.clothes.save.backpack"
			};
			this.Slots = new XmlSlots
			{
				Primary = "dd.slots.save.primary",
				Secondary = "dd.slots.save.secondary",
				Hands = "dd.slots.save.hands",
				Shirt = "dd.slots.save.shirt",
				Pants = "dd.slots.save.pants",
				Vest = "dd.slots.save.vest",
				Backpack = "dd.slots.save.backpack"
			};
			this.Items = new List<XmlItem>
			{
				new XmlItem(122, "dd.items.save.122", "dd.items.remove.122", "dd.items.spawn.122"),
				new XmlItem(519, "dd.items.save.519", "dd.items.remove.519", "dd.items.spawn.519")
			};
			this.Types = new List<XmlType>();
			EItemType[] array = (EItemType[])Enum.GetValues(typeof(EItemType));
			for (int i = 0; i < array.Length; i++)
			{
				this.Types.Add(new XmlType(array[i].ToString(), "dd.types.save." + array[i].ToString().ToLower().Replace("_", string.Empty), "dd.types.remove." + array[i].ToString().ToLower().Replace("_", string.Empty)));
			}
		}

		// Token: 0x0400002E RID: 46
		public XmlClothes Clothes = new XmlClothes();

		// Token: 0x0400002F RID: 47
		public XmlSlots Slots = new XmlSlots();

		// Token: 0x04000030 RID: 48
		[XmlArrayItem(ElementName = "Item")]
		public List<XmlItem> Items = new List<XmlItem>();

		// Token: 0x04000031 RID: 49
		[XmlArrayItem(ElementName = "Type")]
		public List<XmlType> Types = new List<XmlType>();
	}
}
