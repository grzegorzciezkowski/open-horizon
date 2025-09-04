using Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Unity.VisualScripting;
using System.IO;

namespace Assets.Scripts.Settings
{
    [Serializable]
    public class Translations
    {
        public List<KeyValue> translations = new();
    }

    [System.Serializable]
    public class KeyValue
    {
        public string key;
        public string value;
    }

    public class LanguageManager
    {
        public static Dictionary<string, string> translations = new Dictionary<string, string>();

        public static void LoadTranslations(string language, string category)
        {
            string translationPath = Application.streamingAssetsPath + "\\Lang\\" + category + "." + language + ".json";
            try
            {
                var loadedTransations = JsonUtility.FromJson<Translations>(File.ReadAllText(translationPath));
                foreach (var translation in loadedTransations.translations)
                {
                    translations[translation.key] = translation.value;
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
                return;
            }
        }

        public static void UnloadTranslations()
        {
            translations = new Dictionary<string, string>();
        }
    }
}
