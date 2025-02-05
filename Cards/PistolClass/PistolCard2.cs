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
    public class PistolCard2 : SimpleCard
    {
        internal static CardInfo card = null;
        public override void Callback()
        {
            gameObject.GetOrAddComponent<ClassNameMono>().className = PistolClass.name;
        }
        public override CardDetails Details => new CardDetails
        {
            Title = "FN Five-seveN",
            Description = "Look at that glock",
            ModName = WeaponClasses.ModInitials,
            //Art = KFC.ArtAssets.LoadAsset<GameObject>("C_RiftWalker"),
            Rarity = RarityUtils.GetRarity("Rare"),
            Theme = CardThemeColor.CardThemeColorType.EvilPurple,
            Stats = new[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "damage",
                    amount = "0.7f",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "attackSpeed",
                    amount = "0.4f",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "reloadTime",
                    amount = "1.0f",
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
                    amount = "1",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "spread",
                    amount = "0f",
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
            gun.damage = 0.7f;
            gun.attackSpeed = 0.4f;
            gun.reloadTime = 1.0f;
            gunAmmo.maxAmmo = 4;
            gun.numberOfProjectiles = 1;
            gun.spread = 0f;
            gun.projectileSpeed = 1f;
            gun.projectielSimulatonSpeed = 1f;
            gun.drag = 0f;
            gun.destroyBulletAfter = 0f;
            gun.recoil = 1f;
        }
    }
}

/*
 * isReloading = false;
    damage = 1f;
    reloadTime = 1f;
    reloadTimeAdd = 0f;
    recoilMuiltiplier = 1f;
    gunAmmo.reloadTimeMultiplier = 1f;
    gunAmmo.reloadTimeAdd = 0f;
    knockback = 1f;
    attackSpeed = 0.3f;
    projectileSpeed = 1f;
    projectielSimulatonSpeed = 1f;
    gravity = 1f;
    damageAfterDistanceMultiplier = 1f;
    bulletDamageMultiplier = 1f;
    multiplySpread = 1f;
    shakeM = 1f;
    ammo = 0;
    ammoReg = 0f;
    size = 0f;
    overheatMultiplier = 0f;
    timeToReachFullMovementMultiplier = 0f;
    numberOfProjectiles = 1;
    bursts = 0;
    reflects = 0;
    smartBounce = 0;
    bulletPortal = 0;
    randomBounces = 0;
    timeBetweenBullets = 0f;
    projectileSize = 0f;
    speedMOnBounce = 1f;
    dmgMOnBounce = 1f;
    drag = 0f;
    dragMinSpeed = 1f;
    spread = 0f;
    evenSpread = 0f;
    percentageDamage = 0f;
    cos = 0f;
    slow = 0f;
    chargeNumberOfProjectilesTo = 0f;
    destroyBulletAfter = 0f;
    forceSpecificAttackSpeed = 0f;
    lockGunToDefault = false;
    unblockable = false;
    ignoreWalls = false;
    currentCharge = 0f;
    useCharge = false;
    waveMovement = false;
    teleport = false;
    spawnSkelletonSquare = false;
    explodeNearEnemyRange = 0f;
    explodeNearEnemyDamage = 0f;
    hitMovementMultiplier = 1f;
    isProjectileGun = false;
    defaultCooldown = 1f;
    attackSpeedMultiplier = 1f;
    objectsToSpawn = new ObjectsToSpawn[0];
    GetComponentInChildren<GunAmmo>().maxAmmo = 3;
    GetComponentInChildren<GunAmmo>().ReDrawTotalBullets();
    projectileColor = Color.black;
*/