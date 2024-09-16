using UnityEngine;

public class Helth : MonoBehaviour
{
    [SerializeField] private EnemyCollected _enemyCollected;

    [Header("Settings")]
    [SerializeField] private float _maxHelth;
    private float _currentHelth;

    public float CurrentHelth { get => _currentHelth; private set => _currentHelth = value; }

    public float MaxHelth { get => _maxHelth; private set => _maxHelth = value; }

    private void Awake()
    {
        _currentHelth = _maxHelth;
    }

    public void TakeDamage(float damage)
    {
        _currentHelth -= damage;
        CheckIsAlive();
    }

    public void CheckIsAlive()
    {
        if(_currentHelth <= 0)
        {
            _enemyCollected.AddKill();
            Destroy(gameObject);
        }
    }
}