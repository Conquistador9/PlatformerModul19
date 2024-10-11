using System.Collections;
using UnityEngine;

public class ActiveCollider : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _boxCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            StartCoroutine(TriggerActive());
        }
    }

    private IEnumerator TriggerActive()
    {
        yield return new WaitForSeconds(1f);
        _boxCollider.enabled = true;
    }
}