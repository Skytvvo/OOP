using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_2.BehaviorPattern;

namespace oop_2
{
    public class WhiteTheme : IUserConfig
    {
        public Color Background { get => Color.Gray; }
        public Font FontType { get => new Font("Arial", 12.0f); }

        public int FontSize { get => 14; }
    }

    public class DarkTheme : IUserConfig
    {
        public Color Background => Color.Black;

        public Font FontType => new Font("Arial", 12.0f);

        public int FontSize => 14;
    }

    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public IUserConfig config;

        private Singleton()
        {
            config = new WhiteTheme();
        }

        public static void ChangeTheme(IUserConfig sconfig)
        {
            lazy.Value.config = sconfig;
        }

        public static Singleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
