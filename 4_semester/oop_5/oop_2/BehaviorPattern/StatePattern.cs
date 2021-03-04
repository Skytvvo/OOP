using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2.BehaviorPattern
{
    public interface IUserConfig
    {
        public Color Background { get; }
        public Font FontType { get; }
        public int FontSize { get; }
    }
}
