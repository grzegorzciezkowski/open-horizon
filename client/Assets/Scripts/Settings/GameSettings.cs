using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Settings
{

    [System.Serializable]
    public class GameSettings
    {
        public GraphicsSettings graphics;
        public SoundsSettings sounds;
        public ControlsSettings controls;

        public static void Save(GameSettings data, string filePath)
        {
            Debug.Log("Save GameSettings to: " + filePath);

            string json = JsonUtility.ToJson(data);
            System.IO.File.WriteAllText(filePath, json);
        }

        public static GameSettings Load(string filePath)
        {
            Debug.Log("Load GameSettings from: " + filePath);

            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                return JsonUtility.FromJson<GameSettings>(json);
            }
            return new GameSettings();
        }
    }

    public class GameSettingsManager
    {
        public static string settingPath = Application.persistentDataPath + "/settings.json";
    }
}
