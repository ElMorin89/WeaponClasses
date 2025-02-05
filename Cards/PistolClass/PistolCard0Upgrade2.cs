using System.Reflection;
using UnityEngine;
using RarityLib.Utils;
using ModsPlus;
using UnboundLib;
//using KFC.MonoBehaviors;
using WeaponClasses.Cards;
using System.Linq;
using System.Collections.Generic;
using System;
using ClassesManagerReborn.Util;

namespace WeaponClasses.Cards
{
    public class PistolCard0Upgrade2 : SimpleCard
    {
        internal static CardInfo card = null;
        public override void Callback()
        {
            gameObject.GetOrAddComponent<ClassNameMono>().className = PistolClass.name;
        }
        public override CardDetails Details => new CardDetails
        {
            Title = "Tactical Trigger",
            Description = "Glock 17 - Increase Fire Rate",
            ModName = WeaponClasses.ModInitials,
            //Art = KFC.ArtAssets.LoadAsset<GameObject>("C_RiftWalker"),
            Rarity = RarityUtils.GetRarity("Common"),
            Theme = CardThemeColor.CardThemeColorType.ColdBlue,
            Stats = new[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "attackSpeed",
                    amount = "-0.25%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            }
        };
        protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.attackSpeed *= 0.75f;
        }
    }
}