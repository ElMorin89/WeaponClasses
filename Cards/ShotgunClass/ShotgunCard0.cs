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
    public class ShotgunCard0 : SimpleCard
    {
        internal static CardInfo card = null;
        public override void Callback()
        {
            gameObject.GetOrAddComponent<ClassNameMono>().className = ShotgunClass.name;
        }
        public override CardDetails Details => new CardDetails
        {
            Title = "Mossberg 500",
            Description = "Take that shotgun",
            ModName = WeaponClasses.ModInitials,
            //Art = KFC.ArtAssets.LoadAsset<GameObject>("C_RiftWalker"),
            Rarity = RarityUtils.GetRarity("Common"),
            Theme = CardThemeColor.CardThemeColorType.EvilPurple,
            Stats = new[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "damage",
                    amount = "0.5f",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "attackSpeed",
                    amount = "0.8f",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "reloadTime",
                    amount = "2f",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "ammo",
                    amount = "4",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "numberOfProjectiles",
                    amount = "4",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "spread",
                    amount = "0.2f",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "autoFire",
                    amount = "false",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            }
        };
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.dontAllowAutoFire = true;
        }
        protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.damage = 0.5f;
            gun.attackSpeed = 0.8f;
            gun.reloadTime = 2f;
            gunAmmo.maxAmmo = 4;
            gun.numberOfProjectiles = 4;
            gun.spread = 0.2f;
            gun.projectileSpeed = 2f;
            gun.projectielSimulatonSpeed = 1f;
            gun.drag = 0f;
            gun.destroyBulletAfter = 0.15f;
        }
    }
}