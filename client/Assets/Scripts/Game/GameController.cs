using UnityEngine;
using UnityEngine.Rendering.Universal;
using Assets.Scripts.Settings;
using System.Collections.Generic;
using System;
using Unity.VisualScripting;
using Assets.Scripts.Game;

public class GameController : MonoBehaviour
{
    public Camera mainCamera;
    public SpacecraftAIText spacecraftAIText;
    public IncomeMessageNPC incomeMessageNPC;
    public GameObject identityProtocolPanel;
    public SinglePlayerGameInfo gameInfo;

    void Start()
    {
        GameSettingsManager.LoadSettings();
        SetCameraSettings();

        LanguageManager.UnloadTranslations();
        LanguageManager.LoadTranslations(GameSettingsManager.gameSettings.language.Lang, "GameHUD");
        LanguageManager.LoadTranslations(GameSettingsManager.gameSettings.language.Lang, "Prolog");

        spacecraftAIText.ShowMessage(LanguageManager.translations["Prolog.FirstAIWarning"], () => {
            var actions = new Dictionary<string, Action>
            {
                { LanguageManager.translations["Prolog.ActivateIdentityProtocol"], () => { 
                    incomeMessageNPC.gameObject.SetActive(false);
                    identityProtocolPanel.SetActive(true);
                } }
            };
            incomeMessageNPC.ShowIncomeTransmission(LanguageManager.translations["Prolog.FirstAdmiralMessage"], "NPC/AdmiralVeynar", actions); 
        });
    }

    public void SetPlayerInfo(string name, int gender)
    {
        gameInfo = new SinglePlayerGameInfo
        {
            Name = name,
            Gender = gender
        };
    }

    void SetCameraSettings()
    {
        var cameraData = mainCamera.GetUniversalAdditionalCameraData();
        switch (GameSettingsManager.gameSettings.graphics.antiAliasing)
        {
            case AntiAliasing.NO_ANTI_ALIASING:
                cameraData.antialiasing = AntialiasingMode.None;
                break;
            case AntiAliasing.FAST_ANTI_ALIASING:
                cameraData.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
                break;
            case AntiAliasing.FULL_ANTI_ALIASING:
                cameraData.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                cameraData.antialiasingQuality = AntialiasingQuality.High;
                break;
            default:
                cameraData.antialiasing = AntialiasingMode.None;
                break;
        }
    }
}
