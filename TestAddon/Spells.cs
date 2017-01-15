using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace TestAddon
{
    internal static class Spells
    {
        public static Spell.Skillshot Q;
        public static Spell.Targeted W;
        public static Spell.Targeted E;
        public static Spell.Active R;

        public static void InitializeSpells()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 1700, SkillShotType.Linear);
            W = new Spell.Targeted(SpellSlot.W, 600);
            E = new Spell.Targeted(SpellSlot.E, 800);
            R = new Spell.Active(SpellSlot.R, 725);
        }
    }
}
