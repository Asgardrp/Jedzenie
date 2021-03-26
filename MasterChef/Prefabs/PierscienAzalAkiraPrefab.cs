using System;
using JotunnLib.Entities;
using JotunnLib.Utils;
using UnityEngine;

namespace Questy.Prefabs
{
	// Token: 0x02000006 RID: 6
	public class PierscienAzalAkiraPrefab : PrefabConfig
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000025C9 File Offset: 0x000007C9
		public PierscienAzalAkiraPrefab() : base("PierscienAzalAkira", "GoldRubyRing")
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025E0 File Offset: 0x000007E0
		public override void Register()
		{
			ItemDrop component = base.Prefab.GetComponent<ItemDrop>();
			component.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.Utility;
			component.m_itemData.m_shared.m_name = "Quest [Jedyny pierścień] | Pierścień Azal Akira";
			component.m_itemData.m_shared.m_description = "Złoty pierścień z rubinem średniej wielkości, pierścień wydaje się emanować ciepłem i magią";
			component.m_itemData.m_dropPrefab = base.Prefab;
			component.m_itemData.m_shared.m_weight = 0.5f;
			component.m_itemData.m_shared.m_maxStackSize = 1;
			component.m_itemData.m_shared.m_variants = 1;
		}
	}
}
