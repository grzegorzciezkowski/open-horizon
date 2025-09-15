using Assets.Scripts.Game;
using Assets.Scripts.Translations;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class ConfirmIdentityBtn : MonoBehaviour
{
    public GameController controller;

    public GameObject identityProtocolPanel;
    public TMP_InputField nameInput;
    public TMP_Dropdown genderDropdown;
    public IncomeMessageNPC incomeMessageNPC;

    public void ConfirmIdentity()
    {
        controller.SetPlayerInfo(nameInput.text, genderDropdown.value);
        identityProtocolPanel.SetActive(false);

        Dictionary<string, string> keys = new Dictionary<string, string>
        {
            { "NAME", nameInput.text }
        };

        string translationKey = "Prolog.AdmiralWelcomeMessage.Male";
        if(controller.gameInfo.Gender == SinglePlayerGameInfo.GENDER_FEMALE)
        {
            translationKey = "Prolog.AdmiralWelcomeMessage.Female";
        }

        string msg = TranslationManager.Translate(translationKey, keys);
        incomeMessageNPC.ShowIncomeTransmission(msg, "NPC/AdmiralVeynar", null);
    }
}
