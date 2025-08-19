using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Settings;

public class InputControl : MonoBehaviour
{
    public MainMenuSettingsController mainMenuSettingsController;
    public ControlAction rebindAction;

    private TMP_InputField mInputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mInputField = GetComponent<TMP_InputField>();

        //Turning off the arrow field switch
        Navigation nav = mInputField.navigation;
        nav.mode = Navigation.Mode.None;
        mInputField.navigation = nav;
    }

    // Update is called once per frame
    void Update()
    {
        if(mInputField.isFocused)
        {
            foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    mainMenuSettingsController.RebindControl(rebindAction, keyCode);
                    mInputField.text = keyCode.ToString();
                    mInputField.DeactivateInputField();
                    break;
                }
            }
        }
    }
}
