using UnityEngine;

public class EnemyHelth : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private EnemyCollected _enemyCollected;

    [Header("Setting")]
    [SerializeField] private float _maxHealth = 100f;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            _enemyCollected.AddKill();
            Destroy(gameObject);
        }
    }
}