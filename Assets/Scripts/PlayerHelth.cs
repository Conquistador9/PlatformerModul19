using TMPro;
using UnityEngine;

public class PlayerHelth : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private TMP_Text _healthText;

    [Header("Setting")]
    [SerializeField] private float _maxHelth = 100f;
    private float _currentHelth;

    private void Awake()
    {
        _currentHelth = _maxHelth;
    }

    private void Update()
    {
        _healthText.text = _currentHelth.ToString();
    }

    public void TakeDamage(float damage)
    {
        _currentHelth -= damage;
        CheckIsAlive();
    }

    public void AddHealth(float amount)
    {
        _currentHelth += amount;

        if(_currentHelth > _maxHelth)
        {
            _currentHelth = _maxHelth;
        }
    }

    private void CheckIsAlive()
    {
        if(_currentHelth <= 0)
        {
            Destroy(gameObject);
        }
    }
}