using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using Assets.Scripts.Settings;

public class IncomeMessageNPC : MonoBehaviour
{
    public TMP_Text messageContent;
    public Transform buttonContainer;
    public GameObject buttonPrefab;
    public RawImage personImage;

    public void ShowIncomeTransmission(string text, string texture, Dictionary<string, Action> actions) { 
        gameObject.SetActive(true);

        messageContent.text = text;

        foreach (Transform child in buttonContainer)
        {
            Destroy(child.gameObject);
        }

        if (texture != null && texture != "")
        {
            personImage.texture = Resources.Load<Texture>("Images/" + texture);
        }

        if (actions == null)
        {
            actions = new Dictionary<string, Action>
            {
                { LanguageManager.Translate("HUD.Next", null), () => { } }
            };
        }

        foreach (KeyValuePair<string, Action> action in actions)
        {
            GameObject buttonObj = Instantiate(buttonPrefab, buttonContainer);
            TMP_Text btnText = buttonObj.GetComponentInChildren<TMP_Text>();
            btnText.text = action.Key;

            Button btn = buttonObj.GetComponent<Button>();
            btn.onClick.AddListener(() => { action.Value?.Invoke(); gameObject.SetActive(false); });
        }
    }
}
