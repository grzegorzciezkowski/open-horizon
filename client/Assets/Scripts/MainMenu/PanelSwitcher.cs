using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject ActivateObj;
    public GameObject DeactivateObj;

    public void SwitchPanels()
    {
        ActivateObj.SetActive(true);
        DeactivateObj.SetActive(false);
    }
}
