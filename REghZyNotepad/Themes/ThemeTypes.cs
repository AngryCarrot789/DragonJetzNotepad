﻿namespace REghZyNotepad.Themes {
    public enum ThemeType
    {
        Dark,
        Red,
        Light,
    }

    public static class ThemeTypeExtension
    {
        public static string GetName(this ThemeType type)
        {
            switch (type)
            {
                case ThemeType.Light: return "LightTheme";
                case ThemeType.Dark: return "VeryDarkTheme";
                case ThemeType.Red: return "RedBlackTheme";
                default: return null;
            }
        }
    }
}
