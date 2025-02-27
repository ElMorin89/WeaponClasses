﻿using System.Reflection;
using UnityEngine;
//using RarityLib.Utils;
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
    public class Template : SimpleCard
    {
        internal static CardInfo card = null;
        // If it's part of a class
        //public override void Callback()
        //{
        //    gameObject.GetOrAddComponent<ClassNameMono>().className = PistolClass.name;
        //}
        public override CardDetails Details => new CardDetails
        {
            Title = "Template Name",
            Description = "Template Description",
            ModName = WeaponClasses.ModInitials,
            //Art = KFC.ArtAssets.LoadAsset<GameObject>("C_RiftWalker"),
            //Rarity = RarityUtils.GetRarity("Legendary"),
            Theme = CardThemeColor.CardThemeColorType.ColdBlue,
            Stats = new[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Statistique (White)",
                    amount = "Amount (Green | Red)",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            }
        };
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
        }
    }
}