using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace TestAddon
{
    internal class Menus
    {
        public static Menu FirstMenu;
        public static Menu ComboMenu;
        public static Menu DrawingMenu;

        public static void CreateMenu()
        {
            FirstMenu = MainMenu.AddMenu(Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "Helper");

            ComboMenu = FirstMenu.AddSubMenu("Combo");
            DrawingMenu = FirstMenu.AddSubMenu("Drawings");

            ComboMenu.AddGroupLabel("Combo Settings");
            ComboMenu.Add("Q", new CheckBox("Use Q"));
            ComboMenu.Add("W", new CheckBox("Use W"));
            ComboMenu.Add("E", new CheckBox("Use E"));
            ComboMenu.Add("R", new CheckBox("Use R"));
            ComboMenu.Add("REnemies", new Slider("Enemies in range to use ult",3,1,5));
            ComboMenu.Add("HPPercent", new Slider("Cast ult when under certain HP percentage",30,10,100));


            DrawingMenu.AddGroupLabel("Drawings Settings");
            DrawingMenu.Add("Q", new CheckBox("Use Q"));
            DrawingMenu.Add("W", new CheckBox("Use W"));
            DrawingMenu.Add("E", new CheckBox("Use E"));
            DrawingMenu.Add("R", new CheckBox("Use R"));
        }
    }
}
