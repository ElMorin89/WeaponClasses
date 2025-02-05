using ClassesManagerReborn;
using System.Collections;
using UnboundLib.Cards;

namespace WeaponClasses.Cards
{
    internal class ShotgunClass : ClassHandler
    {
        internal static string name = "Shotgun";

        public override IEnumerator Init()
        {
            //while (!(ShotgunCard.card && ShotgunLongerBarrel.card)) yield return null;
            //ClassesRegistry.Register(ShotgunCard.card, CardType.Entry, 1);
            //ClassesRegistry.Register(ShotgunAutomaticFire.card, CardType.Card, ShotgunCard.card, 1);
            //ClassesRegistry.Register(ShotgunBetterSlug.card, CardType.Card, ShotgunCard.card, 0);
            //ClassesRegistry.Register(ShotgunLongerBarrel.card, CardType.Card, ShotgunCard.card, 5);
            //ClassesRegistry.Register(ShotgunMagazineExtender.card, CardType.Card, ShotgunCard.card, 0);

            while (!(ShotgunCard0.card && ShotgunCard0Upgrade0.card && ShotgunCard0Upgrade1.card && ShotgunCard0Upgrade2.card && ShotgunCard1.card)) yield return null;
            ClassesRegistry.Register(ShotgunCard0.card, CardType.Entry, 1);
            ClassesRegistry.Register(ShotgunCard0Upgrade0.card, CardType.Card, ShotgunCard0.card, 1);
            ClassesRegistry.Register(ShotgunCard0Upgrade1.card, CardType.Card, ShotgunCard0.card, 1);
            ClassesRegistry.Register(ShotgunCard0Upgrade2.card, CardType.Card, ShotgunCard0.card, 1);
            ClassesRegistry.Register(ShotgunCard1.card, CardType.Card, new CardInfo[][]
            {
                new CardInfo[] { ShotgunCard0Upgrade0.card, ShotgunCard0Upgrade1.card, ShotgunCard0Upgrade2.card }
            }, 1);
        }
    }
}