using Assets.Scripts.Translations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
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

        if(TranslationManager.translations.ContainsKey(TranslationKey))
        {
            m_TextMeshPro.text = TranslationManager.translations[TranslationKey];
        } else
        {
            m_TextMeshPro.text = DefaultText;
            Debug.LogWarning("Translation key '" + TranslationKey + "' not found. GameObject: " + gameObject.name);
        }
    }
}
