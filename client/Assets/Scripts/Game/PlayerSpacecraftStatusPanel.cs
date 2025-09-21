using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerSpacecraftStatusPanel : MonoBehaviour
{
    public RectTransform speedBar;
    public TMPro.TMP_Text speedValue;
    public Spacecraft playerSpacecraft;

    // Update is called once per frame
    void Update()
    {
        float speedScale = playerSpacecraft.Speed / playerSpacecraft.MaximumSpeed;
        speedBar.localScale = new Vector3(speedScale, speedBar.localScale.y, speedBar.localScale.z);

        speedValue.text = playerSpacecraft.Speed.ToString("F2");
    }
}
