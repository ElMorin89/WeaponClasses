using BepInEx;
using HarmonyLib;
using WeaponClasses.Cards;
using UnboundLib.Cards;
using Photon.Pun;
using Jotunn.Utils;
using UnityEngine;
using ModsPlus;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using BepInEx.Configuration;
using UnboundLib.Utils.UI;
using System.Collections.Generic;
using System.Linq;
using UnboundLib;
using RarityLib.Utils;
using System.Net.NetworkInformation;
using Photon.Compression;
using UnboundLib.GameModes;
using System.Collections;
using System;
using UnboundLib.Utils;
using Photon.Realtime;
using System.Reflection;
using System.Data;

namespace WeaponClasses
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.classes.manager.reborn", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.rarity.lib", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.cardtheme.lib", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.CrazyCoders.Rounds.RarityBundle", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willis.rounds.modsplus", BepInDependency.DependencyFlags.HardDependency)]

    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]


    public class WeaponClasses : BaseUnityPlugin
    {
        private const string ModId = "morino.rounds.WeaponClasses";
        private const string ModName = "WeaponClasses";
        public const string Version = "0.1.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "MWC";
        public const string TestModName = "Test Cards";
        public const string TestModInitials = "MTC";
        public const string GlobalModName = "Global Cards";
        public const string GlobalModInitials = "MGC";

        public static WeaponClasses instance;

        public const bool testCards = true;

        void Start()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
            instance = this;

            // test Cards
            if (testCards)
            {
                CustomCard.BuildCard<AddAttackSpeed>();
                CustomCard.BuildCard<RemoveAttackSpeed>();
                CustomCard.BuildCard<AddDrag>();
                CustomCard.BuildCard<RemoveDrag>();
                CustomCard.BuildCard<AddDestroyBulletAfter>();
                CustomCard.BuildCard<RemoveDestroyBulletAfter>();
                CustomCard.BuildCard<AddProjectileSpeed>();
                CustomCard.BuildCard<RemoveProjectileSpeed>();
                CustomCard.BuildCard<AddProjectielSimulatonSpeed>();
                CustomCard.BuildCard<RemoveProjectielSimulatonSpeed>();
                CustomCard.BuildCard<AddRecoil>();
                CustomCard.BuildCard<RemoveRecoil>();
            }

            // General Cards
            //CustomCard.BuildCard<EvasiveManeuvers>();
            CustomCard.BuildCard<CommonMoreDamage>();
            CustomCard.BuildCard<UncommonMoreDamage>();
            CustomCard.BuildCard<RareMoreDamage>();
            CustomCard.BuildCard<CommonReloadSpeed>();
            CustomCard.BuildCard<UncommonReloadSpeed>();
            CustomCard.BuildCard<RareReloadSpeed>();

            // Pistol Class
            //CustomCard.BuildCard<PistolCard>((card) => { PistolCard.card = card; });
            //CustomCard.BuildCard<PistolAmmoProcessing>((card) => { PistolAmmoProcessing.card = card; });
            //CustomCard.BuildCard<PistolAutomaticFire>((card) => { PistolAutomaticFire.card = card; });
            //CustomCard.BuildCard<PistolMoreAmmo>((card) => { PistolMoreAmmo.card = card; });
            CustomCard.BuildCard<PistolCard0>((card) => { PistolCard0.card = card; });
            CustomCard.BuildCard<PistolCard0Upgrade0>((card) => { PistolCard0Upgrade0.card = card; });
            CustomCard.BuildCard<PistolCard0Upgrade1>((card) => { PistolCard0Upgrade1.card = card; });
            CustomCard.BuildCard<PistolCard0Upgrade2>((card) => { PistolCard0Upgrade2.card = card; });
            CustomCard.BuildCard<PistolCard1>((card) => { PistolCard1.card = card; });


            // Shotgun Class
            //CustomCard.BuildCard<ShotgunCard>((card) => { ShotgunCard.card = card; });
            //CustomCard.BuildCard<ShotgunAutomaticFire>((card) => { ShotgunAutomaticFire.card = card; });
            //CustomCard.BuildCard<ShotgunBetterSlug>((card) => { ShotgunBetterSlug.card = card; });
            //CustomCard.BuildCard<ShotgunLongerBarrel>((card) => { ShotgunLongerBarrel.card = card; });
            //CustomCard.BuildCard<ShotgunMagazineExtender>((card) => { ShotgunMagazineExtender.card = card; });
            CustomCard.BuildCard<ShotgunCard0>((card) => { ShotgunCard0.card = card; });
            CustomCard.BuildCard<ShotgunCard0Upgrade0>((card) => { ShotgunCard0Upgrade0.card = card; });
            CustomCard.BuildCard<ShotgunCard0Upgrade1>((card) => { ShotgunCard0Upgrade1.card = card; });
            CustomCard.BuildCard<ShotgunCard0Upgrade2>((card) => { ShotgunCard0Upgrade2.card = card; });
            CustomCard.BuildCard<ShotgunCard1>((card) => { ShotgunCard1.card = card; });


            // SMG Class
            CustomCard.BuildCard<SMGCard>((card) => { SMGCard.card = card; });
            CustomCard.BuildCard<SMGMoreAmmo>((card) => { SMGMoreAmmo.card = card; });
        }
    }

}