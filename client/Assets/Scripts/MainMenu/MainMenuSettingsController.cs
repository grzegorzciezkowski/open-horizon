using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Settings;

public class MainMenuSettingsController : MonoBehaviour
{
    public GameSettings gameSettings;

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

    void Start()
    {
        gameSettings = GameSettings.Load(GameSettingsManager.settingPath);

        antiAliasingInput.value = (int)gameSettings.graphics.antiAliasing;
        musicVolumeInput.value = gameSettings.sounds.musicVolume;
        soundEffectVolumeInput.value = gameSettings.sounds.soundEffectsVolume;

        accelerateInput.text = gameSettings.controls.Accelerate.ToString();
        decelerateInput.text = gameSettings.controls.Decelerate.ToString();
        pullUpInput.text = gameSettings.controls.PullUp.ToString();
        pullDownInput.text = gameSettings.controls.PullDown.ToString();
        turnLeft.text = gameSettings.controls.TurnLeft.ToString();
        turnRight.text = gameSettings.controls.TurnRight.ToString();
    }

    public void SetAntiAliasing(int optionIndex)
    {
        gameSettings.graphics.antiAliasing = (AntiAliasing)optionIndex;
        GameSettings.Save(gameSettings, GameSettingsManager.settingPath);
    }

    public void SetMusicVolume(float value)
    {
        gameSettings.sounds.musicVolume = value;
        backgroundMusic.volume = value;
        GameSettings.Save(gameSettings, GameSettingsManager.settingPath);
    }

    public void SetSoundsEffectsVolume(float value)
    {
        gameSettings.sounds.soundEffectsVolume = value;
        GameSettings.Save(gameSettings, GameSettingsManager.settingPath);
    }

    public void RebindControl(ControlAction rebindAction, KeyCode key)
    {
        Debug.Log("rebind action: " + rebindAction.ToString() + " key code: " + key.ToString());
        switch (rebindAction) {
            case ControlAction.ACCELERATE:
                gameSettings.controls.Accelerate = key;
                break;
            case ControlAction.DECELERATE:
                gameSettings.controls.Decelerate = key;
                break;
            case ControlAction.PULL_UP:
                gameSettings.controls.PullUp = key;
                break;
            case ControlAction.PULL_DOWN:
                gameSettings.controls.PullDown = key;
                break;
            case ControlAction.TURN_LEFT:
                gameSettings.controls.TurnLeft = key;
                break;
            case ControlAction.TURN_RIGHT:
                gameSettings.controls.TurnRight = key;
                break;
            default:
                break;
        }

        GameSettings.Save(gameSettings, GameSettingsManager.settingPath);
    }
}
