﻿using System.Reflection;
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
    public class ShotgunCard0Upgrade0 : SimpleCard
    {
        internal static CardInfo card = null;
        public override void Callback()
        {
            gameObject.GetOrAddComponent<ClassNameMono>().className = ShotgunClass.name;
        }
        public override CardDetails Details => new CardDetails
        {
            Title = "Ported Barrel",
            Description = "Mossberg 500 - Reduce Spread",
            ModName = WeaponClasses.ModInitials,
            //Art = KFC.ArtAssets.LoadAsset<GameObject>("C_RiftWalker"),
            Rarity = RarityUtils.GetRarity("Common"),
            Theme = CardThemeColor.CardThemeColorType.ColdBlue,
            Stats = new[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Spread",
                    amount = "-25%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            }
        };
        protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.spread *= 0.75f;
        }
    }
}