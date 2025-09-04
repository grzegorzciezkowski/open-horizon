using Assets.Scripts.Settings;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocalizedText : MonoBehaviour
{
    public string TranslationKey;
    public string DefaultText;

    private TMP_Text m_TextMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void OnEnable()
    {
        m_TextMeshPro = GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

    public void UpdateText()
    {
        if(m_TextMeshPro == null)
        {
            Debug.LogWarning("m_TextMeshPro is null for " + TranslationKey + ".");
            return;
        }

        if(LanguageManager.translations.ContainsKey(TranslationKey))
        {
            m_TextMeshPro.text = LanguageManager.translations[TranslationKey];
        } else
        {
            m_TextMeshPro.text = DefaultText;
        }
    }
}
