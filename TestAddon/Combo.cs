using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using static TestAddon.Menus;


namespace TestAddon
{
    internal class Combo
    {
        public static void ComboExecute()
        {
            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Magical);
            if ((target == null) || target.IsInvulnerable) return;
            if (ComboMenu["Q"].Cast<CheckBox>().CurrentValue)
            {
                if(target.IsValidTarget(Spells.Q.Range) && Spells.Q.IsReady())
                {
                    var qhitchance = Spells.Q.GetPrediction(target);
                    if(qhitchance.HitChancePercent >= 80)
                    {
                        Spells.Q.Cast(qhitchance.CastPosition);
                        Spells.Q.Cast();
                    }
                }
            }
            if (ComboMenu["R"].Cast<CheckBox>().CurrentValue)
            {
                var enemy = EntityManager.Heroes.Enemies.FirstOrDefault(x => x.IsValidTarget(Spells.R.Range - 100) && x.IsValid);

                if (enemy.IsValidTarget(Spells.R.Range - 100) && Spells.R.IsReady()
                    && Player.Instance.CountEnemyChampionsInRange(Spells.R.Range - 100) == ComboMenu["REnemies"].Cast<Slider>().CurrentValue
                    && Player.Instance.HealthPercent <= ComboMenu["HPPercent"].Cast<Slider>().CurrentValue)
                {
                    Spells.R.Cast();
                }
            }
        }
    }
}
