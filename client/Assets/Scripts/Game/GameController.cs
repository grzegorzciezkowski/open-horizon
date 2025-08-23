using UnityEngine;
using UnityEngine.Rendering.Universal;
using Assets.Scripts.Settings;

public class GameController : MonoBehaviour
{
    public Camera mainCamera;

    void Start()
    {
        GameSettingsManager.LoadSettings();

        var cameraData = mainCamera.GetUniversalAdditionalCameraData();
        switch (GameSettingsManager.gameSettings.graphics.antiAliasing) {
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
