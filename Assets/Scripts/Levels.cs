using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D _playerRigidbody2D;
    [SerializeField] private GameOverScript _gameOverScript;
    [SerializeField] private GameOverScript _healthObject;

    [Header("PanelObject")]
    [SerializeField] private GameObject _nextLevelPanel;

    public void NextLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            _nextLevelPanel.SetActive(true);
            _gameOverScript.CoinTextObjectDeactive();
            _healthObject.HealthObjectDeactive();
        }
    }
}