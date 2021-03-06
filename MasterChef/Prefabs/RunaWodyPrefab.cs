using System;
using JotunnLib.Entities;
using JotunnLib.Utils;
using UnityEngine;

namespace Questy.Prefabs
{
	// Token: 0x02000006 RID: 6
	public class RunaWodyPrefab : PrefabConfig
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000025C9 File Offset: 0x000007C9
		public RunaWodyPrefab() : base("RunaWody", "DragonTear")
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025E0 File Offset: 0x000007E0
		public override void Register()
		{
			ItemDrop component = base.Prefab.GetComponent<ItemDrop>();
			component.m_itemData.m_shared.m_itemType = 0;
			component.m_itemData.m_shared.m_name = "<color=yellow>Quest</color> | Runa Wody";
			component.m_itemData.m_shared.m_description = "Runa Raidho  – reise, endring, rytme, åpenhet;. Vannelement Rune";
			component.m_itemData.m_dropPrefab = base.Prefab;
			component.m_itemData.m_shared.m_weight = 150f;
			component.m_itemData.m_shared.m_maxStackSize = 1;
			component.m_itemData.m_shared.m_variants = 1;
			Texture2D texture2D = AssetUtils.LoadTexture("Questy/Assets/runawody.png");
			Sprite sprite = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), Vector2.zero);
			component.m_itemData.m_shared.m_icons[0] = sprite;
		}
	}
}
