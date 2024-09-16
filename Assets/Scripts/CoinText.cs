using UnityEngine;
using TMPro;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TMP_Text _collectedCoinsText;
    [SerializeField] private TMP_Text _collectedCoinsTextTwo;
    private int _coins;

    private void Start()
    {
        TextTable();
    }

    private void Update()
    {
        CollectedCoins();
    }

    public void AddCoin()
    {
        _coins++;
        _text.text = _coins.ToString();
        TextTable();
    }
    
    private void TextTable()
    {
        _text.text = ($" монеты: {_coins}");
    }

    private void CollectedCoins()
    {
        _collectedCoinsText.text = ($"Собрано монет: {_coins}");
        _collectedCoinsTextTwo.text = ($"Собрано монет: {_coins}");
    }
}