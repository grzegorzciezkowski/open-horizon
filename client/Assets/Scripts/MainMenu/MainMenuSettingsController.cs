using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Settings;

public class MainMenuSettingsController : MonoBehaviour
{
    public TMP_Dropdown antiAliasingInput;

    public Slider musicVolumeInput;
    public Slider soundEffectVolumeInput;
    public AudioSource backgroundMusic;

    public TMP_InputField accelerateInput;
    public TMP_InputField decelerateInput;
    public TMP_InputField pullUpInput;
    public TMP_InputField pullDownInput;
    public TMP_InputField turnLeft;
    public TMP_InputField turnRight;

    public TMP_Dropdown languageDropdown;

    public LanguageController languageController;

    const string TRANSLATION_CATEGORY = "MainMenu";

    void Start()
    {
        Debug.Log("Main Menu Settings Controller");
        GameSettingsManager.LoadSettings();

        antiAliasingInput.value = (int)GameSettingsManager.gameSettings.graphics.antiAliasing;

        musicVolumeInput.value = GameSettingsManager.gameSettings.sounds.musicVolume;
        soundEffectVolumeInput.value = GameSettingsManager.gameSettings.sounds.soundEffectsVolume;

        accelerateInput.text = GameSettingsManager.gameSettings.controls.Accelerate.ToString();
        decelerateInput.text = GameSettingsManager.gameSettings.controls.Decelerate.ToString();
        pullUpInput.text = GameSettingsManager.gameSettings.controls.PullUp.ToString();
        pullDownInput.text = GameSettingsManager.gameSettings.controls.PullDown.ToString();
        turnLeft.text = GameSettingsManager.gameSettings.controls.TurnLeft.ToString();
        turnRight.text = GameSettingsManager.gameSettings.controls.TurnRight.ToString();

        languageDropdown.value = LanguageSettings.LangCodeToIndex(GameSettingsManager.gameSettings.language.Lang);

        LanguageManager.LoadTranslations(GameSettingsManager.gameSettings.language.Lang, TRANSLATION_CATEGORY);
        languageController.ApplyTranslations();
    }

    public void SetAntiAliasing(int optionIndex)
    {
        GameSettingsManager.gameSettings.graphics.antiAliasing = (AntiAliasing)optionIndex;
        GameSettingsManager.SaveSettings();
    }

    public void SetMusicVolume(float value)
    {
        GameSettingsManager.gameSettings.sounds.musicVolume = value;
        backgroundMusic.volume = value;
        GameSettingsManager.SaveSettings();
    }

    public void SetSoundsEffectsVolume(float value)
    {
        GameSettingsManager.gameSettings.sounds.soundEffectsVolume = value;
        GameSettingsManager.SaveSettings();
    }

    public void RebindControl(ControlAction rebindAction, KeyCode key)
    {
        Debug.Log("rebind action: " + rebindAction.ToString() + " key code: " + key.ToString());
        switch (rebindAction) {
            case ControlAction.ACCELERATE:
                GameSettingsManager.gameSettings.controls.Accelerate = key;
                break;
            case ControlAction.DECELERATE:
                GameSettingsManager.gameSettings.controls.Decelerate = key;
                break;
            case ControlAction.PULL_UP:
                GameSettingsManager.gameSettings.controls.PullUp = key;
                break;
            case ControlAction.PULL_DOWN:
                GameSettingsManager.gameSettings.controls.PullDown = key;
                break;
            case ControlAction.TURN_LEFT:
                GameSettingsManager.gameSettings.controls.TurnLeft = key;
                break;
            case ControlAction.TURN_RIGHT:
                GameSettingsManager.gameSettings.controls.TurnRight = key;
                break;
            default:
                break;
        }

        GameSettingsManager.SaveSettings();
    }

    public void SetLanguage()
    {
        int optionIndex = languageDropdown.value;
        GameSettingsManager.gameSettings.language.Lang = LanguageSettings.IndexToLangCode(optionIndex);
        GameSettingsManager.SaveSettings();
        LanguageManager.LoadTranslations(GameSettingsManager.gameSettings.language.Lang, TRANSLATION_CATEGORY);
        languageController.ApplyTranslations();
    }
}
