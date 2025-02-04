﻿using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using WeaponClasses.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace WeaponClasses
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.classes.manager.reborn", BepInDependency.DependencyFlags.HardDependency)]

    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]


    public class WeaponClasses : BaseUnityPlugin
    {
        private const string ModId = "morino.rounds.WeaponClasses";
        private const string ModName = "WeaponClasses";
        public const string Version = "0.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "MWC";


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<EvasiveManeuvers>();
            CustomCard.BuildCard<PistolCard>();
        }
        public static WeaponClasses instance { get; private set; }
    }

}