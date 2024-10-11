using UnityEngine;
using TMPro;

public class Bonus : MonoBehaviour
{
    [SerializeField] private TMP_Text _bonusText;
    private int _bonusCount;

    private void Start()
    {
        BonusTable();
    }

    public void AddBonus()
    {
        _bonusCount++;
        BonusTable();
    }

    private void BonusTable() => _bonusText.text = _bonusCount.ToString();
}