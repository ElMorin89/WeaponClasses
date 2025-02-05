using ClassesManagerReborn;
using System.Collections;

namespace WeaponClasses.Cards
{
    internal class SMGClass : ClassHandler
    {
        internal static string name = "SMG";

        public override IEnumerator Init()
        {
            while (!(SMGCard.card && SMGMoreAmmo.card)) yield return null;
            ClassesRegistry.Register(SMGCard.card, CardType.Entry, 1);
            ClassesRegistry.Register(SMGMoreAmmo.card, CardType.Card, SMGCard.card, 5);
        }
    }
}