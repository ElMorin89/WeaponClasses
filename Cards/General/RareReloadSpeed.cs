﻿using RarityLib.Utils;
using ModsPlus;

namespace WeaponClasses.Cards
{
    public class RareReloadSpeed : SimpleCard
    {
        internal static CardInfo card = null;
        public override CardDetails Details => new CardDetails
        {
            Title = "ReloadSpeed+++",
            Description = "Reload 100% Faster",
            ModName = WeaponClasses.GlobalModInitials,
            //Art = KFC.ArtAssets.LoadAsset<GameObject>("C_RiftWalker"),
            Rarity = RarityUtils.GetRarity("Rare"),
            Theme = CardThemeColor.CardThemeColorType.FirepowerYellow,
            Stats = new[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "ReloadSpeed",
                    amount = "+100%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            }
        };
        protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.reloadTime *= 0.5f;
        }
    }
}