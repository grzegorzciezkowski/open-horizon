using Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Unity.VisualScripting;
using System.IO;
using UnityEngine.UIElements;

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
        
        // Get translation from the key with parameters
        public static string Translate(string key, Dictionary<string, string> keyValues)
        {
            string template = translations[key];
            return replacePlaceholders(template, keyValues);
        }

        private static string replacePlaceholders(string template, Dictionary<string, string> parameters)
        {
            if (string.IsNullOrEmpty(template) || parameters == null)
                return template;

            string result = template;

            foreach (var kvp in parameters)
            {
                string placeholder = $"{{{{{kvp.Key}}}}}"; // np. {{NAME}}
                result = result.Replace(placeholder, kvp.Value);
            }

            return result;
        }
    }
}
