using ClassesManagerReborn;
using System.Collections;
using UnboundLib.Cards;
using UnboundLib.Utils;

namespace WeaponClasses.Cards
{
    internal class PistolClass : ClassHandler
    {
        internal static string name = "Pistol";

        public override IEnumerator Init()
        {
            ClassesRegistry.Register(PistolCard.card, CardType.Entry, 1);
            //ClassesRegistry.Register(Ard.card, CardType.Card, ViruzCard.card);
            //ClassesRegistry.Register(Bard.card, CardType.Card, ViruzCard.card);
            //ClassesRegistry.Register(Ccard.card, CardType.Card, ViruzCard.card);
            yield break;
        }
    }
}
