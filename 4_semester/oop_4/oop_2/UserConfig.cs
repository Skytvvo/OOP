using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class UserConfig
    {
        public string Background { get; set; }
        public Font FontType { get; set; }
        public int FontSize { get; set; }

    }

    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public UserConfig config;

        private Singleton()
        {
            config = new UserConfig { 
                Background= "#E0E0E0",
                FontType = new Font("Arial", 12.0f),
                FontSize= 14 
            };
        }

        public static Singleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
