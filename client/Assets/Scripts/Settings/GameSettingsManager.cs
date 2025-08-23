using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Settings
{
    public class GameSettingsManager
    {
        public static GameSettings gameSettings;

        private static string settingPath = Application.persistentDataPath + "/settings.json";

        public static void LoadSettings()
        {
            gameSettings = GameSettings.Load(settingPath);
        }

        public static void SaveSettings()
        {
            GameSettings.Save(gameSettings, settingPath);
        }
    }
}
