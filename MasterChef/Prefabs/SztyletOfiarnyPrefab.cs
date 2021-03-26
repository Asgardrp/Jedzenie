using System;
using JotunnLib.Entities;
using JotunnLib.Utils;
using UnityEngine;

namespace Questy.Prefabs
{
	// Token: 0x02000006 RID: 6
	public class SztyletOfiarnyPrefab : PrefabConfig
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000025C9 File Offset: 0x000007C9
		public SztyletOfiarnyPrefab() : base("SztyletOfiarny", "KnifeBlackMetal")
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025E0 File Offset: 0x000007E0
		public override void Register()
		{
			ItemDrop component = base.Prefab.GetComponent<ItemDrop>();
			component.m_itemData.m_shared.m_itemType = 0;
			component.m_itemData.m_shared.m_name = "Event | Sztylet ofiarny";
			component.m_itemData.m_shared.m_description = "Sztylet wykonany z czarnego metalu, na ostrzu widać zaschniętą krew ofiar.";
			component.m_itemData.m_dropPrefab = base.Prefab;
			component.m_itemData.m_shared.m_weight = 0.8f;
			component.m_itemData.m_shared.m_maxStackSize = 1;
			component.m_itemData.m_shared.m_variants = 1;
		}
	}
}
