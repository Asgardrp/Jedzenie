using System;
using JotunnLib.Entities;
using JotunnLib.Utils;
using UnityEngine;

namespace Questy.Prefabs
{
	// Token: 0x02000006 RID: 6
	public class MlotThoraPrefab : PrefabConfig
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000025C9 File Offset: 0x000007C9
		public MlotThoraPrefab() : base("MlotThora", "MaceSilver")
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025E0 File Offset: 0x000007E0
		public override void Register()
		{
			ItemDrop component = Prefab.GetComponent<ItemDrop>();
			component.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.OneHandedWeapon;
			component.m_itemData.m_shared.m_name = "<color=magenta><b>Unikat</b></color> | Młot Thora";
			component.m_itemData.m_shared.m_description = "Thor został pokonany w walce przez co musiał zrzucić swój młot na ziemię aby nie dostał się w ręce potężnego wroga.";
			component.m_itemData.m_dropPrefab = base.Prefab;
			component.m_itemData.m_shared.m_weight = 200f;
			component.m_itemData.m_shared.m_maxStackSize = 1;
			component.m_itemData.m_shared.m_maxDurability = 5000f;
			component.m_itemData.m_shared.m_variants = 1;
			component.m_itemData.m_shared.m_timedBlockBonus = 12f;
			component.m_itemData.m_shared.m_deflectionForce = 12f;
			component.m_itemData.m_shared.m_attackForce = 190f;
			component.m_itemData.m_shared.m_attack.m_attackStamina = 30f;
			component.m_itemData.m_shared.m_attack.m_attackAnimation = "swing_longsword";
			component.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "club_secondary";
			component.m_itemData.m_shared.m_secondaryAttack.m_attackChainLevels = 0;
			component.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 20f;
			component.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
			component.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
			component.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 0.75f;
			component.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10f;
			component.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 12f;
			component.m_itemData.m_shared.m_secondaryAttack.m_attackRange = 3.5f;
			component.m_itemData.m_shared.m_secondaryAttack.m_attackAngle = 360f;
			component.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
			component.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
			component.m_itemData.m_shared.m_damages.m_slash = 75f;
			component.m_itemData.m_shared.m_damages.m_lightning = 120f;
			Texture2D texture2D = AssetUtils.LoadTexture("Questy/Assets/mlotthora.png");
			Sprite sprite = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), Vector2.zero);
            component.m_itemData.m_shared.m_icons[0] = sprite;

		}
	}
}
