using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _coinTextObject;
    private GameObject _player;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if(_player.gameObject == null)
        {
            CoinTextObjectDeactive();
            DeathPanel();
        }
    }

    public void DeathPanel() => _gameOverPanel.SetActive(true);

    public void CoinTextObjectDeactive() => _coinTextObject.SetActive(false);
}