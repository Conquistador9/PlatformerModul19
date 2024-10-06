using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;

    [Header("Component")]
    [SerializeField] private Rigidbody2D _playerRigidbody2D;

    public void NextLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            _event?.Invoke();
        }
    }
}