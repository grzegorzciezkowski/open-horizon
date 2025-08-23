using UnityEngine;
using Assets.Scripts.Settings;

public class SinglePlayerController : MonoBehaviour
{
    public GameObject Vessel;

    private Spacecraft mSpacecraft;

    void Start()
    {
        mSpacecraft = Vessel.GetComponent<Spacecraft>();
    }

    void Update()
    {
        if (GameSettingsManager.gameSettings != null)
        {
            if (Input.GetKey(GameSettingsManager.gameSettings.controls.Accelerate))
            {
                mSpacecraft.Accelerate();
            }
            else if (Input.GetKey(GameSettingsManager.gameSettings.controls.Decelerate))
            {
                mSpacecraft.Decelerate();
            }

            if (Input.GetKey(GameSettingsManager.gameSettings.controls.TurnLeft))
            {
                mSpacecraft.TurnLeft();
            }
            else if (Input.GetKey(GameSettingsManager.gameSettings.controls.TurnRight))
            {
                mSpacecraft.TurnRight();
            }

            if (Input.GetKey(GameSettingsManager.gameSettings.controls.PullUp))
            {
                mSpacecraft.PullUp();
            }
            else if (Input.GetKey(GameSettingsManager.gameSettings.controls.PullDown))
            {
                mSpacecraft.PullDown();
            }
        }
    }
}
