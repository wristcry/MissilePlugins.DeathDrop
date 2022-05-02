using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Rocket.API;
using Rocket.API.Serialisation;
using Rocket.Core;
using Rocket.Core.Plugins;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace DeathDrop
{
	// Token: 0x02000013 RID: 19
	public class Plugin : RocketPlugin<Configuration>
	{
		// Token: 0x06000059 RID: 89 RVA: 0x000056A0 File Offset: 0x000038A0
		protected override void Load()
		{
			//Plugin.idk_what_is_this = new List<CSteamID>();
			Plugin.items_to_save_dict = new Dictionary<CSteamID, List<Item>>();
			Plugin.Instance = this;
			Provider.modeConfigData.Players.Lose_Weapons_PvP = false;
			Provider.modeConfigData.Players.Lose_Weapons_PvE = false;
			Provider.modeConfigData.Players.Lose_Clothes_PvP = false;
			Provider.modeConfigData.Players.Lose_Clothes_PvE = false;
			Provider.modeConfigData.Players.Lose_Items_PvP = (float)0;
			Provider.modeConfigData.Players.Lose_Items_PvE = (float)0;
			PlayerLife.onPlayerLifeUpdated = (PlayerLifeUpdated)Delegate.Combine(PlayerLife.onPlayerLifeUpdated, new PlayerLifeUpdated(this.on_player_life_updated));
			PlayerLife.OnRevived_Global = (Action<PlayerLife>)Delegate.Combine(PlayerLife.OnRevived_Global, new Action<PlayerLife>(this.on_revived));
			Console.WriteLine("[!] missileplugins.com \n[!] cracked in ~3 hours \n[!] crack date: 2021/05/31 \n[!] cracked by: wristcry \n\tvk.com/valvedeveloper \n\tyougame.biz/members/251594/ \n\tt.me/lbydelta \n[!] donate: \n\tbtc: bc1qcfp7yac7mret289rwdkey7e92zs4nsgctcu234 \n\tytn: YefcEALfKJEPyD9mqsGc88sbJvZWqtPMNH \nreverse date: 2022/01/21 (ya vjebal piva i reshil porevesit)");
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005778 File Offset: 0x00003978
		protected override void Unload()
		{
			PlayerLife.onPlayerLifeUpdated = (PlayerLifeUpdated)Delegate.Remove(PlayerLife.onPlayerLifeUpdated, new PlayerLifeUpdated(this.on_player_life_updated));
			PlayerLife.OnRevived_Global = (Action<PlayerLife>)Delegate.Remove(PlayerLife.OnRevived_Global, new Action<PlayerLife>(this.on_revived));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000057C8 File Offset: 0x000039C8
		private void on_revived(PlayerLife plife)
		{
			CSteamID steamID = plife.channel.owner.playerID.steamID;
			if (Plugin.items_to_save_dict.ContainsKey(steamID))
			{
				List<Item> list = Plugin.items_to_save_dict[steamID];
				for (int i = 0; i < list.Count; i++)
				{
					plife.player.inventory.forceAddItem(list[i], true, false);
				}
				Plugin.items_to_save_dict.Remove(steamID);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005854 File Offset: 0x00003A54
		private void on_player_life_updated(Player player) {
			if (player.life.isDead) {
				CSteamID steamID = player.channel.owner.playerID.steamID;
				//if (Plugin.idk_what_is_this.Contains(steamID)) {
					Configuration cfg = base.Configuration.Instance;
					List<Item> list = new List<Item>();
					Vector3 point = player.transform.position + Vector3.up;
					string[] permissions = R.Permissions.GetPermissions(new RocketPlayer(steamID.ToString(), null, false)).Select(new Func<Permission, string>(Plugin.lambda.lambda_instance.lambda_get_permission_name)).ToArray<string>();
					this.process_items_by_type_or_id(player, 0, permissions, !permissions.Contains(cfg.Slots.Primary), false);
					this.process_items_by_type_or_id(player, 1, permissions, !permissions.Contains(cfg.Slots.Secondary), false);
					this.process_items_by_type_or_id(player, 2, permissions, !permissions.Contains(cfg.Slots.Hands), false);
					PlayerClothing clothing = player.clothing;
					ushort hat = clothing.hat;
					ushort mask = clothing.mask;
					ushort vest = clothing.vest;
					ushort shirt = clothing.shirt;
					ushort pants = clothing.pants;
					ushort glasses = clothing.glasses;
					ushort backpack = clothing.backpack;
					byte hat_quality = clothing.hatQuality;
					byte mask_quality = clothing.maskQuality;
					byte vest_quality = clothing.vestQuality;
					byte shirt_quality = clothing.shirtQuality;
					byte pants_quality = clothing.pantsQuality;
					byte glasses_quality = clothing.glassesQuality;
					byte backpack_quality = clothing.backpackQuality;
					byte[] hat_metadata = clothing.hatState;
					byte[] mask_metadata = clothing.maskState;
					byte[] vest_metadata = clothing.vestState;
					byte[] shirt_metadata = clothing.shirtState;
					byte[] pants_metadata = clothing.pantsState;
					byte[] glasses_metadata = clothing.glassesState;
					byte[] backpack_metadata = clothing.backpackState;
					if (shirt > 0) {
						bool flag1;
						bool flag2;
						this.permissions_check_for_item_by_type_or_id(shirt, permissions, out flag1, out flag2);
						if (flag2) {
							goto IL_32B;
						}
						else if (permissions.Contains(cfg.Clothes.Shirt)) {
							goto IL_32B;
						}
						list.AddRange(this.process_items_by_type_or_id(player, PlayerInventory.SHIRT, permissions, true, true));
						if (!flag1) {
							ItemManager.dropItem(new Item(shirt, 1, shirt_quality, shirt_metadata), point, false, true, true);
						}
						shirt = 0;
						shirt_quality = 0;
						shirt_metadata = new byte[0];
						goto IL_37C;
					IL_32B:
						this.process_items_by_type_or_id(player, PlayerInventory.SHIRT, permissions, !permissions.Contains(cfg.Slots.Shirt), false);
					}
				IL_37C:
					if (pants > 0) {
						bool flag3;
						bool flag4;
						this.permissions_check_for_item_by_type_or_id(pants, permissions, out flag3, out flag4);
						if (flag4) {
							goto IL_4F6;
						}
						else if (permissions.Contains(cfg.Clothes.Pants)) {
							goto IL_4F6;
						}
						list.AddRange(this.process_items_by_type_or_id(player, PlayerInventory.PANTS, permissions, true, true));
						if (!flag3) {
							ItemManager.dropItem(new Item(pants, 1, pants_quality, pants_metadata), point, false, true, true);
						}
						pants = 0;
						pants_quality = 0;
						pants_metadata = new byte[0];
						goto IL_545;
					IL_4F6:
						this.process_items_by_type_or_id(player, PlayerInventory.PANTS, permissions, !permissions.Contains(cfg.Slots.Pants), false);
					}
				IL_545:
					if (hat > 0) {
						bool flag5;
						bool flag6;
						this.permissions_check_for_item_by_type_or_id(hat, permissions, out flag5, out flag6);
						if (!flag6) { // was if flag6
							if (permissions.Contains(cfg.Clothes.Hat)) {
								goto IL_687;
							}
						}
						if (!flag5) {
							ItemManager.dropItem(new Item(hat, 1, hat_quality, hat_metadata), point, false, true, true);
						}
						hat = 0;
						hat_quality = 0;
						hat_metadata = new byte[0];
					}
				IL_687:
					if (backpack > 0) {
						bool flag7;
						bool flag8;
						this.permissions_check_for_item_by_type_or_id(backpack, permissions, out flag7, out flag8);
						if (!flag8) {
							if (!permissions.Contains(cfg.Clothes.Backpack)) {
								goto IL_729;
							}
						}
						this.process_items_by_type_or_id(player, PlayerInventory.BACKPACK, permissions, !permissions.Contains(cfg.Slots.Backpack), false);
						goto IL_84D;
					IL_729:
						list.AddRange(this.process_items_by_type_or_id(player, PlayerInventory.BACKPACK, permissions, true, true));
						if (!flag7) {
							ItemManager.dropItem(new Item(backpack, 1, backpack_quality, backpack_metadata), point, false, true, true);
						}
						backpack = (ushort)0;
						backpack_quality = (byte)0;
						backpack_metadata = new byte[0];
					}
				IL_84D:
					if (vest > 0) {
						bool flag9;
						bool flag10;
						this.permissions_check_for_item_by_type_or_id(vest, permissions, out flag9, out flag10);
						if (!flag10) {
							if (!permissions.Contains(cfg.Clothes.Vest)) {
								goto IL_8F1;
							}
						}
						this.process_items_by_type_or_id(player, PlayerInventory.VEST, permissions, !permissions.Contains(cfg.Slots.Vest), false);
						goto IL_A27;
					IL_8F1:
						list.AddRange(this.process_items_by_type_or_id(player, PlayerInventory.VEST, permissions, true, true));
						if (!flag9) {
							ItemManager.dropItem(new Item(vest, 1, vest_quality, vest_metadata), point, false, true, true);
						}
						vest = (ushort)0;
						vest_quality = (byte)0;
						vest_metadata = new byte[0];
					}
				IL_A27:
					if (mask > 0) {
						bool flag11;
						bool flag12;
						this.permissions_check_for_item_by_type_or_id(mask, permissions, out flag11, out flag12);
						if (!flag12) {
							if (permissions.Contains(cfg.Clothes.Mask)) {
								goto IL_B6E;
							}
						}
						if (!flag11) {
							ItemManager.dropItem(new Item(mask, 1, mask_quality, mask_metadata), point, false, true, true);
						}
						mask = (ushort)0;
						mask_quality = (byte)0;
						mask_metadata = new byte[0];
					}
				IL_B6E:
					if (glasses > 0) {
						bool flag13;
						bool flag14;
						this.permissions_check_for_item_by_type_or_id(glasses, permissions, out flag13, out flag14);
						if (!flag14) {
							if (permissions.Contains(cfg.Clothes.Glasses)) { // was !permissions
								goto IL_CBA;
							}
						}
						if (!flag13) {
							ItemManager.dropItem(new Item(glasses, (byte)1, glasses_quality, glasses_metadata), point, false, true, true);
						}
						glasses = (ushort)0;
						glasses_quality = (byte)0;
						glasses_metadata = new byte[0];
					}
				IL_CBA:
					clothing.updateClothes(shirt, shirt_quality, shirt_metadata, pants, pants_quality, pants_metadata, hat, hat_quality, hat_metadata, backpack, backpack_quality, backpack_metadata, vest, vest_quality, vest_metadata, mask, mask_quality, mask_metadata, glasses, glasses_quality, glasses_metadata);
					for (int i = 0; i < cfg.Items.Count; i++) {
						XmlItem xmlItem = cfg.Items[i];
						if (permissions.Contains(xmlItem.Spawn)) {
							ItemManager.dropItem(new Item(xmlItem.ID, true), point, false, true, true);
						}
					}
					if (list.Count > 0) {
						if (!Plugin.items_to_save_dict.ContainsKey(steamID)) {
							Plugin.items_to_save_dict.Add(steamID, list);
						}
						else {
							Plugin.items_to_save_dict[steamID] = list;
						}
					}
				//}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000066AC File Offset: 0x000048AC
		private List<Item> process_items_by_type_or_id(Player player, byte page, string[] permissions, bool drop_item_from_inventory, bool remove_item_on_save)
		{
			List<Item> list = new List<Item>();
			Vector3 point = player.transform.position + Vector3.up;
			for (int num = (int)(player.inventory.items[(int)page].getItemCount() - 1); num > -1; num--)
			{
				Item item = player.inventory.items[(int)page].getItem((byte)num).item;
				bool remove;
				bool save;
				this.permissions_check_for_item_by_type_or_id(item.id, permissions, out remove, out save);
				if (save)
				{
					list.Add(item);
					if (remove_item_on_save)
					{
						player.inventory.items[(int)page].removeItem((byte)num);
					}
				}
				else if (!remove)
				{
					if (drop_item_from_inventory)
					{
						ItemManager.dropItem(item, point, false, true, true);
						player.inventory.items[(int)page].removeItem((byte)num);
					}
				}
				else
				{
					player.inventory.items[(int)page].removeItem((byte)num);
				}
			}
			return list;
		}

		private void permissions_check_for_item_by_type_or_id(ushort item_id, string[] permissions, out bool remove, out bool save) {
			remove = false;
			save = false;
			for (int i = 0; i < base.Configuration.Instance.Items.Count; i++) {
				XmlItem xmlItem = base.Configuration.Instance.Items[i];
				if (xmlItem.ID == item_id) {
					if (!remove) {
						if (!permissions.Contains(xmlItem.Remove)) {
							goto IL_E1;
						}
					}
					remove = true;
					return;
				IL_E1:
					if (save) {
						goto IL_147;
					}
					else if (!permissions.Contains(xmlItem.Save)) {
						goto IL_147;
					}
					save = true;
				}
			IL_147:;
			}
			ItemAsset itemAsset = Assets.find(EAssetType.ITEM, item_id) as ItemAsset;
			if (itemAsset != null) {
				for (int j = 0; j < base.Configuration.Instance.Types.Count; j++) {
					XmlType xmlType = base.Configuration.Instance.Types[j];
					if (xmlType.ID.ToLower() == itemAsset.type.ToString().ToLower()) {
						if (!remove) {
							if (!permissions.Contains(xmlType.Remove)) {
								goto IL_280;
							}
						}
						remove = true;
						break;
					IL_280:
						if (!save) {
							if (!permissions.Contains(xmlType.Save)) {
								goto IL_2EA;
							}
						}
						save = true;
					}
				IL_2EA:;
				}
				return;
			}
		}

		//// Token: 0x0600005E RID: 94 RVA: 0x000067AC File Offset: 0x000049AC
		//private void permissions_check_for_item_by_type_or_id(ushort item_id, string[] permissions, out bool remove, out bool save)
		//{
		//	reversed.permissions_check_for_item_by_type_or_id(item_id, permissions, out remove, out save);
		//}

		// Token: 0x04000047 RID: 71
		public static Plugin Instance;

		// Token: 0x04000048 RID: 72
		//internal static List<CSteamID> idk_what_is_this;

		// Token: 0x04000049 RID: 73
		private static Dictionary<CSteamID, List<Item>> items_to_save_dict;

		// Token: 0x02000014 RID: 20
		[CompilerGenerated]
		[Serializable]
		private sealed class lambda
		{
			// Token: 0x06000063 RID: 99
			internal string lambda_get_permission_name(Permission perm)
			{
				return perm.Name;
			}

			// Token: 0x0400004A RID: 74
			public static readonly Plugin.lambda lambda_instance = new Plugin.lambda();

			// Token: 0x0400004B RID: 75
			public static Func<Permission, string> lambda_callback;
		}
	}
}
