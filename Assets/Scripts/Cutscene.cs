using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Cutscene : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;
    [SerializeField] private PrincessAnimations _anim;
    [SerializeField] private GameObject _cameraTwo;
    [SerializeField] private GameObject _cutscenePanel;
    [SerializeField] private GameObject _princessText;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _event?.Invoke();
            StartCoroutine(PrincessTimeUp());
            StartCoroutine(CameraTwoEnd());
            StartCoroutine(TextObjectActive());
        }
    }

    private IEnumerator CameraTwoEnd()
    {
        yield return new WaitForSeconds(10f);
        _princessText.SetActive(false);
        _cameraTwo.SetActive(false);
        _cutscenePanel.SetActive(false);
        _rigidbody.simulated = true;
    }

    private IEnumerator PrincessTimeUp()
    {
        yield return new WaitForSeconds(2f);
        _anim.PrincessUp();
    }

    private IEnumerator TextObjectActive()
    {
        yield return new WaitForSeconds(4f);
        _princessText.SetActive(true);
    }
}