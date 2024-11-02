using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrincessText : MonoBehaviour
{
    private TMP_Text _textUI;
    private List<string> _text = new List<string>() { "Na pomosch!", "Pochemu tak dolgo?", "Pomogi mne" };

    private void Awake()
    {
        _textUI = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        StartCoroutine(TextTimer());
    }

    private IEnumerator TextTimer()
    {
        for (int i = 0; i < _text.Count; i++)
        {
            _textUI.text = _text[i];
            yield return new WaitForSeconds(2f);
        }
    }
}