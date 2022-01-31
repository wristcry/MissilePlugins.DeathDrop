using System;
using System.Collections.Generic;
using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace DeathDrop
{
	// Token: 0x0200000D RID: 13
	public class Command : IRocketCommand
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004DC8 File Offset: 0x00002FC8
		public AllowedCaller AllowedCaller
		{
			get
			{
				return (AllowedCaller)<Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<int>(2139307240U, 2354278305U);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00004DEC File Offset: 0x00002FEC
		public string Name
		{
			get
			{
				return <Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<string>(2068966951U, 2802604010U);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00004E10 File Offset: 0x00003010
		public string Help
		{
			get
			{
				return <Module>.this.\u0020/\u0020XmlTextReader.NamespaceURI<string>(3929434443U, 2733405084U);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00004E34 File Offset: 0x00003034
		public string Syntax
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004E48 File Offset: 0x00003048
		public List<string> Aliases
		{
			get
			{
				return new List<string> { <Module>.int\u0020<=\u0020DateTime.AddMonths<string>(1349494895U, 2565718051U) };
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00004E78 File Offset: 0x00003078
		public List<string> Permissions
		{
			get
			{
				return new List<string>();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004E8C File Offset: 0x0000308C
		public void Execute(IRocketPlayer iRPlayer, string[] args)
		{
			UnturnedPlayer unturnedPlayer = iRPlayer as UnturnedPlayer;
			if (args.Length > <Module>.int\u0020<=\u0020DateTime.AddMonths<int>(1389783845U, 109185081U))
			{
				string text = args[<Module>.BitConverter.ToInt32(array)\u0020\u0020|\u0020\u0020NameObjectCollectionBase.BaseHasKeys<int>(1338601139U, 0U)].ToLower();
				if (!(text == <Module>.int\u0020<=\u0020DateTime.AddMonths<string>(2469034914U, 0U)) && !(text == <Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<string>(2791007330U, 2926255093U)) && !(text == <Module>.unchecked\u0020&&\u0020Hashtable.comparer<string>(4232129811U, 3935303709U)))
				{
					if (!(text == <Module>.int\u0020<=\u0020DateTime.AddMonths<string>(255033192U, 3607889682U)))
					{
						goto IL_1F9;
					}
				}
				else if (<Module>.unchecked\u0020&&\u0020Hashtable.comparer<int>(4006892935U, 1041731731U + 465U) == 0)
				{
					goto IL_1F9;
				}
				if ((Plugin.idk_what_is_this.Contains(unturnedPlayer.CSteamID) ? 1 : 0) != <Module>.BitConverter.ToInt32(array)\u0020\u0020|\u0020\u0020NameObjectCollectionBase.BaseHasKeys<int>(2956366891U, 2338454000U))
				{
					ChatManager.say(unturnedPlayer.CSteamID, Plugin.Instance.Translate(<Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<string>(4073485688U + 340U, 3972830279U + 609U), new object[<Module>.BitConverter.ToInt32(array)\u0020\u0020|\u0020\u0020NameObjectCollectionBase.BaseHasKeys<int>(2956366891U, 0U)]), Color.red, <Module>.unchecked\u0020&&\u0020Hashtable.comparer<int>(523780740U, 2185559643U) != 0);
					return;
				}
				Plugin.idk_what_is_this.Add(unturnedPlayer.CSteamID);
				ChatManager.say(unturnedPlayer.CSteamID, Plugin.Instance.Translate(<Module>.int\u0020<=\u0020DateTime.AddMonths<string>(0U, 704912573U), new object[<Module>.this.\u0020/\u0020XmlTextReader.NamespaceURI<int>(1387821648U + 115U, 3385879623U)]), Color.green, <Module>.int\u0020<=\u0020DateTime.AddMonths<int>(2905183451U, 0U) != 0);
				return;
				IL_1F9:
				if (!(text == <Module>.unchecked\u0020&&\u0020Hashtable.comparer<string>(2576997927U, 2929929292U)) && !(text == <Module>.this.\u0020/\u0020XmlTextReader.NamespaceURI<string>(210775170U, 3254587024U)) && !(text == <Module>.unchecked\u0020&&\u0020Hashtable.comparer<string>(2262723107U, 1658485396U)))
				{
					if (text == <Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<string>(0U, 1925427127U))
					{
						goto IL_31A;
					}
				}
				else if (<Module>.this.\u0020/\u0020XmlTextReader.NamespaceURI<int>(286260858U, 1688859446U) != 0)
				{
					goto IL_31A;
				}
				CSteamID csteamID = unturnedPlayer.CSteamID;
				RocketPlugin instance = Plugin.Instance;
				string translationKey = <Module>.int\u0020<=\u0020DateTime.AddMonths<string>(0U, 1973655219U + 934U);
				object[] array = new object[<Module>.this.\u0020/\u0020XmlTextReader.NamespaceURI<int>(4008706438U, 2280737468U)];
				array[<Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<int>(0U, 1503247983U)] = text;
				ChatManager.say(csteamID, instance.Translate(translationKey, array), Color.red, <Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<int>(1621193781U, 3725670975U) != 0);
				return;
				IL_31A:
				if (Plugin.idk_what_is_this.Contains(unturnedPlayer.CSteamID))
				{
					Plugin.idk_what_is_this.Remove(unturnedPlayer.CSteamID);
					ChatManager.say(unturnedPlayer.CSteamID, Plugin.Instance.Translate(<Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<string>(969493691U, 3631101588U), new object[<Module>.BitConverter.ToInt32(array)\u0020\u0020|\u0020\u0020NameObjectCollectionBase.BaseHasKeys<int>(2956366891U, 4129021157U)]), Color.green, <Module>.int\u0020<=\u0020DateTime.AddMonths<int>(2905183451U, 578569929U) != 0);
				}
				else
				{
					ChatManager.say(unturnedPlayer.CSteamID, Plugin.Instance.Translate(<Module>.BitConverter.ToInt32(array)\u0020\u0020|\u0020\u0020NameObjectCollectionBase.BaseHasKeys<string>(334405623U + 414U, 4099609888U), new object[<Module>.this.\u0020/\u0020XmlTextReader.NamespaceURI<int>(2907145763U, 584589356U + 669U)]), Color.red, <Module>.object\u0020objectValue\u0020=\u0020System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(\u0020??\u0020XmlReader.ReadContentAsString<int>(2673773515U, 1534746268U) != 0);
				}
			}
			else
			{
				ChatManager.say(unturnedPlayer.CSteamID, Plugin.Instance.Translate(<Module>.int\u0020<=\u0020DateTime.AddMonths<string>(3871749449U, 3526506595U), new object[<Module>.int\u0020<=\u0020DateTime.AddMonths<int>(2905183451U, 1643658818U)]), Color.red, <Module>.int\u0020<=\u0020DateTime.AddMonths<int>(2905183451U, 520475751U) != 0);
			}
		}
	}
}
