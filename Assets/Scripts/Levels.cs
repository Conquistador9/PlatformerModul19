using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody2D;
    [SerializeField] private GameObject _nextLevelPanel;
    [SerializeField] private GameOverScript _gameOverScript;

    public void NextLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            _nextLevelPanel.SetActive(true);
            _gameOverScript.CoinTextObjectDeactive();
        }
    }
}