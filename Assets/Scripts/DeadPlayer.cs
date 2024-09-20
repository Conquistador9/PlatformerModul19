using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private GameOverScript _gameOverScript;

    private void Update()
    {
        if(transform.position.y <= -2.5f)
        {
            _gameOverScript.DeathPanel();
            Destroy(gameObject);
        }
    }
}