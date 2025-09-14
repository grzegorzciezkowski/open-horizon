using Assets.Scripts.Translations;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Dropdown))]
public class LocalizedDropdown : MonoBehaviour
{
    [System.Serializable]
    public class KeyAndDefaultValue
    {
        public string key; public string defaultValue;
    }

    public List<KeyAndDefaultValue> localizedKeys = new();

    private TMP_Dropdown m_Dropdown;

    void Start()
    {
        m_Dropdown = GetComponent<TMP_Dropdown>();
    }

    public void OnEnable()
    {
        m_Dropdown = GetComponent<TMP_Dropdown>();
        UpdateText();
    }

    public void UpdateText()
    {
        for (int i = 0; i < localizedKeys.Count; i++)
        {
            m_Dropdown.options[i].text = TranslationManager.TranslateWithDefault(localizedKeys[i].key, localizedKeys[i].defaultValue);
        }
    }
}
