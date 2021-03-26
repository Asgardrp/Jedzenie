using System;
using BepInEx;
using JotunnLib.Entities;
using JotunnLib.Managers;
using JotunnLib.Utils;
using UnityEngine;

namespace Questy
{
	// Token: 0x0200001B RID: 27
	[BepInPlugin("hrve.Questy", "Questy", "1.0.0")]
	[BepInDependency("com.bepinex.plugins.jotunnlib", (BepInDependency.DependencyFlags)1)]
	public class Questy : BaseUnityPlugin
	{
		// Token: 0x06000033 RID: 51 RVA: 0x0000435D File Offset: 0x0000255D
		private void Awake()
		{
			ObjectManager.Instance.ObjectRegister += this.registerObjects;
			PrefabManager.Instance.PrefabRegister += this.registerPrefabs;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004390 File Offset: 0x00002590
		private void registerPrefabs(object sender, EventArgs e)
		{
			PrefabManager.Instance.RegisterPrefab(new MieczOdynaPrefab());
			PrefabManager.Instance.RegisterPrefab(new PelerynaAdminaPrefab());
			PrefabManager.Instance.RegisterPrefab(new RunaOgniaPrefab());
			PrefabManager.Instance.RegisterPrefab(new RunaSloncaPrefab());
			PrefabManager.Instance.RegisterPrefab(new RunaWodyPrefab());
			PrefabManager.Instance.RegisterPrefab(new RunaZiemiPrefab());
			PrefabManager.Instance.RegisterPrefab(new MlotThoraPrefab());
			PrefabManager.Instance.RegisterPrefab(new ArmorAdminaPrefab());
			PrefabManager.Instance.RegisterPrefab(new KapturAdminaPrefab());
			PrefabManager.Instance.RegisterPrefab(new SpodnieAdminaPrefab());
			PrefabManager.Instance.RegisterPrefab(new PierscienAzalAkiraPrefab());
			PrefabManager.Instance.RegisterPrefab(new SztyletOfiarnyPrefab());
			PrefabManager.Instance.RegisterPrefab(new OpokaHarvaldaPrefab());
			PrefabManager.Instance.RegisterPrefab(new IskraPrefab());
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004530 File Offset: 0x00002730
		private void registerObjects(object sender, EventArgs e)
		{
			ObjectManager.Instance.RegisterItem("MieczOdyna");
			ObjectManager.Instance.RegisterItem("PelerynaAdmina");
			ObjectManager.Instance.RegisterItem("RunaOgnia");
			ObjectManager.Instance.RegisterItem("RunaSlonca");
			ObjectManager.Instance.RegisterItem("RunaWody");
			ObjectManager.Instance.RegisterItem("RunaZiemi");
			ObjectManager.Instance.RegisterItem("MlotThora");
			ObjectManager.Instance.RegisterItem("ArmorAdmina");
			ObjectManager.Instance.RegisterItem("KapturAdmina");
			ObjectManager.Instance.RegisterItem("SpodnieAdmina");
			ObjectManager.Instance.RegisterItem("PierscienAzalAkira");
			ObjectManager.Instance.RegisterItem("SztyletOfiarny");
			ObjectManager.Instance.RegisterItem("OpokaHarvalda");
			ObjectManager.Instance.RegisterItem("Iskra");
		}
	}
}
