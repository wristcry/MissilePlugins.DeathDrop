using System;
using System.Linq;
using SDG.Unturned;

namespace DeathDrop
{
	// Token: 0x02000015 RID: 21
	public static class reversed
	{
		// Token: 0x06000064 RID: 100 RVA: 0x0000681C File Offset: 0x00004A1C
		public static void permissions_check_for_item_by_type_or_id(ushort item_id, string[] permissions, out bool remove, out bool save)
		{
			remove = false;
			save = false;
			Plugin instance = Plugin.Instance;
			for (int i = 0; i < instance.Configuration.Instance.Items.Count; i++)
			{
				XmlItem xmlItem = instance.Configuration.Instance.Items[i];
				bool flag = xmlItem.ID != item_id;
				if (!flag)
				{
					bool flag2 = permissions.Contains(xmlItem.Remove);
					if (flag2)
					{
						remove = true;
					}
					else
					{
						bool flag3 = permissions.Contains(xmlItem.Save);
						if (!flag3)
						{
							goto IL_74;
						}
						save = true;
					}
					return;
				}
				IL_74:;
			}
			ItemAsset itemAsset = Assets.find(EAssetType.ITEM, item_id) as ItemAsset;
			bool flag4 = itemAsset != null;
			if (flag4)
			{
				for (int j = 0; j < instance.Configuration.Instance.Types.Count; j++)
				{
					XmlType xmlType = instance.Configuration.Instance.Types[j];
					bool flag5 = xmlType.ID.ToLower() != itemAsset.type.ToString().ToLower();
					if (!flag5)
					{
						bool flag6 = permissions.Contains(xmlType.Remove);
						if (flag6)
						{
							remove = true;
							break;
						}
						bool flag7 = permissions.Contains(xmlType.Save);
						if (flag7)
						{
							save = true;
							break;
						}
					}
				}
				return;
			}
		}
	}
}
