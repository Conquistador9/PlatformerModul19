using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Cutscene : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;
    [SerializeField] private PrincessAnimations _anim;
    [SerializeField] private GameObject _cameraTwo;
    [SerializeField] private GameObject _cutscenePanel;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _event?.Invoke();
            StartCoroutine(PrincessTimeUp());
            StartCoroutine(CutsceneEnd());
            StartCoroutine(CameraTwoEnd());
        }
    }

    private IEnumerator CameraTwoEnd()
    {
        yield return new WaitForSeconds(10f);
        _cameraTwo.SetActive(false);
    }

    private IEnumerator PrincessTimeUp()
    {
        yield return new WaitForSeconds(2f);
        _anim.PrincessUp();
    }

    private IEnumerator CutsceneEnd()
    {
        yield return new WaitForSeconds(10f);
        _rigidbody.simulated = true;
        _cutscenePanel.SetActive(false);
    }
}