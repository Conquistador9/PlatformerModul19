using TMPro;
using UnityEngine;

public class EnemyCollected : MonoBehaviour
{
    [Header("TextMexProObjects")]
    [SerializeField] private TMP_Text _enemyText;
    [SerializeField] private TMP_Text _enemyTextTwo;
    private int _enemyCount;

    private void Update()
    {
        EnemyCountText();
    }

    public void AddKill()
    {
        _enemyCount++;
        EnemyCountText();
    }

    private void EnemyCountText()
    {
        _enemyText.text = _enemyCount.ToString();
        _enemyText.text = ($"Убито врагов: {_enemyCount}");
        _enemyTextTwo.text = ($"Убито врагов: {_enemyCount}");
    }
}