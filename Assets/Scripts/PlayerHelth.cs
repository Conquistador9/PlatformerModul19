using UnityEngine;

public class PlayerHelth : MonoBehaviour
{
    [Header("Setting")]
    [SerializeField] private float _maxHelth = 100f;
    private float _currentHelth;

    private void Awake()
    {
        _currentHelth = _maxHelth;
    }

    public void TakeDamage(float damage)
    {
        _currentHelth -= damage;
        CheckIsAlive();
    }

    private void CheckIsAlive()
    {
        if(_currentHelth <= 0)
        {
            Destroy(gameObject);
        }
    }
}