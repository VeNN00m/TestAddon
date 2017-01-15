using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using static TestAddon.Combo;

namespace TestAddon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        public static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.Hero != Champion.Janna) return;
            Chat.Print("Welcome to my first addon, Janna lovers!");
            Game.OnTick += OnTick;
            Menus.CreateMenu();
            Spells.InitializeSpells();
        }

        public static void OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo)) ComboExecute();
        }
    }
}
