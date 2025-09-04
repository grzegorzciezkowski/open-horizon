using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Settings
{
    [System.Serializable]
    public class LanguageSettings
    {
        const string ENGLISH_LANG = "en";
        const string SPANISH_LANG = "es";
        const string POLISH_LANG = "pl";

        public string Lang = ENGLISH_LANG;

        public static string IndexToLangCode(int index)
        {
            return index switch
            {
                0 => ENGLISH_LANG,
                1 => SPANISH_LANG,
                2 => POLISH_LANG,
                _ => ENGLISH_LANG,
            };
        }

        public static int LangCodeToIndex(string lang)
        {
            return lang switch
            {
                ENGLISH_LANG => 0,
                SPANISH_LANG => 1,
                POLISH_LANG => 2,
                _ => 0,
            };
        }
    }
}
