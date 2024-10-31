using System.Collections;
using UnityEngine;

public class CutsceneAnimEnd : MonoBehaviour
{
    [SerializeField] private Animator _animOne, _animTwo;

    private void Start()
    {
        StartCoroutine(AnimEnd());
    }

    private IEnumerator AnimEnd()
    {
        yield return new WaitForSeconds(8f);
        _animOne.SetTrigger("UpAnim");
        _animTwo.SetTrigger("Down");
    }
}