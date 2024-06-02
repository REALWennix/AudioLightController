using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LightController
{
    public static class ColorPalettes
    {
        public static Dictionary<string, List<Color>> Palettes { get; } = new Dictionary<string, List<Color>>
        {
            {
                "blue-black", new List<Color>
                {
                    ColorTranslator.FromHtml("#0554F2"),
                    ColorTranslator.FromHtml("#076DF2"),
                    ColorTranslator.FromHtml("#3889F2"),
                    ColorTranslator.FromHtml("#F2F2F2"),
                    ColorTranslator.FromHtml("#0D0D0D"),
                    ColorTranslator.FromHtml("#262626"),
                }
            },
            {
                "blue-red", new List<Color>
                {
                    ColorTranslator.FromHtml("#3C5FA6"),
                    ColorTranslator.FromHtml("#3587F2"),
                    ColorTranslator.FromHtml("#41D958"),
                    ColorTranslator.FromHtml("#F23838"),
                    ColorTranslator.FromHtml("#402B2B")
                }
            },
        };
    }

}
