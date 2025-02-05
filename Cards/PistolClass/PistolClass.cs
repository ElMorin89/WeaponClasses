using ClassesManagerReborn;
using System.Collections;
using UnboundLib.Cards;

namespace WeaponClasses.Cards
{
    internal class PistolClass : ClassHandler
    {
        internal static string name = "Pistol";

        public override IEnumerator Init()
        {
            //while (!(PistolCard.card && PistolMoreAmmo.card)) yield return null;
            //ClassesRegistry.Register(PistolCard.card, CardType.Entry, 1);
            //ClassesRegistry.Register(PistolAmmoProcessing.card, CardType.Card, PistolCard.card, 0);
            //ClassesRegistry.Register(PistolAutomaticFire.card, CardType.Card, PistolCard.card, 1);
            //ClassesRegistry.Register(PistolMoreAmmo.card, CardType.Card, PistolCard.card, 0);

            while (!(PistolCard0.card && PistolCard0Upgrade0.card && PistolCard0Upgrade1.card && PistolCard0Upgrade2.card && PistolCard1.card)) yield return null;
            ClassesRegistry.Register(PistolCard0.card, CardType.Entry, 1);
            ClassesRegistry.Register(PistolCard0Upgrade0.card, CardType.Card, PistolCard0.card, 1);
            ClassesRegistry.Register(PistolCard0Upgrade1.card, CardType.Card, PistolCard0.card, 1);
            ClassesRegistry.Register(PistolCard0Upgrade2.card, CardType.Card, PistolCard0.card, 1);
            ClassesRegistry.Register(PistolCard1.card, CardType.Card, new CardInfo[][]
            {
                new CardInfo[] { PistolCard0Upgrade0.card, PistolCard0Upgrade1.card, PistolCard0Upgrade2.card }
            }, 1);
        }
    }
}