using UnityEngine;
using Assets.Scripts.Settings;

public class SinglePlayerController : MonoBehaviour
{
    public GameObject Vessel;
    public GameObject Follower;
    public Camera MainCamera;
    public float sensivity = 1000f;
    public float zoomSpeed = 10f;
    public float minFov = 10f;
    public float maxFov = 60f;

    private Spacecraft mSpacecraft;

    void Start()
    {
        mSpacecraft = Vessel.GetComponent<Spacecraft>();
    }

    void Update()
    {
        VesselControl();
        CameraMovement();
        CameraZoom();
    }

    void VesselControl()
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

    void CameraMovement()
    {
        if (Input.GetMouseButton(2))
        {
            float rotX = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
            float rotY = Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;

            Follower.transform.Rotate(Vector3.up, -rotX, Space.World);
            Follower.transform.Rotate(Vector3.right, rotY, Space.Self);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetMouseButtonUp(2))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void CameraZoom() {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0.0f)
        {
            float fov = MainCamera.fieldOfView;
            fov -= scroll * zoomSpeed;
            fov = Mathf.Clamp(fov, minFov, maxFov);
            MainCamera.fieldOfView = fov;
        }
    }
}
