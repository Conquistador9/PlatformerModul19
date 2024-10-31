using UnityEngine;
using UnityEngine.Events;

public class GameOverEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _event?.Invoke();
        }
    }
}